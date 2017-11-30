using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace FantasySportsApplication
{
    public static class Backend
    {
        
        private static String HashString(String value)
        /*  
         *  .SYNOPSIS
         *      Converts a regular string to its SHA256-hashed equivalent
         *      
         *  .PARAMETERS
         *      [0] (String) value
         *          This is the original string that is to be converted to the SHA256 hash
         *          
         *  .OUTPUT
         *      (String)
         *          The SHA256-hash as a string
         */
        {
            StringBuilder Sb = new StringBuilder();

            //Convert the string to its SHA256 hash-equivalent
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            //Return the hashed string
            return Sb.ToString();
        }

        private static string GetRandomHexNumber(int digits)
        /*  
         *  .SYNOPSIS
         *      Generates a random hex number stored inside of a string
         *      
         *  .PARAMETERS
         *      [0] (int) digits
         *          Dictates the length of the hex value by number of digits
         *          
         *  .OUTPUT
         *      (String)
         *          The random hex string
         */
        {
            Random random = new Random();
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        public static int Login(String username, String password)
        /*  
         *  .SYNOPSIS
         *      Establishes a connection with the backend and verifies the user's credentials
         *      
         *  .PARAMETERS
         *      [0] (String) username
         *          The username that the user is trying to log in with
         *          
         *      [1] (String) password
         *          The unhashed and unsalted raw password that the user is trying to log in with
         *          
         *  .OUTPUT
         *      (int)
         *             -1: Unable to establish a connection to the backend
         *             -2: Username does not exist in the database
         *             -3: Password does not match the one stored in the database
         *          other: Successful login; returns the participantID from the participants table
         */
        {
            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                //Successful connection
                cnn.Open();
            }
            catch
            {
                //Unable to establish a connection to the backend
                return -1;
            }

            //Grab the salt from the database if the username exists
            MySqlCommand cmdSql;
            MySqlDataReader rdr;
            String saltedPassword;
            cmdSql = new MySqlCommand(String.Format("SELECT salt FROM participants WHERE username='{0}';", username), cnn);

            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            try 
            {
                //Username exists, salt and hash the password
                saltedPassword = (HashString(rdr["salt"] + password));
            }
            catch
            {
                //Username does not exist in the database
                return -2;
            }
            rdr.Close();

            //Attempt to login with the username and salted password
            int CurrentID;
            cmdSql = new MySqlCommand(String.Format("SELECT participant_id FROM participants WHERE username='{0}' AND password='{1}';", username, saltedPassword), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            
            try
            {
                //Successful login
                CurrentID = (int)rdr["participant_id"];
            }
            catch
            {
                //Password does not match the one stored in the database
                return -3;
            }

            rdr.Close();
            cnn.Close();

            //Successful login; returns the participantID from the participants table
            return CurrentID;
        }

        public static String[] PullLeagues(int userid)
        /*  
         *  .SYNOPSIS
         *      Pulls list of leagues that the user belongs to
         *      
         *  .PARAMETERS
         *      [0] (int) userid
         *          The userID that the list of leagues is being pulled for
         *          
         *  .OUTPUT
         *      (StringArray)
         *          Returns an array of strings, one string per league name
         *          Returns null if user belongs to no leagues
         */
        {
            //Open connection to pull list of League IDs
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();

            //Get the number of Leagues
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE participant_id={0};", userid), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int LeagueCount = rdr.GetInt32(0);
            if (LeagueCount == 0)
            {
                return null;
            }
            rdr.Close();

            int[] leagueIDs = new int[LeagueCount];

            //Get list of leagueIDs
            cmdSql = new MySqlCommand(String.Format("SELECT league_id FROM league_roster WHERE participant_id={0};", userid), cnn);
            rdr = cmdSql.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                leagueIDs[i++] = rdr.GetInt32(0);
            }
            rdr.Close();

            //Get list of leagueNames
            String[] LeagueNames = new String[LeagueCount];
            for (i=0; i<LeagueCount; i++)
            {
                cmdSql = new MySqlCommand(String.Format("SELECT league_name FROM league WHERE league_id={0};", leagueIDs[i]), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                LeagueNames[i] = rdr.GetString(0);
                rdr.Close();
            }
            return LeagueNames;
        }

        public static int Register(String username, String password, String passwordconfirm)
        /*  
         *  .SYNOPSIS
         *      Creates an entry for a new username/password in the database
         *      
         *  .PARAMETERS
         *      [0] (String) username
         *          The username that the user is trying to register
         *          
         *      [1] (String) password
         *          The unhashed and unsalted raw password that the user is trying to register with
         *          
         *      [2] (String) passwordconfirm
         *          Confirmation password -- should be identical to password
         *          
         *  .OUTPUT
         *      (int)
         *           0: Successful registration
         *          -1: Password and Confirmation Password do not match
         *          -2: Unable to establish a connection to the backend
         *          -3: Username already exists in the database
         */
        {
            //Check if the confirmation password matches
            if (password != passwordconfirm)
            {
                //Password and Confirmation Password do not match
                return -1;
            }

            //Attempt to establish a connection to the server
            MySqlCommand cmdSql;
            MySqlDataReader rdr;
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                cnn.Open();
            }
            catch
            {
                //Unable to establish a connection to the backend
                return -2;
            }

            //Check if username already exists
            cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM participants WHERE username='{0}';", username), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0)
            {
                //Username already exists in the database
                return -3;
            }
            rdr.Close();

            //Salt the password
            String salt = GetRandomHexNumber(32);
            String saltedPassword = HashString(salt + password);

            //Insert the user into the database
            cmdSql = new MySqlCommand(String.Format("INSERT INTO participants(username,password,salt) VALUES('{0}','{1}','{2}');", username, saltedPassword, salt), cnn);
            cmdSql.ExecuteNonQuery();

            cnn.Close();

            //Successful registration
            return 0;
        }

        public static int CreateLeague(int userid, String LeagueName, Boolean Public, String LeaguePassword, String StatsList, int MaxTeams, int MaxC, int MaxLW, int MaxRW, int MaxD, int MaxG, String SportID, String TeamName)
        /*  
         *  .SYNOPSIS
         *      Creates an entry for a new league in the database and adds the current user to it
         *      
         *  .PARAMETERS
         *      [0]  (int) userid
         *           The userID of the user creating the league
         *          
         *      [1]  (String) LeagueName
         *           The name of the league
         *          
         *      [2]  (Boolean) Public
         *           Represents whether the league is public (true) or private (false)
         *          
         *      [3]  (String) LeaguePassword
         *           The password to join the league (blank if league is public)
         *          
         *      [4]  (String) StatsList
         *           A comma-delimited list containing all of the scoring categories for the league
         *           
         *      [5]  (int) MaxTeams
         *           The maximum number of teams allowed to join a league
         *          
         *      [6]  (int) MaxC
         *           The maximum number of players of the Center position allowed on a single team
         *           
         *      [7]  (int) MaxLW
         *           The maximum number of players of the Left Wing position allowed on a single team
         *           
         *      [8]  (int) MaxRW
         *           The maximum number of players of the Right Wing position allowed on a single team
         *           
         *      [9]  (int) MaxD
         *           The maximum number of players of the Defence position allowed on a single team
         *           
         *      [10] (int) MaxG
         *           The maximum number of players of the Goalie position allowed on a single team
         *           
         *      [11] (String) SportID
         *           A three-letter string indicating the sport (example: nhl)
         *           
         *      [12] (String) TeamName
         *           The name of the team given to the user creating the league 
         *      
         *  .OUTPUT
         *      (int)
         *           0: Successful league registration
         *          -1: League name is empty
         *          -2: League password is empty in a private league
         *          -3: No stats selected
         *          -4: Sport is empty
         *          -5: My Team Name is empty
         *          -6: Unable to establish a connection to the server
         *          -7: League name already exists
         */
        {
            if (LeagueName == "")
            {
                //League name is empty
                return -1;
            }

            if ((!Public) && (LeaguePassword == ""))
            {
                //League password is empty in a private league
                return -2;
            }

            if (StatsList == "")
            {
                //No stats selected
                return -3;
            }

            if (SportID == "")
            {
                //Sport is empty
                return -4;
            }

            if (TeamName == "")
            {
                //My Team Name is empty
                return -5;
            }

            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                //Successful connection attempt
                cnn.Open();
            }
            catch
            {
                //Unable to establish a connection to the server
                return -6;
            }

            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league WHERE league_name = '{0}'", LeagueName), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0)
            {
                //League name already exists
                return -7;
            }
            rdr.Close();

            //Create the set of rules to be used in the league
            cmdSql = new MySqlCommand(String.Format("INSERT INTO rules(max_c, max_lw, max_rw, max_d, max_g, stats_list) VALUES({0}, {1}, {2}, {3}, {4}, '{5}')", MaxC, MaxLW, MaxRW, MaxD, MaxG, StatsList), cnn);
            cmdSql.ExecuteNonQuery();
            cmdSql = new MySqlCommand("SELECT LAST_INSERT_ID()", cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int rulesID = rdr.GetInt32(0);
            rdr.Close();

            //Salt and hash the league password
            string salt = GetRandomHexNumber(32);
            string saltedpassword = HashString(salt + LeaguePassword);
            if (LeaguePassword == "")
            {
                saltedpassword = "";
                salt = "";
            }

            int isPrivate = 1;
            if (Public)
            {
                isPrivate = 0;
            }

            //Create the league
            cmdSql = new MySqlCommand(String.Format("INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_teams, sport_id, private, salt) VALUES('{0}','{1}',{2}, {3}, {4}, '{5}', {6}, '{7}');", LeagueName, saltedpassword, userid, rulesID, MaxTeams, SportID.ToLower(), isPrivate, salt), cnn);
            cmdSql.ExecuteNonQuery();

            //Update the league roster table to reflect the new league
            cmdSql = new MySqlCommand("SELECT LAST_INSERT_ID();", cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int LeagueID = rdr.GetInt32(0);
            rdr.Close();

            cmdSql = new MySqlCommand(String.Format("INSERT INTO league_roster(participant_id, league_id, team_name) VALUES({0},{1},'{2}');", userid, LeagueID, TeamName), cnn);
            cmdSql.ExecuteNonQuery();
            cnn.Close();

            return 0;
        }

        public static int JoinLeague(int userid, int leagueid, String leaguepassword, String teamname)
        /*  
         *  .SYNOPSIS
         *      Joins a participant to a league
         *      
         *  .PARAMETERS
         *      [0] (int) userid
         *          The userID for the user that is trying to join the league
         *          
         *      [1] (int) leagueid
         *          The leagueID that is to be joined by the user
         *          
         *      [2] (String) leaguepassword
         *          The password to join the league (if league is public, password will be blank)
         *          
         *      [3] (String) teamname
         *          The name of the team that is to be added to the league
         *          
         *  .OUTPUT
         *      (int)
         *           0: Successfully joined league
         *          -1: Unable to establish a connection to the server
         *          -2: You have already joined this league
         *          -3: League already contains max number of teams
         *          -4: Incorrect league password
         *          -5: Team name already exists within the league
         */
        {

            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                //Successful connection attempt
                cnn.Open();
            }
            catch
            {
                //Unable to establish a connection to the server
                return -1;
            }

            //Determine if the user already belongs to the league
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0} AND participant_id = {1};", leagueid, userid), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();

            if (rdr.GetInt32(0) > 0)
            {
                //You have already joined this league
                return -2;
            }
            rdr.Close();

            //Determine max number of teams
            cmdSql = new MySqlCommand(String.Format("SELECT max_teams FROM league WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();

            int MaxTeams = rdr.GetInt32(0);
            rdr.Close();

            //Determine current number of teams
            cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();

            int CurrentTeams = rdr.GetInt32(0);
            rdr.Close();

            //Determine if league already contains the max number of teams
            if (CurrentTeams == MaxTeams)
            {
                //League already contains max number of teams
                return -3;
            }

            //Determine if league is public or private
            cmdSql = new MySqlCommand(String.Format("SELECT private FROM league WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();

            int Private = rdr.GetInt32(0);
            Console.WriteLine(Private);
            rdr.Close();

            //Compare password if league is private
            if (Private == 1)
            {
                //Salt the given password
                cmdSql = new MySqlCommand(String.Format("SELECT salt FROM league WHERE league_id = {0};", leagueid), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                String saltedpassword = HashString(rdr.GetString(0) + leaguepassword);
                rdr.Close();

                //Grab salted league password
                cmdSql = new MySqlCommand(String.Format("SELECT league_pass FROM league WHERE league_id = {0};", leagueid), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();

                if (saltedpassword != rdr.GetString(0))
                {
                    //Incorrect league password
                    return -4;
                }
                rdr.Close();
            }

            //Determine if team name already exists
            cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0} AND team_name = '{1}';", leagueid, teamname), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();

            if (rdr.GetInt32(0) > 0)
            {
                //Team name already exists within the league
                return -5;
            }
            rdr.Close();

            //Join the team to the league
            cmdSql = new MySqlCommand(String.Format("INSERT INTO league_roster(participant_id, league_id, team_name) VALUES({0},{1},'{2}');", userid, leagueid, teamname), cnn);
            cmdSql.ExecuteNonQuery();

            cnn.Close();

            return 0;
        }


        public static int AddPlayer(int leaguerosterid, int leagueid, Player player)
        /*  
         *  .SYNOPSIS
         *      Adds a player to a team in a league
         *      
         *  .PARAMETERS
         *      [0] (int) leaguerosterid
         *          The leagueRosterID for the user and their associated league that's adding the player
         *          
         *      [1] (int) leagueid
         *          The leagueID for the league that the player is being added in
         *
         *      [2] (Player) player
         *          The player to be added (of the Player class)
         *          
         *  .OUTPUT
         *      (int)
         *           0: Successfully added player to the team
         *          -1: Unable to establish a connection to the server
         *          -2: You already own that player
         *          -3: Another team already owns that player
         *          -4: Team already has maximum number of spots filled for that position
         */
        {
            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                //Successful connection attempt
                cnn.Open();
            }
            catch
            {
                //Unable to establish a connection to the server
                return -1;
            }

            //Check if you already own that player
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM roster WHERE league_roster_id = {0} AND player_name = '{1}';", leaguerosterid, player.Name), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0)
            {
                //You already own that player
                return -2;
            }
            rdr.Close();

            //Get number of other teams in the league
            cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int[] LeagueTeams = new int[rdr.GetInt32(0)];
            rdr.Close();

            //Get other teams' leaguerosterids
            cmdSql = new MySqlCommand(String.Format("SELECT league_roster_id FROM league_roster WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                LeagueTeams[i++] = rdr.GetInt32(0);
            }
            rdr.Close();

            //Check if other team already owns that player
            foreach (int rosterid in LeagueTeams)
            {
                cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM roster WHERE league_roster_id = {0} AND player_name = '{1}';", rosterid, player.Name), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                if (rdr.GetInt32(0) > 0)
                {
                    //Another team already owns that player
                    return -3;
                }
                rdr.Close();
            }


            //Determine the rules table id
            cmdSql = new MySqlCommand(String.Format("SELECT rules FROM league WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int rulesid = rdr.GetInt32(0);
            rdr.Close();

            //Get the max number of players of this position as per the rules
            cmdSql = new MySqlCommand(String.Format("SELECT max_{0} FROM rules WHERE rules_id = {1};", player.Position.ToLower(), rulesid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int MaxSpots = rdr.GetInt32(0);
            rdr.Close();

            //Get the current number of spots of this position on the team's roster
            cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM roster WHERE league_roster_id = {0} AND position = '{1}';", leaguerosterid, player.Position), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int CurrentSpots = rdr.GetInt32(0);
            rdr.Close();

            //Determine if team already has max amount of spots for that position
            if (MaxSpots == CurrentSpots)
            {
                //Team already has maximum number of spots filled for that position
                return -4;
            }

            //Add player to the team
            cmdSql = new MySqlCommand(String.Format("INSERT INTO roster(league_roster_id, player_name, sport, position, date_acquired) VALUES({0},'{1}','nhl','{2}','{3}');", leaguerosterid, player.Name, player.Position, DateTime.Today.ToString("yyyyMMdd")), cnn);
            cmdSql.ExecuteNonQuery();

            cnn.Close();
            return 0;
        }

        public static String DeterminePlayerOwner(Player player, int leagueid)
        /*  
         *  .SYNOPSIS
         *      Determines which team a player belongs to
         *      
         *  .PARAMETERS
         *      [0] (Player) player
         *          The player of which the ownership is to be determined (of the Player class)
         *          
         *      [1] (int) leagueid
         *          The leagueID for the league that the player is owned in
         *          
         *  .OUTPUT
         *      (String)
         *          Returns the team name of the team that owns the player in the league
         *          Returns null if the player is unowned in the league
         */
        {
            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();

            //Get number of other teams in the league
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0};", leagueid), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int[] LeagueTeams = new int[rdr.GetInt32(0)];
            rdr.Close();

            //Get other teams' leaguerosterids
            cmdSql = new MySqlCommand(String.Format("SELECT league_roster_id FROM league_roster WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                LeagueTeams[i++] = rdr.GetInt32(0);
            }
            rdr.Close();

            int teamid = -1;

            //Check if other team already owns that player
            foreach (int rosterid in LeagueTeams)
            {
                cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM roster WHERE league_roster_id = {0} AND player_name = '{1}';", rosterid, player.Name), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                if (rdr.GetInt32(0) > 0)
                {
                    teamid = rosterid;
                    rdr.Close();
                    break;
                }
                rdr.Close();
            }

            //If unowned, return null
            if (teamid == -1)
                return null;

            cmdSql = new MySqlCommand(String.Format("SELECT team_name FROM league_roster WHERE league_roster_id = {0};", teamid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();

            return rdr.GetString(0);
        }

        public static int UpdatePoints(int leaguerosterid, Player player)
        {
            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();

            //Get the date that the player was added to the roster
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT date_acquired FROM roster WHERE league_roster_id = {0} AND player_name = '{1}';", leaguerosterid, player.Name), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            String DateAcquired = rdr.GetString(0);
            rdr.Close();

            //Get the leagueID
            cmdSql = new MySqlCommand(String.Format("SELECT league_id FROM league_roster WHERE league_roster_id = {0};", leaguerosterid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int leagueid = rdr.GetInt32(0);
            rdr.Close();

            //Get the rulesid for the league
            cmdSql = new MySqlCommand(String.Format("SELECT rules FROM league WHERE league_id = {0};", leagueid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int rulesid = rdr.GetInt32(0);
            rdr.Close();

            //Get the rules for the league
            cmdSql = new MySqlCommand(String.Format("SELECT stats_list FROM rules WHERE rules_id = {0};", rulesid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            String statslist = rdr.GetString(0);
            rdr.Close();

            //Request the player stats from the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format("https://api.mysportsfeeds.com/v1.1/pull/nhl/2017-2018-regular/player_gamelogs.json?player={0}&date=since-{1}", player.Name.Replace(' ','-'), DateAcquired));
            request.Credentials = new NetworkCredential("Tolton15", "sportsApp123");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //Read and interpret the JSON returned from the API request
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            string json = reader.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject(json);

            //Add all stats to points total
            int totalPoints = 0;
            if (obj.playergamelogs.gamelogs != null)
            {
                foreach (var playerentry in obj.playergamelogs.gamelogs)
                {
                    foreach (String stat in statslist.Split(','))
                    {
                        totalPoints += Int32.Parse((playerentry.stats[stat]["#text"]).ToString());
                    }
                }
            }

            //Update the points total for the player
            cmdSql = new MySqlCommand(String.Format("UPDATE roster SET points = {0} WHERE league_roster_id = {1} AND player_name = '{2}';", totalPoints, leaguerosterid, player.Name), cnn);
            cmdSql.ExecuteNonQuery();

            cnn.Close();

            return totalPoints;
        }

        public static int DropPlayer(int leaguerosterid, Player player)
        {
            //Attempt to establish a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();

            //Get current points by player
            //*******UpdatePoints(leaguerosterid, player)*******//
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT points FROM roster WHERE league_roster_id = {0} AND player_name = '{1}';", leaguerosterid, player.Name), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int CurrentPoints = rdr.GetInt32(0);
            rdr.Close();

            //Get banked points by team
            cmdSql = new MySqlCommand(String.Format("SELECT banked_points FROM league_roster WHERE league_roster_id = {0};", leaguerosterid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int BankedPoints = rdr.GetInt32(0);
            rdr.Close();

            //Update the banked points
            int NewBankedPoints = CurrentPoints + BankedPoints;
            cmdSql = new MySqlCommand(String.Format("UPDATE league_roster SET banked_points = {0} WHERE league_roster_id = {1};", NewBankedPoints, leaguerosterid), cnn);
            cmdSql.ExecuteNonQuery();

            //Drop the player
            cmdSql = new MySqlCommand(String.Format("DELETE FROM roster WHERE league_roster_id = {0} AND player_name = '{1}';", leaguerosterid, player.Name), cnn);
            cmdSql.ExecuteNonQuery();

            return 0;
        }
    }
}
