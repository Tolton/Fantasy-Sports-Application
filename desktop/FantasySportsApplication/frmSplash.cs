using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            picExit.Image = FantasySportsApplication.Properties.Resources.exit_hover;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = FantasySportsApplication.Properties.Resources.exit_normal;
        }

        private void picExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123");
            try
            {
                cnn.Open();
                Console.WriteLine("Success");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
