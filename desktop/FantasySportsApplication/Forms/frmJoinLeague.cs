using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FantasySportsApplication.Forms
{
    public partial class frmJoinLeague : Form
    {
        public string CurrentUser { get; set; }
        public int CurrentID { get; set; }

        public frmJoinLeague()
        {
            InitializeComponent();
        }

        private bool JoinLeague(int userId, string leagueName, string leaguePassword, string teamName)
        {
            int leagueID;
            
            //Ensure that all text fields have a value
            if (leagueName == "")
            {
                lblError.ForeColor = Color.Black;
                lblError.Text = "ERROR: 'League Name' cannot be blank.";
                tmrFailure.Start();
                return false;
            }
            else if (leaguePassword == "")
            {
                lblError.ForeColor = Color.Black;
                lblError.Text = "ERROR: 'League Password' cannot be blank.";
                tmrFailure.Start();
                return false;
            }
            else if(teamName == "")
            {
                lblError.ForeColor = Color.Black;
                lblError.Text = "ERROR: 'Team Name' cannot be blank.";
                tmrFailure.Start();
                return false;
            }

            //Open a connection to the server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT league_id FROM league WHERE league_name='{0}' AND league_pass='{1}'", leagueName, leaguePassword), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            lblError.ForeColor = Color.White;
            //Pull the leagueID
            try
            {
                leagueID = (int)rdr[0];
            }
            //Catch if incorrect league name / password
            catch
            {
                lblError.ForeColor = Color.Black;
                lblError.Text = "ERROR: Incorrect league name / password";
                tmrFailure.Start();
                rdr.Close();
                return false;
            }
            rdr.Close();

            //Check if you already exist within that league
            cmdSql = new MySqlCommand(String.Format("SELECT team_name FROM league_roster WHERE participant_id={0} AND league_id={1}", CurrentID, leagueID), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            try
            {
                //Already in league
                lblError.ForeColor = Color.Black;
                lblError.Text = rdr[0].ToString();
                lblError.Text = "ERROR: You already belong to this league!";
                tmrFailure.Start();
                rdr.Close();
                return false;
            }
            catch
            {
                //Insert your team into the league roster
                rdr.Close();
                cmdSql = new MySqlCommand(String.Format("INSERT INTO league_roster(participant_id, league_id, team_name) VALUES({0},{1},'{2}')", CurrentID, leagueID, teamName), cnn);
                cmdSql.ExecuteNonQuery();
            }
            cnn.Close();

            //Show success label
            lblError.ForeColor = Color.Black;
            lblError.Text = "Success";
            tmrSuccess.Start();

            return true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinLeague(CurrentID, txtLeagueName.Text, txtLeaguePassword.Text, txtTeamName.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrFailure_Tick(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.FromArgb(lblError.ForeColor.R + 15, 0, 0);
            if (lblError.ForeColor.R == 255)
                tmrFailure.Stop();
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
