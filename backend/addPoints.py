import MySQLdb
from _mysql import Error
import sys
import requests
import json
import base64

# addPoints grabs all names from the roster table and updates the points according to the date acquired
def addPoints(leagueName):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False
    
    cursor = db.cursor()

# grab only the certain league
    cursor.execute("SELECT league_id FROM league WHERE league_name = %s", [leagueName])
    ret = cursor.fetchone()
    ret = ret[0]

    
    # grab id, play name and date from the participant who is in that league
    cursor.execute("SELECT league_roster_id, player_name, date_acquired FROM roster WHERE league_roster_id IN (SELECT league_roster_id FROM league_roster WHERE league_id = %s)", [ret])
    ret = cursor.fetchall()

    for row in ret:
        
        leagueRosterID = row[0]
        playerName = row[1]
        
        
        cursor.execute("SELECT league_id FROM league_roster WHERE league_roster_id = %s", [leagueRosterID])
        leagueID = cursor.fetchone()
        leagueID = leagueID[0]
        
        
        cursor.execute("SELECT rules FROM league WHERE league_id = %s", [leagueID])
        rulesID = cursor.fetchone()
        rulesID = rulesID[0]

        cursor.execute("SELECT stats_list FROM rules WHERE rules_id = %s", [rulesID])
        statsList = cursor.fetchone()
        statsList = statsList[0]
        list = statsList.split(',')
        
        points = 0
        date = row[2]


        try:
            response = requests.get(
                            url="https://api.mysportsfeeds.com/v1.1/pull/nhl/2017-2018-regular/player_gamelogs.json",
                                params={
                                "player":playerName.replace(' ', '-'),
                                "date":"since-"+date
                                
                                },
                            
            headers={"Authorization": "Basic " + base64.b64encode('{}:{}'.format("Tolton15","sportsApp123").encode('utf-8')).decode('ascii')})
                            
        
            response = response.json()
            try:
                
                playStats = response['playergamelogs']['gamelogs']
                for line in playStats:
                    #get the list of stats you want as points and add them
                    for h in list:
                        points = points + int(line['stats'][h]['#text'])

# update points in roster table
                cursor.execute("UPDATE roster SET points = %s WHERE league_roster_id = %s AND player_name = %s", (points, leagueRosterID, playerName.replace('-', ' ')))
                db.commit()

            except KeyError:
                print "Could not find anything for this player"
            #continuing

        except requests.exceptions.RequestException:
                print('HTTP Request failed')


    db.commit()
    db.close()

addPoints(sys.argv[1])
