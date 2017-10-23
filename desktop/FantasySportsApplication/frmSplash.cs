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

        private string saltedPassword;

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
            
            //Establish a connection to the database
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            try
            {
                //Get the password salt
                cnn.Open();
                MySqlCommand cmdGetSalt = new MySqlCommand(String.Format("SELECT salt FROM participants WHERE username='{0}';", txtUsername.Text), cnn);
                MySqlDataReader rdr = cmdGetSalt.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["salt"] != null)
                    {
                        saltedPassword = (sha256_hash(rdr["salt"] + txtPassword.Text));
                    }
                }
                rdr.Close();
                cnn.Close();


                //Attempt to login
                cnn.Open();
                MySqlCommand cmdLogin = new MySqlCommand(String.Format("SELECT participant_id FROM participants WHERE username='{0}' AND password='{1}';", txtUsername.Text, saltedPassword), cnn);
                rdr = cmdLogin.ExecuteReader();
                bool loginSuccess = false;
                while (rdr.Read())
                {
                    if (rdr["participant_id"] != null)
                    {
                        //Successful Login
                        loginSuccess = true;
                        CurrentUser = txtUsername.Text;
                        CurrentID = (int)rdr["participant_id"];
                        lblWelcome.Text = "Welcome,  " + CurrentUser;
                    }
                }
                if (!loginSuccess)
                {
                    //Failed Login
                    lblLoginFail.ForeColor = Color.FromArgb(0, 0, 0);
                    tmrLoginFail.Start();
                }
                else
                {
                    rdr.Close();
                    MySqlCommand cmdLeagues = new MySqlCommand(String.Format("SELECT league_id FROM league_roster WHERE participant_id={0};", CurrentID), cnn);
                    rdr = cmdLeagues.ExecuteReader();
                    while (rdr.Read())
                    {
                        btnLogout.Text = rdr[0].ToString();
                    }
                    tbctrlLogin.SelectedTab = tbpgSignedIn;
                }
               
                rdr.Close();
                cnn.Close();
            }
            //Problem connecting to the database
            catch
            {
                MessageBox.Show("Cannot connect to the login server at this time. Please try again later.","Connection Error");
            }
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
    }
}
