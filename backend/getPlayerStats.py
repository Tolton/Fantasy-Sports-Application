# Code taken from sample code found at https://www.mysportsfeeds.com/data-feeds/api-docs/#
import base64
import requests
import json
import sys

# send_request takes in the first name and last name of the player to be found. It then returns the json for the
# 2016-2017 regular season stats (current stats are being approved by mysportsfeed staff)
# Needed approval as a student/developer to access current stats without paying.
def send_request(fName, lName):

    playerName = fName + "-" + lName
    
    try:
        response = requests.get(
            url="https://api.mysportsfeeds.com/v1.1/pull/nhl/2016-2017-regular/cumulative_player_stats.json?playerstats=G,A,Pts,Sh",
            params={
                    "player":playerName
                    },
            headers={"Authorization": "Basic " + base64.b64encode('{}:{}'.format("Tolton15","sportsApp123").encode('utf-8')).decode('ascii')})
        
        print json.dumps(response.json(), indent = 1)

    except requests.exceptions.RequestException:
        print('HTTP Request failed')


send_request(sys.argv[1], sys.argv[2])