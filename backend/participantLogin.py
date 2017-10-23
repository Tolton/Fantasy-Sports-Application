import MySQLdb
import json
from _mysql import Error
import sys
import os
import hashlib

# Prints the json with a participant id of 0  if db fails to return the participant id from the login
# Prints the json of the participant id if the login is correct

def participantLogin(username, password):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False
    cursor = db.cursor()

    # Grab the salt for that user
    cursor.execute('SELECT salt FROM participants WHERE username="{0}"'.format(username))
    salt = cursor.fetchone()

    # Create the hashed password
    hex_dig = hashlib.sha256(salt[0] + password).hexdigest()
    print hex_dig

    cursor.execute('SELECT participant_id FROM participants WHERE username="{0}" AND password="{1}"'.format(username, hex_dig))
                                     
    ret = cursor.fetchone()
    if ret == None:
        jsonRet = {}
        jsonRet['participant_id'] = 0;
        print json.dumps(jsonRet);
    else:
        jsonRet = {}
        jsonRet['participant_id'] = ret[0];
        print json.dumps(jsonRet);
                                                 
    db.close()



participantLogin(sys.argv[1], sys.argv[2])
