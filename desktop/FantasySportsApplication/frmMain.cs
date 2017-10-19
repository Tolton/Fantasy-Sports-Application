using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FantasySportsApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash splashForm = new frmSplash();
            splashForm.Show();
        }

        private void lblMyTeam_MouseEnter(object sender, EventArgs e)
        {
            lblMyTeam.ForeColor = Color.LightBlue;
        }

        private void lblMyTeam_MouseLeave(object sender, EventArgs e)
        {
            lblMyTeam.ForeColor = Color.White;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.mysportsfeeds.com/v1.1/pull/nhl/2016-2017/cumulative_player_stats.json");
            request.Credentials = new NetworkCredential("Tolton15", "sportsApp123");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            string json = reader.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject(json);
            foreach (var playerentry in obj.cumulativeplayerstats.playerstatsentry)
            {
                dgvPlayers.Rows.Add(playerentry.player.Position, playerentry.player.FirstName + " " + playerentry.player.LastName, playerentry.stats.stats.Goals["#text"], playerentry.stats.stats.Assists["#text"], playerentry.stats.stats.Points["#text"]);
            }
        }

        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            picMugshot.ImageLocation = "http://tsnimages.tsn.ca/ImageProvider/PlayerHeadshot?seoId=" + (dgvPlayers.SelectedCells[1].Value).ToString().Replace(' ','-');
        }

        private void dgvPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lstPlayers.Items.Add(dgvPlayers.SelectedCells[1].Value);
            dgvPlayers.Rows.Remove(dgvPlayers.SelectedRows[0]);
        }
    }
}
