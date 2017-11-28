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
        public frmRegister()
        {
            InitializeComponent();
        }

        private void RegisterError(String message, Boolean success)
        {
            lblError.ForeColor = Color.Black;
            lblError.Text = message;
            if (success)
            {
                tmrSuccess.Start();
            }
            else
            {
                tmrError.Start();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            switch (Backend.Register(txtUsername.Text, txtPassword.Text, txtPasswordConfirm.Text))
            {
                case 0:
                    RegisterError("Success!", true);
                    break;

                case -1:
                    RegisterError("ERROR: Passwords do not match.", false);
                    break;

                case -2:
                    RegisterError("ERROR: Unable to establish a connection to the server.", false);
                    break;

                case -3:
                    RegisterError("ERROR: Username already exists.", false);
                    break;
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
