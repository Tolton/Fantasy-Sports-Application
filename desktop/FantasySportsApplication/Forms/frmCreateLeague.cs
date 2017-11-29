using System;
using System.Drawing;
using System.Windows.Forms;

namespace FantasySportsApplication
{
    public partial class frmCreateLeague : Form
    {
        public string CurrentUser { get; set; }
        public int CurrentID { get; set; }

        public frmCreateLeague()
        {
            InitializeComponent();
        }

        private void CreateError(String message, Boolean success)
        {
            lblError.ForeColor = Color.Black;
            lblError.Text = message;
            if (success)
                tmrSuccess.Start();
            else
                tmrError.Start();
        }

        //Convert checked off stats into a comma-delimited list
        private string getStatsList()
        {
            string Stats = "";

            foreach (object itemChecked in chklstPlayerStats.CheckedItems)
            {
                if (Stats == "")
                {
                    Stats += itemChecked.ToString();
                }
                else
                {
                    Stats += ("," + itemChecked.ToString());
                }
            }
            foreach (object itemChecked in chklstGoalieStats.CheckedItems)
            {
                if (Stats == "")
                {
                    Stats += itemChecked.ToString();
                }
                else
                {
                    Stats += ("," + itemChecked.ToString());
                }
            }

            return Stats;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (Backend.CreateLeague(CurrentID, txtLeagueName.Text, rdPublic.Checked, txtLeaguePassword.Text, getStatsList(), (int)numMaxPlayers.Value, (int)numC.Value, (int)numLW.Value, (int)numRW.Value, (int)numD.Value, (int)numG.Value, cmboSport.Text, txtTeamName.Text))
            {
                //Successful league registration
                case 0:
                    CreateError("Success!", true);
                    break;

                //League name is empty
                case -1:
                    CreateError("ERROR: League Name cannot be empty.", false);
                    break;

                //League password is empty in a private league
                case -2:
                    CreateError("ERROR: League Password cannot be empty in a private league.", false);
                    break;

                //No stats selected
                case -3:
                    CreateError("ERROR: No scoring categories selected", false);
                    break;

                //Sport is empty
                case -4:
                    CreateError("ERROR: No sport selected.", false);
                    break;

                //My Team Name is empty
                case -5:
                    CreateError("ERROR: My Team Name cannot be empty.", false);
                    break;

                //Unable to establish a connection to the server
                case -6:
                    CreateError("ERROR: Unable to establish a connection to the server.", false);
                    break;

                //League name already exists
                case -7:
                    CreateError("ERROR: League name already exists.", false);
                    break;
            }
        }

        private void frmCreateLeague_Load(object sender, EventArgs e)
        {
            txtTeamName.Text = CurrentUser + "s Team";
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

        private void rdPrivate_CheckedChanged(object sender, EventArgs e)
        {
            txtLeaguePassword.Enabled = rdPrivate.Checked;
            if (!rdPrivate.Checked)
            {
                txtLeaguePassword.Text = "";
            }
        }
    }
}
