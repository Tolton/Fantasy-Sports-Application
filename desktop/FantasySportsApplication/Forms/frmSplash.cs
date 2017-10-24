using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;

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
            if (Login(txtUsername.Text, txtPassword.Text))
                PullLeagues(txtUsername.Text);

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
            //Join League
        }

        private bool Login (string username, string password)
        {
            string saltedPassword = null;
            MySqlCommand cmdSql;
            MySqlDataReader rdr;

            //Attempt to connect to the login server
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Cannot connect to the login server at this time. Please try again later.", "Connection Error");
            }
            
            //Grab the salt from the database
            cmdSql = new MySqlCommand(String.Format("SELECT salt FROM participants WHERE username='{0}';", txtUsername.Text), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            try //Username exists
            {
                //Salt the password
                saltedPassword = (sha256_hash(rdr["salt"] + txtPassword.Text));
            }
            catch //Username does not exist
            {
                lblLoginFail.ForeColor = Color.Black;
                tmrLoginFail.Start();
                return false;
            }
            rdr.Close();

            //Attempt to login
            cmdSql = new MySqlCommand(String.Format("SELECT participant_id FROM participants WHERE username='{0}' AND password='{1}';", txtUsername.Text, saltedPassword), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            //Successful Login
            try
            {
                CurrentUser = txtUsername.Text;
                CurrentID = (int)rdr["participant_id"];
                lblWelcome.Text = "Welcome,  " + CurrentUser;
            }
            //Failed Login
            catch
            {
                lblLoginFail.ForeColor = Color.Black;
                tmrLoginFail.Start();
                return false;
            }
            rdr.Close();
            cnn.Close();
            return true;
        }

        private void PullLeagues (string username)
        {
            //Clear combobox of League Names
            cmboLeague.Items.Clear();

            //Open connection to pull list of League IDs
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT league_id FROM league_roster WHERE participant_id={0};", CurrentID), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();

            //Open connection to pull list of League Names
            MySqlConnection cnn2 = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn2.Open();
            MySqlCommand cmdSql2;
            MySqlDataReader rdr2;

            //Show the No Leagues error
            tbctrlChooseLeague.SelectedTab = tbpgNoLeagues;

            //For each League ID, add the League Name to the combobox
            while (rdr.Read())
            {
                //Show league selection combobox
                tbctrlChooseLeague.SelectedTab = tbpgChooseLeague;
                cmdSql2 = new MySqlCommand(String.Format("SELECT league_name FROM league WHERE league_id={0};", (int)rdr[0]), cnn2);
                rdr2 = cmdSql2.ExecuteReader();
                rdr2.Read();
                cmboLeague.Items.Add(rdr2[0].ToString());
                rdr2.Close();
            }

            //Switch to signed in mode
            tbctrlLogin.SelectedTab = tbpgSignedIn;
        }

    }
}
