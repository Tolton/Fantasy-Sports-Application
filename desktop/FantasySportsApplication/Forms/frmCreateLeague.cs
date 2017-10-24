using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasySportsApplication
{
    public partial class frmCreateLeague : Form
    {
        public string CurrentUser { get; set; }
        public int CurrentID { get; set; }

        public frmCreateLeague()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateLeague(CurrentID, txtLeagueName.Text, txtLeaguePassword.Text, "default", (int)numMaxPlayers.Value, cmboSport.Text, txtTeamName.Text);
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

        private bool CreateLeague (int userID, string leagueName, string leaguePassword, string rulesList, int maxPlayers, string sportID, string teamName)
        {
            int leagueId;

            //Reset the error label
            lblError.ForeColor = Color.Black;

            //Throw error if any of the fields are blank
            if (txtLeagueName.Text == "") //blank league name
            {
                lblError.Text = "ERROR: 'League Name' cannot be empty.";
                tmrError.Start();
                return false;
            }
            else if (txtLeaguePassword.Text == "") //blank league password
            {
                lblError.Text = "ERROR: 'League Password' cannot be empty.";
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

                //Insert the league information
                MySqlCommand cmdSql = new MySqlCommand(String.Format("INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_players, sport_id) VALUES('{0}','{1}',{2},'default',{3},'{4}');", leagueName, leaguePassword, userID, maxPlayers, sportID.ToLower()), cnn);
                try
                {
                    cmdSql.ExecuteNonQuery();
                }
                catch
                {
                    lblError.Text = "ERROR: The League Name '" + leagueName + "' already exists.";
                    tmrError.Start();
                    return false;
                }
                
                //Grab the new league ID
                cmdSql = new MySqlCommand("SELECT LAST_INSERT_ID();", cnn);
                MySqlDataReader rdr = cmdSql.ExecuteReader();
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
    }
}
