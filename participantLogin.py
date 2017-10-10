import MySQLdb
import json
from _mysql import Error
import sys

# Prints "Login Failed." if db fails to return the participant id from the login
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
                             
    c = db.cursor()
    c.execute("SELECT participant_id FROM participants WHERE username = %s AND password = %s", (username, password))
                                     
    ret = c.fetchone()
    if ret == None:
        print "Login Failed.";
    else:
        jsonRet = {}
        jsonRet['participant_id'] = ret[0];
        print json.dumps(jsonRet);
                                                 
    db.close()



participantLogin(sys.argv[1], sys.argv[2])