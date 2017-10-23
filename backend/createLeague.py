import MySQLdb
from _mysql import Error
import sys

# createLeague takes in the username, league name, list of rules, max players for the league and the name in the 3 letter abbreviation
# inserts into league as well as the intermediary table -> league_roster

def createLeague(username, leagueName, leaguePassword, rulesList, maxPlayers, sportID):
    
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
    
    
        # Will print League Name taken if there already exists a league name of the same name in the table
    cursor.execute("SELECT COUNT(league_name) FROM league WHERE league_name = %s", leagueName)
    ret = cursor.fetchone()
    if ret[0] > 0:
        print "League Name taken"
    else:
    
        query = "INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_players, sport_id) VALUES(%s, %s, %s, %s, %s, %s)"
        cursor.execute(query, (leagueName, leaguePassword, participantID[0], rulesList, maxPlayers, sportID))
        db.commit()
        
        query = "SELECT LAST_INSERT_ID()"
        cursor.execute(query)
        
    
        leagueID = cursor.fetchone()
            
        teamName = "My Team"

        query = "INSERT INTO league_roster(participant_id, league_id, team_name) VALUES(%s, %s, %s)"
        cursor.execute(query, (participantID[0], leagueID[0], teamName))
        db.commit()

    
    
    db.close()


#username, league name, league password, rules, max players, sport id
createLeague(sys.argv[1], sys.argv[2], sys.argv[3], sys.argv[4], sys.argv[5], sys.argv[6])