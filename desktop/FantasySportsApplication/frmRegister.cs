using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace FantasySportsApplication
{
    public partial class frmRegister : Form
    {
        private string saltedPassword;
        private string salt;
        static Random random = new Random();

        public frmRegister()
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

        public static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
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
                    salt = GetRandomHexNumber(32);
                    saltedPassword = sha256_hash(salt + txtPassword.Text);
                    MySqlCommand cmdRegister = new MySqlCommand(String.Format("INSERT INTO participants(username,password,salt) VALUES('{0}','{1}','{2}');", txtUsername.Text, saltedPassword, salt), cnn);
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
