import MySQLdb
from _mysql import Error
import sys
import json

# pullRoster takes the username and the team name
# It then pulls the list of players according to that user and their team
def pullRoster(leagueName, username):
    
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

    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", [leagueName])
    leagueID = cursor.fetchone()
    
    cursor.execute("SELECT league_roster_id FROM league_roster WHERE participant_id = %s AND league_id = %s", (participantID[0], leagueID[0]))
    leagueRosterID = cursor.fetchall()
    
    if cursor.rowcount == 0:
        print "Could not find that team"
        sys.exit(0)

    cursor.execute("SELECT sport_id FROM league WHERE league_id = %s", [leagueID[0]])
    sportID = cursor.fetchone()
    
    cursor.execute("SELECT * FROM roster WHERE league_roster_id = %s", [leagueRosterID[0]])
    playerList = cursor.fetchall()
    
    jsonRet = {}
    i = 0
    for row in playerList:
        jsonRet[i] = row[2]
        i = i +1

    print json.dumps(jsonRet)
    db.close()



#username, team name
pullRoster(sys.argv[1], sys.argv[2])