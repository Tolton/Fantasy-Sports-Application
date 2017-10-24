import MySQLdb
from _mysql import Error
import sys
import json

# pullLeagueList takes the user name to pull all league names the user is a part of. It then prints the json
def pullLeagueList(username):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False
    
    cursor = db.cursor()
    
    cursor.execute("SELECT participant_id FROM participants WHERE username='{0}'".format(username))
    participantID = cursor.fetchone()


    cursor.execute("SELECT league_id FROM league_roster WHERE participant_id={0}".format(participantID[0]))
    leagueID = cursor.fetchall()
    
    jsonRet = {}
    i = 0
    for row in leagueID:
        cursor.execute("SELECT league_name FROM league WHERE league_id=1")
        
        jsonRet[i] = cursor.fetchone()
        i = i + 1
    print json.dumps(jsonRet)
    
    db.close()


pullLeagueList(sys.argv[1])
