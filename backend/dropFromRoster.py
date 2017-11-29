import MySQLdb
from _mysql import Error
import sys

# dropFromRoster takes the username, team name and player name to be dropped from the team
# It then updates the roster table
# PLAYER NAME MUST BE IN FORM OF "FName LName"

def dropFromRoster(leagueName, username, playerName):
    
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
    # check if the user can't be found
    if participantID == None:
        print "Could not find that user."
        db.close()
        sys.exit(0)
    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", [leagueName])
    leagueID = cursor.fetchone()

    # check if the league name entered is wrong
    if cursor.rowcount == 0:
        print "Could not find that league."
        db.close()
        sys.exit(0)
    
    cursor.execute("SELECT league_roster_id FROM league_roster WHERE participant_id = %s AND league_id = %s", (participantID[0], leagueID[0]))
    leagueRosterID = cursor.fetchone()
    leagueRosterID = leagueRosterID[0]

    cursor.execute("UPDATE roster SET date_acquired = 99991230 WHERE player_name = %s AND league_roster_id = %s", (playerName, leagueRosterID))
    db.commit()
    db.close()

# leagueName, username, playerName
dropFromRoster(sys.argv[1], sys.argv[2], sys.argv[3])
