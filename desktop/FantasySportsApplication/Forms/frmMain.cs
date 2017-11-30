using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;

namespace FantasySportsApplication
{
    public partial class frmMain : Form
    {
        public int LeagueID { get; set; }
        public int LeagueRosterID { get; set; }
        public int CurrentID { get; set; }
        public string Sport { get; set; }
        public string CurrentUser { get; set; }
        public string LeagueName { get; set; }
        public string TeamName { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private List<Player> PlayerList = new List<Player>();

        private void UpdateOwner(Player SelectedPlayer)
        {
            String owner = Backend.DeterminePlayerOwner(SelectedPlayer, LeagueID);
            if (owner == TeamName)
            {
                lblOwner.Text = "You!";
                lblOwner.ForeColor = Color.Yellow;
            }
            else if (owner == null)
            {
                lblOwner.Text = "--Available--";
                lblOwner.ForeColor = Color.Green;
            }
            else
            {
                lblOwner.Text = owner;
                lblOwner.ForeColor = Color.Red;
            }
        }

        private void UpdatePlayerPoints()
        {
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT player_name FROM roster WHERE league_roster_id={0}", LeagueRosterID), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            while (rdr.Read())
            {
                String playername = rdr.GetString(0);
                foreach (Player p in PlayerList)
                {
                    if (p.Name == playername)
                    {
                        Backend.UpdatePoints(LeagueRosterID, p);
                        break;
                    }
                }
            }
            rdr.Close();
            cnn.Close();
        }

        private void ListRules()
        {
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT rules FROM league WHERE league_id={0}", LeagueID), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int rules_id = Convert.ToInt32(rdr[0].ToString());
            rdr.Close();

            cmdSql = new MySqlCommand(String.Format("SELECT stats_list FROM rules WHERE rules_id={0}", rules_id), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            string stats = rdr[0].ToString();
            rdr.Close();
            cnn.Close();

            foreach (string rule in stats.Split(','))
            {
                lstScoring.Items.Add(rule);
            }
        }

        private void ImportPlayerStats()
        {
            int i = 0;

            //Shared stats
            string name;
            string team;
            string jerseynumber;
            string position;
            int gamesplayed;
            int goals;
            int assists;
            int points;
            int hattricks;
            int penalties;
            int penaltyminutes;
            int powerplaygoals;
            int powerplayassists;
            int powerplaypoints;
            int shorthandedgoals;
            int shorthandedassists;
            int shorthandedpoints;
            int gamewinninggoals;
            int gametyinggoals;

            //Player-only stats
            int plusminus;
            int shots;
            float shotpercentage;
            int hits;
            int faceoffs;
            int faceoffwins;
            int faceofflosses;
            float faceoffpercent;

            //Goalie-only stats
            int wins;
            int losses;
            int overtimewins;
            int overtimelosses;
            int goalsagainst;
            int shotsagainst;
            int saves;
            float goalsagainstaverage;
            float savepercentage;
            int shutouts;
            int gamesstarted;
            int creditforgame;
            int minutesplayed;

            //Request the player stats from the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.mysportsfeeds.com/v1.1/pull/nhl/2017-2018/cumulative_player_stats.json");
            request.Credentials = new NetworkCredential("Tolton15", "sportsApp123");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //Read and interpret the JSON returned from the API request
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            string json = reader.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject(json);

            //Create the data table
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Index"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Position"));
            dt.Columns.Add(new DataColumn("Team"));

            //Add a new row for each player
            DataRow dr;
            foreach (var playerentry in obj.cumulativeplayerstats.playerstatsentry)
            {
                //Pull the player data
                name = playerentry.player.FirstName + " " + playerentry.player.LastName;
                team = playerentry.team.City + " " + playerentry.team.Name;
                jerseynumber = playerentry.player.JerseyNumber;
                position = (playerentry.player.Position).ToString();
                gamesplayed = Int32.Parse((playerentry.stats.GamesPlayed["#text"]).ToString());
                goals = Int32.Parse((playerentry.stats.stats.Goals["#text"]).ToString());
                assists = Int32.Parse((playerentry.stats.stats.Assists["#text"]).ToString());
                points = Int32.Parse((playerentry.stats.stats.Points["#text"]).ToString());
                hattricks = Int32.Parse((playerentry.stats.stats.HatTricks["#text"]).ToString());
                penalties = Int32.Parse((playerentry.stats.stats.Penalties["#text"]).ToString());
                penaltyminutes = Int32.Parse((playerentry.stats.stats.PenaltyMinutes["#text"]).ToString());
                powerplaygoals = Int32.Parse((playerentry.stats.stats.PowerplayGoals["#text"]).ToString());
                powerplayassists = Int32.Parse((playerentry.stats.stats.PowerplayAssists["#text"]).ToString());
                powerplaypoints = Int32.Parse((playerentry.stats.stats.PowerplayPoints["#text"]).ToString());
                shorthandedgoals = Int32.Parse((playerentry.stats.stats.ShorthandedGoals["#text"]).ToString());
                shorthandedassists = Int32.Parse((playerentry.stats.stats.ShorthandedAssists["#text"]).ToString());
                shorthandedpoints = Int32.Parse((playerentry.stats.stats.ShorthandedPoints["#text"]).ToString());
                gamewinninggoals = Int32.Parse((playerentry.stats.stats.GameWinningGoals["#text"]).ToString());
                gametyinggoals = Int32.Parse((playerentry.stats.stats.GameTyingGoals["#text"]).ToString());




                //Create the player object and add to list
                if (position == "G")
                {
                    wins = Int32.Parse((playerentry.stats.stats.Wins["#text"]).ToString());
                    losses = Int32.Parse((playerentry.stats.stats.Losses["#text"]).ToString());
                    overtimewins = Int32.Parse((playerentry.stats.stats.OvertimeWins["#text"]).ToString());
                    overtimelosses = Int32.Parse((playerentry.stats.stats.OvertimeLosses["#text"]).ToString());
                    goalsagainst = Int32.Parse((playerentry.stats.stats.GoalsAgainst["#text"]).ToString());
                    shotsagainst = Int32.Parse((playerentry.stats.stats.ShotsAgainst["#text"]).ToString());
                    saves = Int32.Parse((playerentry.stats.stats.Saves["#text"]).ToString());
                    goalsagainstaverage = float.Parse((playerentry.stats.stats.GoalsAgainstAverage["#text"]).ToString());
                    savepercentage = float.Parse((playerentry.stats.stats.SavePercentage["#text"]).ToString());
                    shutouts = Int32.Parse((playerentry.stats.stats.Shutouts["#text"]).ToString());
                    gamesstarted = Int32.Parse((playerentry.stats.stats.GamesStarted["#text"]).ToString());
                    creditforgame = Int32.Parse((playerentry.stats.stats.CreditForGame["#text"]).ToString());
                    minutesplayed = Int32.Parse((playerentry.stats.stats.MinutesPlayed["#text"]).ToString());

                    PlayerList.Add(new Player(name, team, jerseynumber, position, gamesplayed,
                    goals, assists, points, hattricks, penalties, penaltyminutes, powerplaygoals,
                    powerplayassists, powerplaypoints, shorthandedgoals, shorthandedassists,
                    shorthandedpoints, gamewinninggoals, gametyinggoals, wins, losses, overtimewins,
                    overtimelosses, goalsagainst, shotsagainst, saves, goalsagainstaverage,
                    savepercentage, shutouts, gamesstarted, creditforgame, minutesplayed));
                }
                else
                {
                    plusminus = Int32.Parse((playerentry.stats.stats.PlusMinus["#text"]).ToString());
                    shots = Int32.Parse((playerentry.stats.stats.Shots["#text"]).ToString());
                    shotpercentage = float.Parse((playerentry.stats.stats.ShotPercentage["#text"]).ToString());
                    hits = Int32.Parse((playerentry.stats.stats.Hits["#text"]).ToString());
                    faceoffs = Int32.Parse((playerentry.stats.stats.Faceoffs["#text"]).ToString());
                    faceoffwins = Int32.Parse((playerentry.stats.stats.FaceoffWins["#text"]).ToString());
                    faceofflosses = Int32.Parse((playerentry.stats.stats.FaceoffLosses["#text"]).ToString());
                    faceoffpercent = float.Parse((playerentry.stats.stats.FaceoffPercent["#text"]).ToString());

                    PlayerList.Add(new Player(name, team, jerseynumber, position, gamesplayed,
                    goals, assists, points, hattricks, penalties, penaltyminutes, powerplaygoals,
                    powerplayassists, powerplaypoints, shorthandedgoals, shorthandedassists,
                    shorthandedpoints, gamewinninggoals, gametyinggoals, plusminus, shots,
                    shotpercentage, hits, faceoffs, faceoffwins, faceofflosses, faceoffpercent));
                }

                //Add the player to the DataTable
                dr = dt.NewRow();
                dr["Index"] = i++;
                dr["Name"] = name;
                dr["Team"] = team;
                dr["Position"] = position;

                //Add the row to the DataTable
                dt.Rows.Add(dr);
                
            }

            //Update the DataGridView with the DataTable and hide the index
            dgvPlayers.DataSource = dt;
            dgvPlayers.Columns["Index"].Visible = false;

        }

        private void PopulateStats(Player player)
        {
            //Player stats
            if (player.Position != "G")
            {
                lblPlayer_GamesPlayed.Text = player.GamesPlayed.ToString();
                lblPlayer_Goals.Text = player.Goals.ToString();
                lblPlayer_Assists.Text = player.Assists.ToString();
                lblPlayer_Points.Text = player.Points.ToString();
                lblPlayer_HatTricks.Text = player.HatTricks.ToString();
                lblPlayer_Penalties.Text = player.Penalties.ToString();
                lblPlayer_PenaltyMinutes.Text = player.PenaltyMinutes.ToString();
                lblPlayer_PowerplayGoals.Text = player.PowerplayGoals.ToString();
                lblPlayer_PowerplayAssists.Text = player.PowerplayAssists.ToString();
                lblPlayer_PowerplayPoints.Text = player.PowerplayPoints.ToString();
                lblPlayer_ShorthandedGoals.Text = player.ShorthandedGoals.ToString();
                lblPlayer_ShorthandedAssists.Text = player.ShorthandedAssists.ToString();
                lblPlayer_ShorthandedPoints.Text = player.ShorthandedPoints.ToString();
                lblPlayer_GameWinningGoals.Text = player.GameWinningGoals.ToString();
                lblPlayer_GameTyingGoals.Text = player.GameTyingGoals.ToString();

                lblPlayer_PlusMinus.Text = player.PlusMinus.ToString();
                lblPlayer_Shots.Text = player.Shots.ToString();
                lblPlayer_ShotPercentage.Text = player.ShotPercentage.ToString();
                lblPlayer_Hits.Text = player.Hits.ToString();
                lblPlayer_Faceoffs.Text = player.Faceoffs.ToString();
                lblPlayer_FaceoffWins.Text = player.FaceoffWins.ToString();
                lblPlayer_FaceoffLosses.Text = player.FaceoffLosses.ToString();
                lblPlayer_FaceoffPercent.Text = player.FaceoffPercent.ToString();

                tbctrlStats.SelectedTab = tbpgPlayers;
            }
            //Goalie stats
            else
            {
                lblGoalie_GamesPlayed.Text = player.GamesPlayed.ToString();
                lblGoalie_Goals.Text = player.Goals.ToString();
                lblGoalie_Assists.Text = player.Assists.ToString();
                lblGoalie_Points.Text = player.Points.ToString();
                lblGoalie_HatTricks.Text = player.HatTricks.ToString();
                lblGoalie_Penalties.Text = player.Penalties.ToString();
                lblGoalie_PenaltyMinutes.Text = player.PenaltyMinutes.ToString();
                lblGoalie_PowerplayGoals.Text = player.PowerplayGoals.ToString();
                lblGoalie_PowerplayAssists.Text = player.PowerplayAssists.ToString();
                lblGoalie_PowerplayPoints.Text = player.PowerplayPoints.ToString();
                lblGoalie_ShorthandedGoals.Text = player.ShorthandedGoals.ToString();
                lblGoalie_ShorthandedAssists.Text = player.ShorthandedAssists.ToString();
                lblGoalie_ShorthandedPoints.Text = player.ShorthandedPoints.ToString();
                lblGoalie_GameWinningGoals.Text = player.GameWinningGoals.ToString();
                lblGoalie_GameTyingGoals.Text = player.GameTyingGoals.ToString();

                lblGoalie_Wins.Text = player.Wins.ToString();
                lblGoalie_Losses.Text = player.Losses.ToString();
                lblGoalie_OvertimeWins.Text = player.OvertimeWins.ToString();
                lblGoalie_OvertimeLosses.Text = player.OvertimeLosses.ToString();
                lblGoalie_GoalsAgainst.Text = player.GoalsAgainst.ToString();
                lblGoalie_ShotsAgainst.Text = player.ShotsAgainst.ToString();
                lblGoalie_Saves.Text = player.Saves.ToString();
                lblGoalie_GoalsAgainstAverage.Text = player.GoalsAgainstAverage.ToString();
                lblGoalie_SavePercentage.Text = player.SavePercentage.ToString();
                lblGoalie_Shutouts.Text = player.Shutouts.ToString();
                lblGoalie_GamesStarted.Text = player.GamesStarted.ToString();
                lblGoalie_CreditForGame.Text = player.CreditForGame.ToString();
                lblGoalie_MinutesPlayed.Text = player.MinutesPlayed.ToString();

                tbctrlStats.SelectedTab = tbpgGoalies;
            }
        }

        private void PopulateOtherTeams()
        {
            string otherTeam;
            int rosterid;
            int bankedPoints;
            int playerPoints;
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT team_name, league_roster_id FROM league_roster WHERE league_id={0}", LeagueID), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();

            MySqlConnection cnn2;
            MySqlCommand cmdSql2;
            MySqlDataReader rdr2;

            while (rdr.Read())
            {
                otherTeam = rdr.GetString(0);
                rosterid = rdr.GetInt32(1);

                cnn2 = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
                cnn2.Open();
                cmdSql2 = new MySqlCommand(String.Format("SELECT banked_points FROM league_roster WHERE league_roster_id={0}", rosterid), cnn2);
                rdr2 = cmdSql2.ExecuteReader();
                rdr2.Read();
                bankedPoints = rdr2.GetInt32(0);
                rdr2.Close();

                cmdSql2 = new MySqlCommand(String.Format("SELECT points FROM roster WHERE league_roster_id={0}", rosterid), cnn2);
                rdr2 = cmdSql2.ExecuteReader();
                playerPoints = 0;
                while (rdr2.Read())
                {
                    playerPoints += rdr2.GetInt32(0);
                }
                rdr2.Close();
                cnn2.Close();

                dgvStandings.Rows.Add(otherTeam, (bankedPoints + playerPoints));
                if (otherTeam != TeamName)
                {
                    cmboOtherTeam.Items.Add(otherTeam);
                }
            }
            rdr.Close();
            cnn.Close();
        }

        private void UpdateRoster(DataGridView dgv, String team)
        {
            //Find the rules for the league
            MySqlConnection cnn = new MySqlConnection("SERVER=cis4250.cpnptclkba5c.ca-central-1.rds.amazonaws.com;DATABASE=fantasySportsApplication;UID=teamOgre;PWD=sportsApp123;Connection Timeout=5");
            cnn.Open();
            MySqlCommand cmdSql = new MySqlCommand(String.Format("SELECT rules FROM league WHERE league_id={0};", LeagueID), cnn);
            MySqlDataReader rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int rulesid = rdr.GetInt32(0);
            rdr.Close();

            //Add rows for each number of positions allowed in league
            cmdSql = new MySqlCommand(String.Format("SELECT max_c, max_lw, max_rw, max_d, max_g FROM rules WHERE rules_id={0};", rulesid), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();

            int maxc = rdr.GetInt32(0);
            int maxlw = rdr.GetInt32(1);
            int maxrw = rdr.GetInt32(2);
            int maxd = rdr.GetInt32(3);
            int maxg = rdr.GetInt32(4);

            rdr.Close();
            dgv.Rows.Clear();

            for (int i = 0; i < maxc; i++)
                dgv.Rows.Add("C", "<<empty>>", "0");

            for (int i = 0; i < maxlw; i++)
                dgv.Rows.Add("LW", "<<empty>>", "0");

            for (int i = 0; i < maxrw; i++)
                dgv.Rows.Add("RW", "<<empty>>", "0");

            for (int i = 0; i < maxd; i++)
                dgv.Rows.Add("D", "<<empty>>", "0");

            for (int i = 0; i < maxg; i++)
                dgv.Rows.Add("G", "<<empty>>", "0");

            //Grab the team roster ID
            cmdSql = new MySqlCommand(String.Format("SELECT league_roster_id FROM league_roster WHERE team_name = '{0}' AND league_id = {1};", team, LeagueID), cnn);
            rdr = cmdSql.ExecuteReader();
            rdr.Read();
            int teamid = rdr.GetInt32(0);
            rdr.Close();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }

            //Grab players on the team
            cmdSql = new MySqlCommand(String.Format("SELECT position, player_name, points FROM roster WHERE league_roster_id = {0};", teamid), cnn);
            rdr = cmdSql.ExecuteReader();
            while (rdr.Read())
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[0].Value.ToString() == rdr.GetString(0) && (row.Cells[1].Value.ToString() == "<<empty>>"))
                    {
                        row.Cells[1].Value = rdr.GetString(1);
                        row.Cells[2].Value = rdr.GetInt32(2);
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        break;
                    }
                }
            }

            rdr.Close();
            cnn.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash splashForm = new frmSplash();
            splashForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ImportPlayerStats();
            PopulateOtherTeams();
            UpdatePlayerPoints();
            UpdateRoster(dgvMyRoster, TeamName);
            ListRules();
        }

        private void tbctrlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tbctrlMain.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tbctrlMain.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)18.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void dgvPlayers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells["index"].Value.ToString());
            Player SelectedPlayer = PlayerList[index];

            lblName.Text = String.Format("#{0} - {1}",SelectedPlayer.JerseyNumber, SelectedPlayer.Name);
            PopulateStats(SelectedPlayer);
            picMugshot.ImageLocation = "http://tsnimages.tsn.ca/ImageProvider/PlayerHeadshot?seoId=" + (SelectedPlayer.Name.Replace(' ','-').Replace(".",""));
            UpdateOwner(SelectedPlayer);
        }

        private void dgvPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Player SelectedPlayer = PlayerList[Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells["Index"].Value.ToString())];
            switch (Backend.AddPlayer(LeagueRosterID, LeagueID, SelectedPlayer))
            {
                case 0:
                    MessageBox.Show(String.Format("{0} has been successfully added to your team!", SelectedPlayer.Name));
                    break;

                case -1:
                    MessageBox.Show("ERROR: Unable to establish a connection to the server.");
                    break;

                case -2:
                    MessageBox.Show("ERROR: You already own this player!");
                    break;

                case -3:
                    MessageBox.Show("ERROR: Another team already owns this player!");
                    break;

                case -4:
                    MessageBox.Show(String.Format("ERROR: You already have the maximum number of players of the '{0}' position!", SelectedPlayer.Position));
                    break;
            }
            UpdateOwner(SelectedPlayer);
            UpdateRoster(dgvMyRoster, TeamName);
        }

        private void cmboOtherTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRoster(dgvOtherRoster, cmboOtherTeam.Text);
        }

        private void tbctrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbctrlMain.SelectedIndex == 2)
            {
                Player SelectedPlayer = PlayerList[Convert.ToInt32(dgvPlayers.SelectedRows[0].Cells["Index"].Value.ToString())];
                UpdateOwner(SelectedPlayer);
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            Player SelectedPlayer = null;
            foreach (Player p in PlayerList)
            {
                if (p.Name == dgvMyRoster.SelectedRows[0].Cells[1].Value.ToString())
                {
                    SelectedPlayer = p;
                    break;
                }
            }
            if (SelectedPlayer == null)
                return;
            Backend.DropPlayer(LeagueRosterID, SelectedPlayer);
            UpdateRoster(dgvMyRoster, TeamName);
        }
    }
}
