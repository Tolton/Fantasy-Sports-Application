using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasySportsApplication
{
    public partial class frmCreateLeague : Form
    {
        public string CurrentUser { get; set; }
        public int CurrentID { get; set; }

        private string saltedPassword;
        private string salt;
        static Random random = new Random();

        public frmCreateLeague()
        {
            InitializeComponent();
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        private string getStatsList()
        {
            string Stats = "";

            foreach (object itemChecked in chklstPlayerStats.CheckedItems)
            {
                if (Stats == "")
                {
                    Stats += itemChecked.ToString();
                }
                else
                {
                    Stats += ("," + itemChecked.ToString());
                }
            }
            foreach (object itemChecked in chklstGoalieStats.CheckedItems)
            {
                if (Stats == "")
                {
                    Stats += itemChecked.ToString();
                }
                else
                {
                    Stats += ("," + itemChecked.ToString());
                }
            }

            return Stats;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (rdPrivate.Checked)
            {
                salt = GetRandomHexNumber(32);
                saltedPassword = sha256_hash(salt + txtLeaguePassword.Text);
            }
            else
            {
                salt = "";
                saltedPassword = "";
            }
            CreateLeague(CurrentID, txtLeagueName.Text, saltedPassword, getStatsList(), (int)numMaxPlayers.Value, cmboSport.Text, txtTeamName.Text, salt);
        }

        private void frmCreateLeague_Load(object sender, EventArgs e)
        {
            txtTeamName.Text = CurrentUser + "s Team";
        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.FromArgb(lblError.ForeColor.R + 15, 0, 0);
            if (lblError.ForeColor.R == 255)
                tmrError.Stop();
        }

        private bool CreateLeague (int userID, string leagueName, string leaguePassword, string statsList, int maxPlayers, string sportID, string teamName, string salt)
        {
            int leagueId;

            //Reset the error label
            lblError.ForeColor = Color.Black;

            //Throw error if any of the fields are blank
            if (statsList == "")
            {
                lblError.Text = "ERROR: Please select at least 1 scoring category.";
                tmrError.Start();
                return false;
            }
            else if (txtLeagueName.Text == "") //blank league name
            {
                lblError.Text = "ERROR: 'League Name' cannot be empty.";
                tmrError.Start();
                return false;
            }
            else if ((txtLeaguePassword.Text == "") && (rdPrivate.Checked)) //blank league password
            {
                lblError.Text = "ERROR: 'League Password' cannot be empty if Availability is set to Private.";
                tmrError.Start();
                return false;
            }
            else if (cmboSport.SelectedIndex == -1) //blank sport
            {
                lblError.Text = "ERROR: 'Sport' cannot be empty.";
                tmrError.Start();
                return false;
            }
            else if (txtTeamName.Text == "") //blank team name
            {
                lblError.Text = "ERROR: 'My Team Name' cannot be empty.";
                tmrError.Start();
                return false;
            }
            else
            {
                //Open connection to the database
                MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
                cnn.Open();

                MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT COUNT(league_name) FROM league WHERE league_name = '{0}'", leagueName), cnn);
                MySqlDataReader rdr = cmdSql.ExecuteReader();

                rdr.Read();
                if (Convert.ToInt32(rdr[0].ToString()) > 0)
                {
                    lblError.Text = "ERROR: The League Name '" + leagueName + "' already exists.";
                    tmrError.Start();
                    return false;
                }
                rdr.Close();

                cmdSql = new MySqlCommand(String.Format("INSERT INTO rules(max_teams, max_c, max_lw, max_rw, max_d, max_g, stats_list) VALUES({0}, {1}, {2}, {3}, {4}, {5}, '{6}')", numMaxPlayers.Value, numC.Value, numLW.Value, numRW.Value, numD.Value, numG.Value, statsList), cnn);
                cmdSql.ExecuteNonQuery();

                cmdSql = new MySqlCommand("SELECT LAST_INSERT_ID()", cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                int rulesID = Convert.ToInt32(rdr[0].ToString());
                int isPrivate;

                rdr.Close();

                if (rdPrivate.Checked)
                {
                    isPrivate = 1;
                }
                else
                {
                    isPrivate = 0;
                }

                //Insert the league information
                cmdSql = new MySqlCommand(String.Format("INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_players, sport_id, private, salt) VALUES('{0}','{1}',{2}, {3}, {4}, '{5}', {6}, '{7}');", leagueName, leaguePassword, userID, rulesID, maxPlayers, sportID.ToLower(), isPrivate, salt), cnn);
                try
                {
                    cmdSql.ExecuteNonQuery();
                }
                catch
                {
                    lblError.Text = "ERROR: Not added to league for unknown reason.";
                    tmrError.Start();
                    return false;
                }
                
                //Grab the new league ID
                cmdSql = new MySqlCommand("SELECT LAST_INSERT_ID();", cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                leagueId = Convert.ToInt32(rdr[0].ToString());
                rdr.Close();

                //Update the league roster table
                cmdSql = new MySqlCommand(String.Format("INSERT INTO league_roster(participant_id, league_id, team_name) VALUES({0},{1},'{2}');", CurrentID, leagueId, teamName), cnn);
                cmdSql.ExecuteNonQuery();
                cnn.Close();

                //Show the success label
                lblError.Text = "Success";
                tmrSuccess.Start();

                return true;
            }
        }

        private void tmrSuccess_Tick(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.FromArgb(0, lblError.ForeColor.G + 15, 0);
            if (lblError.ForeColor.G == 255)
            {
                tmrSuccess.Stop();
                this.Close();
            }
        }

        private void rdPrivate_CheckedChanged(object sender, EventArgs e)
        {
            txtLeaguePassword.Enabled = rdPrivate.Checked;
            if (!rdPrivate.Checked)
            {
                txtLeaguePassword.Text = "";
            }
        }
    }
}
