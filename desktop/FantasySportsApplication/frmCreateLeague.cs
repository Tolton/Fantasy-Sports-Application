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
            lblError.ForeColor = Color.Black;
            if (txtLeagueName.Text == "")
            {
                lblError.Text = "ERROR: 'League Name' cannot be empty.";
                tmrError.Start();
            }
            else if (txtLeaguePassword.Text == "")
            {
                lblError.Text = "ERROR: 'League Password' cannot be empty.";
                tmrError.Start();
            }
            else if (cmboSport.SelectedIndex == -1)
            {
                lblError.Text = "ERROR: 'Sport' cannot be empty.";
                tmrError.Start();
            }
            else if (txtTeamName.Text == "")
            {
                lblError.Text = "ERROR: 'My Team Name' cannot be empty.";
                tmrError.Start();
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
                try
                {
                    cnn.Open();
                    MySqlCommand cmdCreateLeague = new MySqlCommand(String.Format("INSERT INTO league(league_name, league_pass, commissioner_id, rules, max_players, sport_id) VALUES('{0}', '{1}', {2}, 'default', {3}, '{4}');", txtLeagueName.Text, txtLeaguePassword.Text, CurrentID, numMaxPlayers.Value, cmboSport.Text.ToLower() ), cnn);
                    cmdCreateLeague.ExecuteNonQuery();
                    MySqlCommand cmdSelectLeagueID = new MySqlCommand("SELECT LAST_INSERT_ID();");
                    MySqlDataReader rdr = cmdSelectLeagueID.ExecuteReader();
                    while (rdr.Read())
                    {
                        
                    }
                }
                //Problem connecting to the database
                catch
                {
                    lblError.Text = "ERROR: The League Name '" + txtLeagueName.Text + "' is already taken.";
                    tmrError.Start();
                }
            }
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
    }
}
