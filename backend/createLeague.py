import MySQLdb
from _mysql import Error
import sys

# createLeague takes in the username, league name, list of rules, max players for the league and the name in the 3 letter abbreviation, as well as the team name and the private key (1 for private or 0 for public)
# inserts into league as well as the intermediary table -> league_roster

def createLeague(username, leagueName, leaguePassword, rulesList, maxPlayers, sportID, teamName, privateKey):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False

    cursor = db.cursor()

    # check if the user exists
    cursor.execute("SELECT participant_id FROM participants WHERE username = %s", [username])
    participantID = cursor.fetchone()
    
    if participantID == None:
        print "Could not find user"
        sys.exit(0)

    # Will print League Name taken if there already exists a league name of the same name in the table
    cursor.execute("SELECT COUNT(league_name) FROM league WHERE league_name = %s", [leagueName])
    ret = cursor.fetchone()

    if ret[0] > 0:
        print "League Name taken"
        sys.exit(0)

    # Changes the password to blank if the league is public
    if privateKey == "0":
        leaguePassword = ""
    elif leaguePassword == "":
        # If the league is private and has no password, exit
        print "No password given for private league"
        sys.exit(0)

    query = "INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_players, sport_id, private) VALUES(%s, %s, %s, %s, %s, %s, %s)"
    cursor.execute(query, (leagueName, leaguePassword, participantID[0], rulesList, maxPlayers, sportID, privateKey))
    db.commit()
    
    # Grab the league id of the last instert
    cursor.execute("SELECT league_id FROM league WHERE league_name = %s AND league_pass = %s AND commissioner_id = %s AND rules = %s AND max_players = %s AND sport_id = %s AND private = %s", (leagueName, leaguePassword, participantID[0], rulesList, maxPlayers, sportID, privateKey))
        
    
    leagueID = cursor.fetchone()
        
    query = "INSERT INTO league_roster(participant_id, league_id, team_name) VALUES(%s, %s, %s)"
    cursor.execute(query, (participantID[0], leagueID[0], teamName))
    db.commit()

    
    
    db.close()


#username, league name, league password, rules, max players, sport id, team name
createLeague(sys.argv[1], sys.argv[2], sys.argv[3], sys.argv[4], sys.argv[5], sys.argv[6], sys.argv[7], sys.argv[8])