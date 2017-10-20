import MySQLdb
from _mysql import Error
import sys
import os

# createLeague takes in the username, list of rules, max players for the league and the name in the 3 letter abbreviation


def createLeague(username, leagueName, rulesList, maxPlayers, sportID):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False

    cursor = db.cursor()

    query = "SELECT participant_id FROM participants WHERE username = %s"
    cursor.execute(query, username)

    participantID = cursor.fetchone()
    
    try:
        query = "INSERT INTO league(league_name, commissioner_id, rules, max_players, sport_id) VALUES(%s, %s, %s, %s, %s)"
        cursor.execute(query, (leagueName, participantID[0], rulesList, maxPlayers, sportID))
        db.commit()
    except TypeError:
        print "Something went wrong.."
    
    
    db.close()



#username, league name, rules, max players, sport id
createLeague(sys.argv[1], sys.argv[2], sys.argv[3], sys.argv[4], sys.argv[5])