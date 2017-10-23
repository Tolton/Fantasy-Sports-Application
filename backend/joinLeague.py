import MySQLdb
from _mysql import Error
import sys
import os

# joinLeague takes in the username and the league name to join. It then inserts this information into the league_roster table
def joinLeague(username, leagueName):
    
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

    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", leagueName)
    leagueID = cursor.fetchone()

    cursor.execute("INSERT INTO league_roster(participant_id, league_id) VALUES(%s, %s)", (participantID[0], leagueID[0]))
    db.commit()
    
    db.close()


joinLeague(sys.argv[1], sys.argv[2])