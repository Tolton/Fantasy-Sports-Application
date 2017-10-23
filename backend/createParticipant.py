import MySQLdb
from _mysql import Error
import sys
import hashlib
import os
import random

# createParticipant creates a new user
# It takes in the username and the password of the new user. A salt is randomly generated and the password is hashed and salted. Then the username password and salt are stored in the database.
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
    
    salt = os.urandom(16).encode('hex')

    # Avoiding duplicate salts(yes I know this will almost never happen.. except during the Alpha -.-)
    cursor.execute("SELECT COUNT(username) FROM participants WHERE salt = %s", salt)
    ret = cursor.fetchone()
    while ret[0] > 0:
        salt = os.urandom(16).encode('hex')
        cursor.execute("SELECT COUNT(username) FROM participants WHERE salt = %s", salt)
        ret = cursor.fetchone()

    # Creating the hashed and salted password
    hash_object = hashlib.sha256(salt + password)
    hex_dig = hash_object.hexdigest()

    # Avoiding duplicate usernames(if there is 1 or more usernames the same returned Count will be > 0)
    cursor.execute("SELECT COUNT(username) FROM participants WHERE username = %s", username)
    ret = cursor.fetchone()
    if ret[0] > 0:
        print "Username is taken"
    else:
        cursor.execute("INSERT INTO participants(username, password, salt) VALUES(%s, %s, %s)", (username, hex_dig, salt))
        
    db.commit()
    
    db.close()


createParticipant(sys.argv[1], sys.argv[2])
