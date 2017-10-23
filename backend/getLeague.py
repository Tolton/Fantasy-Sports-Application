import MySQLdb
from _mysql import Error
import json
import sys
import os

# getLeague takes in the username of the participant you want to get the leagues for
# dumps the json of all leagues returned
def getLeague(username):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False

    cursor = db.cursor()

    # get the participant_id
    cursor.execute("SELECT participant_id FROM participants WHERE username='{0}'".format(username))
    
    participantID = cursor.fetchone()[0]

    # get the league_id
    cursor.execute("SELECT league_id FROM league_roster WHERE participant_id={0}".format(participantID))
    
    leagueID = cursor.fetchall()

    # create the json of the leagues returned
    jsonRet = {}
    i = 0
    for row in leagueID:
        cursor.execute("SELECT * FROM league WHERE league_id={0}".format(row[0]))

        jsonRet[i] = cursor.fetchone()
        i = i + 1
    
    

    print json.dumps(jsonRet);




    db.close()



#username
getLeague(sys.argv[1])
