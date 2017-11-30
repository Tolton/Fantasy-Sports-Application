using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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

        private bool PopulateTeams()
        {
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand("SELECT league_id, league_name, max_teams, private FROM league;", cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();

            int LeagueID;
            String LeagueName;
            int MaxPlayers;
            int Private;
            int CurrentPlayers;

            while (rdr.Read())
            {
                LeagueID = rdr.GetInt32(0);
                LeagueName = rdr.GetString(1);
                MaxPlayers = rdr.GetInt32(2);
                Private = rdr.GetInt32(3);
                dgvLeagues.Rows.Add("", LeagueName, Private, MaxPlayers, "", "Join Now", LeagueID);
            }
            rdr.Close();

            foreach (DataGridViewRow row in dgvLeagues.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen;
                cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0};", row.Cells[6].Value.ToString()), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                CurrentPlayers = rdr.GetInt32(0);
                if (CurrentPlayers.ToString() == row.Cells[3].Value.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                row.Cells[3].Value = CurrentPlayers.ToString() + " / " + row.Cells[3].Value.ToString();
                rdr.Close();

                cmdSql = new MySqlCommand(String.Format("SELECT COUNT(*) FROM league_roster WHERE league_id = {0} AND participant_id = {1};", row.Cells[6].Value.ToString(), CurrentID), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                if (rdr.GetInt32(0) > 0)
                {
                    row.Cells[4].Value = "Already Joined";
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    row.Cells[4].Value = "Not Yet Joined";
                }
                rdr.Close();


                switch (row.Cells[2].Value.ToString())
                {
                    case "0":
                        row.Cells[0].Value = "";
                        row.Cells[2].Value = "Public";
                        break;

                    case "1":
                        row.Cells[0].Value = "🔒";
                        row.Cells[2].Value = "Private";
                        break;
                }
            }

            cnn.Close();

            return true;
        }

        private void JoinError(String message, Boolean success)
        {
            lblError.ForeColor = Color.Black;
            lblError.Text = message;

            if (success)
            {
                tmrSuccess.Start();
            }
            else
            {
                tmrFailure.Start();
            }
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

        private void frmJoinLeague_Load(object sender, EventArgs e)
        {
            PopulateTeams();
            txtTeamName.Text = CurrentUser + "s Team";
        }

        private void dgvLeagues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (txtTeamName.Text == "")
                {
                    JoinError("ERROR: Team name cannot be blank", false);
                    return;
                }
                if (!Regex.IsMatch(txtTeamName.Text, "^[a-zA-Z0-9 ]*$"))
                {
                    JoinError("ERROR: My Team Name must be alpha-numeric (spaces allowed)", false);
                    return;
                }
                String password = "";
                if (dgvLeagues.Rows[e.RowIndex].Cells[2].Value.ToString() == "Private")
                {
                    password = Microsoft.VisualBasic.Interaction.InputBox("League Password Required", "Please enter the password for the league:", "", 0, 0);
                    if (password == "")
                    {
                        JoinError("ERROR: No password was entered", false);
                        return;
                    }
                }
                switch (Backend.JoinLeague(CurrentID, Convert.ToInt32(dgvLeagues.Rows[e.RowIndex].Cells[6].Value.ToString()), password, txtTeamName.Text))
                {
                    case 0:
                        JoinError("Success!", true);
                        break;

                    case -1:
                        JoinError("ERROR: Unable to establish a connection to the server.", false);
                        break;

                    case -2:
                        JoinError("ERROR: You have already joined this league.", false);
                        break;

                    case -3:
                        JoinError("ERROR: League already contains max number of teams.", false);
                        break;

                    case -4:
                        JoinError("ERROR: Incorrect league password.", false);
                        break;

                    case -5:
                        JoinError("ERROR: Team name already exists within the league.", false);
                        break;
                }
            }
        }

        private void dgvLeagues_SelectionChanged(object sender, EventArgs e)
        {
            dgvLeagues.ClearSelection();
        }
    }
}
