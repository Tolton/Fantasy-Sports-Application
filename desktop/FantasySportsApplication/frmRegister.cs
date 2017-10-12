using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FantasySportsApplication
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.FromArgb(0, 0, 0);
            if (String.Compare(txtPassword.Text, txtPasswordConfirm.Text) != 0)
            {
                lblError.Text = "ERROR: Passwords do not match.";
                tmrError.Start();
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
                try
                {
                    cnn.Open();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show("Cannot connect to the registration server at this time. Please try again later.", "Connection Error");
                }
                try
                {
                    MySqlCommand cmdRegister = new MySqlCommand(String.Format("INSERT INTO participants(username,password) VALUES('{0}','{1}')", txtUsername.Text, txtPassword.Text), cnn);
                    cmdRegister.ExecuteNonQuery();
                    lblError.Text = "Success";
                    tmrSuccess.Start();
                }
                catch
                {
                    lblError.Text = "ERROR: Username already exists.";
                    tmrError.Start();
                }
                cnn.Close();
            }
        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.FromArgb(lblError.ForeColor.R + 15, 0, 0);
            if (lblError.ForeColor.R == 255)
                tmrError.Stop();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
