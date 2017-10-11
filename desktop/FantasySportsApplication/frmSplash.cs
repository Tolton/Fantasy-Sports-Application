using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FantasySportsApplication
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
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
                cnn.Open();
                MySqlCommand cmdLogin = new MySqlCommand(String.Format("SELECT participant_id FROM participants WHERE username='{0}' AND password='{1}'",txtUsername.Text, txtPassword.Text), cnn);
                MySqlDataReader rdr = cmdLogin.ExecuteReader();
                bool loginSuccess = false;
                while (rdr.Read())
                {
                    if (rdr["participant_id"] != null)
                    {
                        //Successful Login
                        loginSuccess = true;
                        lblWelcome.Text = "Welcome,  " + txtUsername.Text ; //ADD USERNAME

                        pnlWelcome.Visible = true;
                        pnlLogin.Visible = false;
                    }
                }
                if (!loginSuccess)
                {
                    //Failed Login
                    lblLoginFail.ForeColor = Color.FromArgb(0, 0, 0);
                    tmrLoginFail.Start();
                }
               
                rdr.Close();
                cnn.Close();
            }
            //Problem connecting to the database
            catch (Exception ex)
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
            //REMOVE USERNAME
            pnlLogin.Visible = true;
            pnlWelcome.Visible = false;
        }
    }
}
