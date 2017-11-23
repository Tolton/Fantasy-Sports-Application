using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FantasySportsApplication.Forms
{
    public partial class frmJoinLeague : Form
    {
        public string CurrentUser { get; set; }
        public int CurrentID { get; set; }

        private string saltedPassword;
        private string salt;
        static Random random = new Random();

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

        public frmJoinLeague()
        {
            InitializeComponent();
        }

        private bool PopulateTeams()
        {
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            MySqlConnection cnn2 = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            cnn2.Open();
            MySqlCommand cmdSql = new MySqlCommand("SELECT league_name FROM league;", cnn);
            MySqlCommand cmdSql2;
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            MySqlDataReader rdr2;
            while (rdr.Read())
            {
                cmdSql2 = new MySqlCommand(String.Format("SELECT private FROM league WHERE league_name = '{0}';",rdr[0].ToString()), cnn2);
                rdr2 = cmdSql2.ExecuteReader();
                rdr2.Read();
                if (Convert.ToInt32(rdr2[0].ToString()) == 1)
                {
                    //PRIVATE
                    dataGridView1.Rows.Add("🔒", rdr[0].ToString(), "Private", "Enter Password");
                }
                else
                {
                    //PUBLIC
                    dataGridView1.Rows.Add("", rdr[0].ToString(), "Public", "Join");
                }
                rdr2.Close();
            }
            rdr.Close();
            cnn.Close();

            return true;
        }

        private bool JoinLeague(int userId, string leagueName, string leaguePassword, string teamName, bool privateLeague)
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
            else if ((leaguePassword == "") && (privateLeague))
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

            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT salt FROM league WHERE league_name='{0}'", leagueName), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();

            rdr.Read();
            salt = rdr[0].ToString();
            rdr.Close();

            leaguePassword = sha256_hash(salt + leaguePassword);

            cmdSql = new MySqlCommand(String.Format("SELECT league_id FROM league WHERE league_name='{0}' AND league_pass='{1}'", leagueName, leaguePassword), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            //Pull the leagueID
            try
            {
                leagueID = (int)rdr[0];
            }
            //Catch if incorrect league name / password
            catch
            {
                lblError.ForeColor = Color.Black;
                lblError.Text = "ERROR: Incorrect league name / password.";
                tmrFailure.Start();
                rdr.Close();
                return false;
            }
            rdr.Close();

            //Check if team name already exists in the league
            cmdSql = new MySqlCommand(String.Format("SELECT participant_id FROM league_roster WHERE league_id={0} AND team_name='{1}'", leagueID, teamName), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            try
            {
                Console.WriteLine((int)rdr[0]);
                lblError.ForeColor = Color.Black;
                lblError.Text = "ERROR: Team already exists within the league.";
                tmrFailure.Start();
                rdr.Close();
                return false;
            }
            catch
            {
                rdr.Close();
            }


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

        private void frmJoinLeague_Load(object sender, EventArgs e)
        {
            PopulateTeams();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Private")
                {
                    string pass = Microsoft.VisualBasic.Interaction.InputBox(String.Format("Please enter the password for the league '{0}'", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()), "Enter League Password", "", -1, -1);
                    JoinLeague(CurrentID, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), pass, String.Format("{0}s Team", CurrentUser), true);
                }
                else
                {
                    JoinLeague(CurrentID, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "", String.Format("{0}s Team", CurrentUser), false);
                }
            }
        }
    }
}
