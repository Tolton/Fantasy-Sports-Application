import MySQLdb
from _mysql import Error
import sys
import json

# takes the league name and returns the json of the standings
def leagueStandings(leagueName):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False
    
    cursor = db.cursor()

    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", [leagueName])
    leagueID = cursor.fetchone()
    leagueID = leagueID[0]

    points = 0

    cursor.execute("SELECT league_roster_id, participant_id FROM league_roster WHERE league_id = %s", [leagueID])
    leagueRosterID = cursor.fetchall()
    retJson = []
    for row in leagueRosterID:
        points = 0
        # grab the username
        cursor.execute("SELECT username FROM participants WHERE participant_id = %s", [row[1]])
        currUser = cursor.fetchone()
        currUser = currUser[0]
        # grab each players points in the roster and add together
        cursor.execute("SELECT points FROM roster WHERE league_roster_id = %s", [row[0]])
        nextPoints = cursor.fetchall()
        for i in nextPoints:
            points = points + i[0]
        currJson = {}
        currJson['participant'] = currUser
        currJson['points'] = points
        retJson.append(currJson)

    print json.dumps(retJson)




# league name
leagueStandings(sys.argv[1])