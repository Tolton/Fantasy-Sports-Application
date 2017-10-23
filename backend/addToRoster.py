import MySQLdb
from _mysql import Error
import sys
import time

# addToRoster takes the username, team name and player name to be added to the team
# It then inserts into the roster table

def addToRoster(username, teamName, playerName):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False

    cursor = db.cursor()

    cursor.execute("SELECT participant_id FROM participants WHERE username = %s", username)
    participantID = cursor.fetchone()

    cursor.execute("SELECT league_roster_id, league_id FROM league_roster WHERE participant_id = %s AND team_name = %s", (participantID[0], teamName))
    leagueRosterID = cursor.fetchall()

    cursor.execute("SELECT sport_id FROM league WHERE league_id = %s", (leagueRosterID[0][1]))
    sportID = cursor.fetchone()

    dateAdded = time.strftime("%Y-%m-%d %T")

    points = 0

    cursor.execute("INSERT INTO roster(league_roster_id, player_name, sport, points, date_acquired) VALUES(%s, %s, %s, %s, %s)", (leagueRosterID[0][0], playerName, sportID[0], points, dateAdded))


    db.commit()
    db.close()



#username, teamName, playerName
addToRoster(sys.argv[1], sys.argv[2], sys.argv[3])