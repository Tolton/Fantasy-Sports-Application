import MySQLdb
from _mysql import Error
import sys
import hashlib
import os

def createParticipant(username, password):
    
    userName = "teamOgre"
    passName = "sportsApp123"
    hostName = "cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com"
    dbName   = "fantasySportsApplication"
    
    try:
        db = MySQLdb.connect(user=userName, passwd=passName, host=hostName, db = dbName)
    
    except Error as e:
        return False
    
    cursor = db.cursor()

    
    #Inserting a new participant
    salt = os.urandom(8)
    hash_object = hashlib.sha256(password)
    hex_dig = hash_object.hexdigest()

    try:
        query = "INSERT INTO participants(username, password) VALUES(%s, %s)"
        cursor.execute(query, (username, hex_dig))
        
        db.commit()
    except Error as h:
        print "Duplicate entry"
    
    db.close()




createParticipant(sys.argv[1], sys.argv[2])
