import MySQLdb
from _mysql import Error
import sys
import json

#
def pullParticipantList(leagueName):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False

    cursor = db.cursor()
    
    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", leagueName)
    ret = cursor.fetchone()
    leagueID = ret[0]

    cursor.execute("SELECT participant_id FROM league_roster WHERE league_id = %s", leagueID)
    participantID = cursor.fetchall()

    jsonRet = {}
    i = 0
    for row in participantID:
        cursor.execute("SELECT username FROM participants WHERE participant_id = %s", row[0])

        jsonRet[i] = cursor.fetchone()
        i = i + 1
    print json.dumps(jsonRet)
    
    db.close()


pullParticipantList(sys.argv[1])