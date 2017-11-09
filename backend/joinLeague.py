import MySQLdb
from _mysql import Error
import sys

# joinLeague takes in the username and the league name to join. It then inserts this information into the league_roster table
def joinLeague(username, leagueName, leaguePassword, teamName):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False
    
    cursor = db.cursor()

# username checking
    cursor.execute("SELECT participant_id FROM participants WHERE username = %s", [username])
    participantID = cursor.fetchone()
    if participantID == None:
        print "Could not find the username."
        sys.exit(0)

# changes password to blank if the league is public
    cursor.execute("SELECT private FROM league WHERE league_name = %s", [leagueName])
    privateKey = cursor.fetchone()

    if privateKey[0] == 0:
        leaguePassword = ""

# league and password checking
    cursor.execute("SELECT league_id, rules FROM league WHERE league_name = %s AND league_pass = %s", (leagueName, leaguePassword))
    ret = cursor.fetchall()
    leagueID = ret[0][0]
    rulesID = ret[0][1]

    if cursor.rowcount == 0:
        print "Invalid league name or password."
        sys.exit(0)
    
# check if there already is the max teams in the league
    cursor.execute("SELECT max_teams FROM rules WHERE rules_id = %s", [rulesID])
    maxTeams = cursor.fetchone()
    cursor.execute("SELECT COUNT(*) FROM league_roster WHERE league_id = %s", [leagueID])
    leagueTeams = cursor.fetchone()
    if leagueTeams[0] >= maxTeams[0]:
        print "League has reached max teams."
        sys.exit(0)

# Already in a league checking
    cursor.execute("SELECT COUNT(*) FROM league_roster WHERE participant_id = %s AND league_id = %s", (participantID[0], leagueID))
    ret = cursor.fetchone()
    if ret[0] > 0:
        print "Cannot join a league you are already in."
        sys.exit(0)

# team name in league already taken
    cursor.execute("SELECT COUNT(*) FROM league_roster WHERE league_id = %s AND team_name = %s", (leagueID, teamName))
    ret = cursor.fetchone()
    if ret[0] > 0:
        print "Team name already taken."
        sys.exit(0)

    cursor.execute("INSERT INTO league_roster(participant_id, league_id, team_name) VALUES(%s, %s, %s)", (participantID[0], leagueID, teamName))
    db.commit()
    
    db.close()


joinLeague(sys.argv[1], sys.argv[2], sys.argv[3], sys.argv[4])