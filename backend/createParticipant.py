import MySQLdb
from _mysql import Error
import sys

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
    try:
        query = "INSERT INTO participants(username, password) VALUES(%s, %s)"
        cursor.execute(query, (username, password))


        #Below commented code is for testing to make sure the user was added to db
        #query = "SELECT * FROM participants"
        #cursor.execute(query)
        
        db.commit()
    except Error as h:
        print "Error: ", h[0]
    
    db.close()


createParticipant(sys.argv[1], sys.argv[2])