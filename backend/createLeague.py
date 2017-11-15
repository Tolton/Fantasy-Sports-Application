import MySQLdb
from _mysql import Error
import sys
import hashlib
import random
import os

# createLeague takes in the username, league name, max players, sportID (nhl, nfl etc), as well as the team name and the private key (1 for private or 0 for public)
# it also takes in some rules for the league including the max Teams, max centers, max left wings, max right wings, max defense and max goalies
# statsList is a comma delimited string cosisting of the following GamesPlayed,Goals,Assists,Points,HatTricks,Penalties,PenaltyMinutes,PowerplayGoals,PowerplayAssists,PowerplayPoints,ShorthandedGoals,ShorthandedAssists,ShorthandedPoints,GameWinningGoals,GameTyingGoals,PlusMinus,Shots,ShotPercentage,Hits,Faceoffs,FaceoffWins,FaceoffLosses,FaceoffPercent,Wins,Losses,OvertimeWins,OvertimeLosses,GoalsAgainst,ShotsAgainst,Saves,GoalsAgainstAverage,SavePercentage,Shutouts,GamesStarted,CreditForGame,MinutesPlayed
# inserts into league as well as the intermediary table -> league_roster and inserts the rules into the rules table.

def createLeague(username, leagueName, leaguePassword, maxPlayers, sportID, teamName, privateKey, maxTeams, maxC, maxLW, maxRW, maxD, maxG, statsList):
    
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
        hex_dig = ""
        salt = ""
    elif leaguePassword == "":
        # If the league is private and has no password, exit
        print "No password given for private league"
        sys.exit(0)

    # Insert all the values into the rules table
    cursor.execute("INSERT INTO rules(max_teams, max_c, max_lw, max_rw, max_d, max_g, stats_list) VALUES(%s, %s, %s, %s, %s, %s, %s)", (maxTeams, maxC, maxLW, maxRW, maxD, maxG, statsList))
    db.commit()
    # Grab the id of the rules table insertion
    cursor.execute("SELECT LAST_INSERT_ID()")

    rulesID = cursor.fetchone()

    if privateKey == "1":
        salt = os.urandom(16).encode('hex')
    
        # Avoiding duplicate salts(yes I know this will almost never happen.. except during the Alpha -.-)
        cursor.execute("SELECT COUNT(league_name) FROM league WHERE salt = %s", [salt])
        ret = cursor.fetchone()
        while ret[0] > 0:
            salt = os.urandom(16).encode('hex')
            cursor.execute("SELECT COUNT(league_name) FROM league WHERE salt = %s", [salt])
            ret = cursor.fetchone()
    
        # Creating the hashed and salted password
        hash_object = hashlib.sha256(salt + leaguePassword)
        hex_dig = hash_object.hexdigest()

    query = "INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_players, sport_id, private, salt) VALUES(%s, %s, %s, %s, %s, %s, %s, %s)"
    cursor.execute(query, (leagueName, hex_dig, participantID[0], rulesID[0], maxPlayers, sportID, privateKey, salt))
    db.commit()
    
    # Grab the league id of the last insert
    cursor.execute("SELECT LAST_INSERT_ID()")
        
    
    leagueID = cursor.fetchone()
        
    query = "INSERT INTO league_roster(participant_id, league_id, team_name) VALUES(%s, %s, %s)"
    cursor.execute(query, (participantID[0], leagueID[0], teamName))
    db.commit()

    
    
    db.close()


#username, league name, league password, rules, max players, sport id, team name
createLeague(sys.argv[1], sys.argv[2], sys.argv[3], sys.argv[4], sys.argv[5], sys.argv[6], sys.argv[7], sys.argv[8], sys.argv[9], sys.argv[10], sys.argv[11], sys.argv[12], sys.argv[13], sys.argv[14])