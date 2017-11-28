using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FantasySportsApplication.Forms;

namespace FantasySportsApplication
{
    public partial class frmSplash : Form
    {
        public string CurrentUser = null;
        public int CurrentID = 0;

        public frmSplash()
        {
            InitializeComponent();
        }
        private void LoginError (String message)
        {
            lblLoginFail.ForeColor = Color.Black;
            lblLoginFail.Text = message;
            tmrLoginFail.Start();
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.exit_hover;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.exit_normal;
        }

        private void picExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        //Login Button clicked
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int LoginResult = Backend.Login(txtUsername.Text, txtPassword.Text);
            switch (LoginResult)
            {
                //Unable to establish a connection to the backend
                case -1:
                    MessageBox.Show("Cannot connect to the login server at this time. Please try again later.", "Connection Error");
                    break;

                //Username does not exist in the database
                case -2:
                    LoginError("ERROR: Username does not exist.");
                    break;

                //Password does not match the one stored in the database
                case -3:
                    LoginError("ERROR: Invalid password entered.");
                    break;

                //Successful login; returns the participantID from the participants table
                default:
                    CurrentID = LoginResult;
                    CurrentUser = txtUsername.Text;
                    lblWelcome.Text = "Welcome, " + CurrentUser;
                    cmboLeague.Items.Clear();
                    String[] Leagues = Backend.PullLeagues(CurrentID);
                    if (Leagues == null)
                    {
                        //When user has not yet joined a league
                        tbctrlChooseLeague.SelectedTab = tbpgNoLeagues;
                    }
                    else
                    {
                        //When user has joined one or more leagues
                        tbctrlChooseLeague.SelectedTab = tbpgChooseLeague;
                        foreach (String LeagueName in Leagues)
                        {
                            cmboLeague.Items.Add(LeagueName);
                        }
                    }
                    tbctrlLogin.SelectedTab = tbpgSignedIn;
                    lblLoginFail.ForeColor = Color.Black;
                    break;
            }

            //PullLeagues(txtUsername.Text);

            txtPassword.Text = null;
            txtPassword.Focus();
        }

        //Stylize the login error label (fade in)
        private void tmrLoginFail_Tick(object sender, EventArgs e)
        {
            lblLoginFail.ForeColor = Color.FromArgb(lblLoginFail.ForeColor.R + 15, 0, 0);
            if (lblLoginFail.ForeColor.R == 255)
                tmrLoginFail.Stop();            
        }

        //Log Out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            tbctrlLogin.SelectedTab = tbpgSignedOut;
            CurrentUser = null;
            CurrentID = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerform = new frmRegister();
            registerform.Show();
        }

        private void picCreate_MouseEnter(object sender, EventArgs e)
        {
            picCreate.Image = Properties.Resources.create_hover;
        }

        private void picCreate_MouseLeave(object sender, EventArgs e)
        {
            picCreate.Image = Properties.Resources.create;
        }

        private void picJoin_MouseEnter(object sender, EventArgs e)
        {
            picJoin.Image = Properties.Resources.join_hover;
        }

        private void picJoin_MouseLeave(object sender, EventArgs e)
        {
            picJoin.Image = Properties.Resources.join;
        }

        private void picCreate_Click(object sender, EventArgs e)
        {
            frmCreateLeague formCreateLeague = new frmCreateLeague();
            formCreateLeague.CurrentUser = CurrentUser;
            formCreateLeague.CurrentID = CurrentID;
            formCreateLeague.Show();
        }

        private void picJoin_Click(object sender, EventArgs e)
        {
            frmJoinLeague formJoinLeague = new frmJoinLeague();
            formJoinLeague.CurrentUser = CurrentUser;
            formJoinLeague.CurrentID = CurrentID;
            formJoinLeague.Show();
        }

        private void btnEnterLeague_Click(object sender, EventArgs e)
        {
            int leagueID;

            if (cmboLeague.SelectedIndex != -1)
            {
                MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
                cnn.Open();
                MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT league_id FROM league WHERE league_name='{0}';", cmboLeague.Text), cnn);
                MySqlDataReader rdr = cmdSql.ExecuteReader();

                rdr.Read();
                frmMain formMain = new frmMain();
                formMain.LeagueName = cmboLeague.Text;
                leagueID = Convert.ToInt32(rdr[0].ToString());
                formMain.LeagueID = leagueID;
                rdr.Close();

                cmdSql = new MySqlCommand(String.Format("SELECT team_name FROM league_roster WHERE league_id={0} AND participant_id={1};", leagueID, CurrentID), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                formMain.TeamName = rdr[0].ToString();
                rdr.Close();

                cmdSql = new MySqlCommand(String.Format("SELECT league_roster_id FROM league_roster WHERE participant_id={0} AND league_id={1};", CurrentID, leagueID), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                formMain.LeagueRosterID = Convert.ToInt32(rdr[0].ToString());
                rdr.Close();

                cmdSql = new MySqlCommand(String.Format("SELECT sport_id FROM league WHERE league_id={0};", leagueID), cnn);
                rdr = cmdSql.ExecuteReader();
                rdr.Read();
                formMain.Sport = rdr[0].ToString();
                rdr.Close();

                formMain.CurrentID = CurrentID;
                formMain.CurrentUser = CurrentUser;
                formMain.Show();
                this.Hide();
            }
        }
    }
}
