import MySQLdb
from _mysql import Error
import sys
import time
import requests
import base64
import json

# addToRoster takes the username, team name and player name to be added to the team
# It then inserts into the roster table
# PLAYER NAME MUST BE IN FORM OF "FName LName"

def addToRoster(leagueName, username, playerName):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False

    cursor = db.cursor()

    cursor.execute("SELECT participant_id FROM participants WHERE username = %s", [username])
    participantID = cursor.fetchone()
    # check if the user can't be found
    if participantID == None:
        print "Could not find that user."
        db.close()
        sys.exit(0)
    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", [leagueName])
    leagueID = cursor.fetchone()

    cursor.execute("SELECT league_roster_id FROM league_roster WHERE participant_id = %s AND league_id = %s", (participantID[0], leagueID[0]))
    leagueRosterID = cursor.fetchall()
        # check if the team name entered is wrong
    if cursor.rowcount == 0:
        print "Could not find that team."
        db.close()
        sys.exit(0)

    cursor.execute("SELECT sport_id, max_players FROM league WHERE league_id = %s", [leagueRosterID[0]])
    ret = cursor.fetchall()
    sportID = ret[0][0]
    maxPlayers = ret[0][1]


# check if they already have the max players on the team
    cursor.execute("SELECT COUNT(player_name) FROM roster WHERE league_roster_id = %s", [leagueRosterID[0]])
    playCount = cursor.fetchone()
    if playCount[0] >= maxPlayers:
        print "Adding too many players."
        db.close()
        sys.exit(0)


# check if the player is already taken
    cursor.execute("SELECT league_roster_id FROM league_roster WHERE league_id = %s", [leagueID])
    allUsers = cursor.fetchall()

    for row in allUsers:
        cursor.execute("SELECT player_name FROM roster WHERE league_roster_id = %s", [row[0]])
        # get all players in the team
        ret = cursor.fetchall()
        
        # get each player individually
        for line in ret:
            # check if the the current player is equal to the player being entered
            if line[0].lower() == playerName.lower():
                print "Player is already taken"
                db.close()
                sys.exit(0)


# check if the player exists
    
    try:
        response = requests.get(url="https://api.mysportsfeeds.com/v1.1/pull/"+sportID+"/2017-2018-regular/active_players.json",
        params={
                "player":playerName.replace(' ', '-')
                },
        headers={"Authorization": "Basic " + base64.b64encode('{}:{}'.format("Tolton15","sportsApp123").encode('utf-8')).decode('ascii')})
        
        response = response.json()
        try:
            playName =  json.dumps(response['activeplayers']['playerentry'][0]['player']['FirstName']).replace('"', '') + " " + json.dumps(response['activeplayers']['playerentry'][0]['player']['LastName']).replace('"', '')
        except KeyError:
            print "Could not find the player"
            db.close()
            sys.exit(0)

    except requests.exceptions.RequestException:
        print('HTTP Request failed')
        db.close()
        sys.exit(0)



    dateAdded = time.strftime("%Y-%m-%d %T")

    points = 0

    cursor.execute("INSERT INTO roster(league_roster_id, player_name, sport, points, date_acquired) VALUES(%s, %s, %s, %s, %s)", (leagueRosterID[0], playerName, sportID, points, dateAdded))


    db.commit()
    db.close()

# leagueName, username, playerName
addToRoster(sys.argv[1], sys.argv[2], sys.argv[3])