namespace FantasySportsApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tbctrlMain = new System.Windows.Forms.TabControl();
            this.tbpgMyTeam = new System.Windows.Forms.TabPage();
            this.cmboOtherTeam = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lstOtherTeam = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lstMyTeam = new System.Windows.Forms.ListBox();
            this.tbpgStandings = new System.Windows.Forms.TabPage();
            this.dgvStandings = new System.Windows.Forms.DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label28 = new System.Windows.Forms.Label();
            this.tbpgSearchPlayers = new System.Windows.Forms.TabPage();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picMugshot = new System.Windows.Forms.PictureBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.tbctrlStats = new FantasySportsApplication.TablessTabControl();
            this.tbpgPlayers = new System.Windows.Forms.TabPage();
            this.lblPlayer_ShorthandedPoints = new System.Windows.Forms.Label();
            this.lblPlayer_ShorthandedAssists = new System.Windows.Forms.Label();
            this.lblPlayer_ShorthandedGoals = new System.Windows.Forms.Label();
            this.lblPlayer_PowerplayPoints = new System.Windows.Forms.Label();
            this.lblPlayer_PowerplayAssists = new System.Windows.Forms.Label();
            this.lblPlayer_PowerplayGoals = new System.Windows.Forms.Label();
            this.lblPlayer_HatTricks = new System.Windows.Forms.Label();
            this.lblPlayer_PenaltyMinutes = new System.Windows.Forms.Label();
            this.lblPlayer_ShotPercentage = new System.Windows.Forms.Label();
            this.lblPlayer_GameTyingGoals = new System.Windows.Forms.Label();
            this.lblPlayer_GameWinningGoals = new System.Windows.Forms.Label();
            this.lblPlayer_FaceoffPercent = new System.Windows.Forms.Label();
            this.lblPlayer_FaceoffLosses = new System.Windows.Forms.Label();
            this.lblPlayer_FaceoffWins = new System.Windows.Forms.Label();
            this.lblPlayer_Faceoffs = new System.Windows.Forms.Label();
            this.lblPlayer_Penalties = new System.Windows.Forms.Label();
            this.lblPlayer_Hits = new System.Windows.Forms.Label();
            this.lblPlayer_Shots = new System.Windows.Forms.Label();
            this.lblPlayer_PlusMinus = new System.Windows.Forms.Label();
            this.lblPlayer_Points = new System.Windows.Forms.Label();
            this.lblPlayer_Assists = new System.Windows.Forms.Label();
            this.lblPlayer_Goals = new System.Windows.Forms.Label();
            this.lblPlayer_GamesPlayed = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpgGoalies = new System.Windows.Forms.TabPage();
            this.lblGoalie_GamesStarted = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.lblGoalie_SavePercentage = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.lblGoalie_GoalsAgainstAverage = new System.Windows.Forms.Label();
            this.lblGoalie_MinutesPlayed = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.lblGoalie_CreditForGame = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblGoalie_ShorthandedPoints = new System.Windows.Forms.Label();
            this.lblGoalie_ShorthandedAssists = new System.Windows.Forms.Label();
            this.lblGoalie_ShorthandedGoals = new System.Windows.Forms.Label();
            this.lblGoalie_PowerplayPoints = new System.Windows.Forms.Label();
            this.lblGoalie_PowerplayAssists = new System.Windows.Forms.Label();
            this.lblGoalie_PowerplayGoals = new System.Windows.Forms.Label();
            this.lblGoalie_HatTricks = new System.Windows.Forms.Label();
            this.lblGoalie_PenaltyMinutes = new System.Windows.Forms.Label();
            this.lblGoalie_Shutouts = new System.Windows.Forms.Label();
            this.lblGoalie_GameTyingGoals = new System.Windows.Forms.Label();
            this.lblGoalie_GameWinningGoals = new System.Windows.Forms.Label();
            this.lblGoalie_OvertimeLosses = new System.Windows.Forms.Label();
            this.lblGoalie_OvertimeWins = new System.Windows.Forms.Label();
            this.lblGoalie_Losses = new System.Windows.Forms.Label();
            this.lblGoalie_Wins = new System.Windows.Forms.Label();
            this.lblGoalie_Penalties = new System.Windows.Forms.Label();
            this.lblGoalie_GoalsAgainst = new System.Windows.Forms.Label();
            this.lblGoalie_Saves = new System.Windows.Forms.Label();
            this.lblGoalie_ShotsAgainst = new System.Windows.Forms.Label();
            this.lblGoalie_Points = new System.Windows.Forms.Label();
            this.lblGoalie_Assists = new System.Windows.Forms.Label();
            this.lblGoalie_Goals = new System.Windows.Forms.Label();
            this.lblGoalie_GamesPlayed = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.tbpgLeagueSettings = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.lstScoring = new System.Windows.Forms.ListBox();
            this.mnuMain.SuspendLayout();
            this.tbctrlMain.SuspendLayout();
            this.tbpgMyTeam.SuspendLayout();
            this.tbpgStandings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).BeginInit();
            this.tbpgSearchPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.tbctrlStats.SuspendLayout();
            this.tbpgPlayers.SuspendLayout();
            this.tbpgGoalies.SuspendLayout();
            this.tbpgLeagueSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmAccount});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1356, 33);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuItmAccount
            // 
            this.mnuItmAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSettings,
            this.mnuItmLogOut});
            this.mnuItmAccount.Name = "mnuItmAccount";
            this.mnuItmAccount.Size = new System.Drawing.Size(89, 29);
            this.mnuItmAccount.Text = "Account";
            // 
            // mnuItemSettings
            // 
            this.mnuItemSettings.Name = "mnuItemSettings";
            this.mnuItemSettings.Size = new System.Drawing.Size(161, 30);
            this.mnuItemSettings.Text = "Settings";
            // 
            // mnuItmLogOut
            // 
            this.mnuItmLogOut.Name = "mnuItmLogOut";
            this.mnuItmLogOut.Size = new System.Drawing.Size(161, 30);
            this.mnuItmLogOut.Text = "Log Out";
            this.mnuItmLogOut.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbctrlMain.Controls.Add(this.tbpgMyTeam);
            this.tbctrlMain.Controls.Add(this.tbpgStandings);
            this.tbctrlMain.Controls.Add(this.tbpgSearchPlayers);
            this.tbctrlMain.Controls.Add(this.tbpgLeagueSettings);
            this.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbctrlMain.ItemSize = new System.Drawing.Size(40, 175);
            this.tbctrlMain.Location = new System.Drawing.Point(0, 33);
            this.tbctrlMain.Multiline = true;
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(1356, 649);
            this.tbctrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbctrlMain.TabIndex = 1;
            this.tbctrlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbctrlMain_DrawItem);
            // 
            // tbpgMyTeam
            // 
            this.tbpgMyTeam.Controls.Add(this.cmboOtherTeam);
            this.tbpgMyTeam.Controls.Add(this.label26);
            this.tbpgMyTeam.Controls.Add(this.label25);
            this.tbpgMyTeam.Controls.Add(this.lstOtherTeam);
            this.tbpgMyTeam.Controls.Add(this.label17);
            this.tbpgMyTeam.Controls.Add(this.lstMyTeam);
            this.tbpgMyTeam.Location = new System.Drawing.Point(179, 4);
            this.tbpgMyTeam.Name = "tbpgMyTeam";
            this.tbpgMyTeam.Size = new System.Drawing.Size(1173, 641);
            this.tbpgMyTeam.TabIndex = 0;
            this.tbpgMyTeam.Text = "My Team";
            this.tbpgMyTeam.UseVisualStyleBackColor = true;
            // 
            // cmboOtherTeam
            // 
            this.cmboOtherTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboOtherTeam.FormattingEnabled = true;
            this.cmboOtherTeam.Location = new System.Drawing.Point(724, 67);
            this.cmboOtherTeam.Name = "cmboOtherTeam";
            this.cmboOtherTeam.Size = new System.Drawing.Size(338, 28);
            this.cmboOtherTeam.TabIndex = 5;
            this.cmboOtherTeam.SelectedIndexChanged += new System.EventHandler(this.cmboOtherTeam_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(619, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 20);
            this.label26.TabIndex = 4;
            this.label26.Text = "Select team:";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(617, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(445, 33);
            this.label25.TabIndex = 3;
            this.label25.Text = "Other Roster";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstOtherTeam
            // 
            this.lstOtherTeam.FormattingEnabled = true;
            this.lstOtherTeam.ItemHeight = 20;
            this.lstOtherTeam.Location = new System.Drawing.Point(617, 102);
            this.lstOtherTeam.Name = "lstOtherTeam";
            this.lstOtherTeam.ScrollAlwaysVisible = true;
            this.lstOtherTeam.Size = new System.Drawing.Size(445, 484);
            this.lstOtherTeam.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(69, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(445, 33);
            this.label17.TabIndex = 1;
            this.label17.Text = "My Roster";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstMyTeam
            // 
            this.lstMyTeam.FormattingEnabled = true;
            this.lstMyTeam.ItemHeight = 20;
            this.lstMyTeam.Location = new System.Drawing.Point(69, 102);
            this.lstMyTeam.Name = "lstMyTeam";
            this.lstMyTeam.ScrollAlwaysVisible = true;
            this.lstMyTeam.Size = new System.Drawing.Size(445, 484);
            this.lstMyTeam.TabIndex = 0;
            this.lstMyTeam.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMyTeam_MouseDoubleClick);
            // 
            // tbpgStandings
            // 
            this.tbpgStandings.Controls.Add(this.dgvStandings);
            this.tbpgStandings.Controls.Add(this.label28);
            this.tbpgStandings.Location = new System.Drawing.Point(179, 4);
            this.tbpgStandings.Name = "tbpgStandings";
            this.tbpgStandings.Size = new System.Drawing.Size(1173, 641);
            this.tbpgStandings.TabIndex = 1;
            this.tbpgStandings.Text = "Standings";
            this.tbpgStandings.UseVisualStyleBackColor = true;
            // 
            // dgvStandings
            // 
            this.dgvStandings.AllowUserToAddRows = false;
            this.dgvStandings.AllowUserToDeleteRows = false;
            this.dgvStandings.AllowUserToResizeColumns = false;
            this.dgvStandings.AllowUserToResizeRows = false;
            this.dgvStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.colTeamName});
            this.dgvStandings.Location = new System.Drawing.Point(59, 118);
            this.dgvStandings.Name = "dgvStandings";
            this.dgvStandings.ReadOnly = true;
            this.dgvStandings.RowHeadersVisible = false;
            this.dgvStandings.RowTemplate.Height = 28;
            this.dgvStandings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandings.Size = new System.Drawing.Size(1076, 483);
            this.dgvStandings.TabIndex = 1;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTeamName
            // 
            this.colTeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeamName.HeaderText = "Team Name";
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            this.colTeamName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(512, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(160, 37);
            this.label28.TabIndex = 0;
            this.label28.Text = "Standings";
            // 
            // tbpgSearchPlayers
            // 
            this.tbpgSearchPlayers.BackColor = System.Drawing.Color.Black;
            this.tbpgSearchPlayers.Controls.Add(this.lblOwner);
            this.tbpgSearchPlayers.Controls.Add(this.label27);
            this.tbpgSearchPlayers.Controls.Add(this.lblName);
            this.tbpgSearchPlayers.Controls.Add(this.picMugshot);
            this.tbpgSearchPlayers.Controls.Add(this.dgvPlayers);
            this.tbpgSearchPlayers.Controls.Add(this.tbctrlStats);
            this.tbpgSearchPlayers.Location = new System.Drawing.Point(179, 4);
            this.tbpgSearchPlayers.Name = "tbpgSearchPlayers";
            this.tbpgSearchPlayers.Size = new System.Drawing.Size(1173, 641);
            this.tbpgSearchPlayers.TabIndex = 2;
            this.tbpgSearchPlayers.Text = "Search Players";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoEllipsis = true;
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(105, 344);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(237, 36);
            this.lblOwner.TabIndex = 6;
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(3, 344);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 36);
            this.label27.TabIndex = 5;
            this.label27.Text = "Owner:";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Tomato;
            this.lblName.Location = new System.Drawing.Point(374, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(707, 42);
            this.lblName.TabIndex = 2;
            // 
            // picMugshot
            // 
            this.picMugshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMugshot.ErrorImage = global::FantasySportsApplication.Properties.Resources.UnknownMugshot;
            this.picMugshot.InitialImage = global::FantasySportsApplication.Properties.Resources.UnknownMugshot;
            this.picMugshot.Location = new System.Drawing.Point(25, 25);
            this.picMugshot.Name = "picMugshot";
            this.picMugshot.Size = new System.Drawing.Size(317, 310);
            this.picMugshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMugshot.TabIndex = 1;
            this.picMugshot.TabStop = false;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlayers.EnableHeadersVisualStyles = false;
            this.dgvPlayers.Location = new System.Drawing.Point(0, 394);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowTemplate.Height = 28;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(1173, 247);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellDoubleClick);
            this.dgvPlayers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_RowEnter);
            // 
            // tbctrlStats
            // 
            this.tbctrlStats.Controls.Add(this.tbpgPlayers);
            this.tbctrlStats.Controls.Add(this.tbpgGoalies);
            this.tbctrlStats.Location = new System.Drawing.Point(374, 71);
            this.tbctrlStats.Name = "tbctrlStats";
            this.tbctrlStats.SelectedIndex = 0;
            this.tbctrlStats.Size = new System.Drawing.Size(711, 310);
            this.tbctrlStats.TabIndex = 4;
            this.tbctrlStats.TabStop = false;
            // 
            // tbpgPlayers
            // 
            this.tbpgPlayers.BackColor = System.Drawing.Color.Black;
            this.tbpgPlayers.Controls.Add(this.lblPlayer_ShorthandedPoints);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_ShorthandedAssists);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_ShorthandedGoals);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_PowerplayPoints);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_PowerplayAssists);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_PowerplayGoals);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_HatTricks);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_PenaltyMinutes);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_ShotPercentage);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_GameTyingGoals);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_GameWinningGoals);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_FaceoffPercent);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_FaceoffLosses);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_FaceoffWins);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Faceoffs);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Penalties);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Hits);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Shots);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_PlusMinus);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Points);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Assists);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_Goals);
            this.tbpgPlayers.Controls.Add(this.lblPlayer_GamesPlayed);
            this.tbpgPlayers.Controls.Add(this.label18);
            this.tbpgPlayers.Controls.Add(this.label19);
            this.tbpgPlayers.Controls.Add(this.label20);
            this.tbpgPlayers.Controls.Add(this.label21);
            this.tbpgPlayers.Controls.Add(this.label22);
            this.tbpgPlayers.Controls.Add(this.label23);
            this.tbpgPlayers.Controls.Add(this.label24);
            this.tbpgPlayers.Controls.Add(this.label9);
            this.tbpgPlayers.Controls.Add(this.label10);
            this.tbpgPlayers.Controls.Add(this.label11);
            this.tbpgPlayers.Controls.Add(this.label12);
            this.tbpgPlayers.Controls.Add(this.label13);
            this.tbpgPlayers.Controls.Add(this.label14);
            this.tbpgPlayers.Controls.Add(this.label15);
            this.tbpgPlayers.Controls.Add(this.label16);
            this.tbpgPlayers.Controls.Add(this.label8);
            this.tbpgPlayers.Controls.Add(this.label7);
            this.tbpgPlayers.Controls.Add(this.label6);
            this.tbpgPlayers.Controls.Add(this.label5);
            this.tbpgPlayers.Controls.Add(this.label4);
            this.tbpgPlayers.Controls.Add(this.label3);
            this.tbpgPlayers.Controls.Add(this.label2);
            this.tbpgPlayers.Controls.Add(this.label1);
            this.tbpgPlayers.Location = new System.Drawing.Point(4, 29);
            this.tbpgPlayers.Name = "tbpgPlayers";
            this.tbpgPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgPlayers.Size = new System.Drawing.Size(703, 277);
            this.tbpgPlayers.TabIndex = 0;
            this.tbpgPlayers.Text = "Players";
            // 
            // lblPlayer_ShorthandedPoints
            // 
            this.lblPlayer_ShorthandedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_ShorthandedPoints.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_ShorthandedPoints.Location = new System.Drawing.Point(617, 171);
            this.lblPlayer_ShorthandedPoints.Name = "lblPlayer_ShorthandedPoints";
            this.lblPlayer_ShorthandedPoints.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_ShorthandedPoints.TabIndex = 91;
            // 
            // lblPlayer_ShorthandedAssists
            // 
            this.lblPlayer_ShorthandedAssists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_ShorthandedAssists.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_ShorthandedAssists.Location = new System.Drawing.Point(617, 144);
            this.lblPlayer_ShorthandedAssists.Name = "lblPlayer_ShorthandedAssists";
            this.lblPlayer_ShorthandedAssists.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_ShorthandedAssists.TabIndex = 90;
            // 
            // lblPlayer_ShorthandedGoals
            // 
            this.lblPlayer_ShorthandedGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_ShorthandedGoals.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_ShorthandedGoals.Location = new System.Drawing.Point(617, 117);
            this.lblPlayer_ShorthandedGoals.Name = "lblPlayer_ShorthandedGoals";
            this.lblPlayer_ShorthandedGoals.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_ShorthandedGoals.TabIndex = 89;
            // 
            // lblPlayer_PowerplayPoints
            // 
            this.lblPlayer_PowerplayPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_PowerplayPoints.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_PowerplayPoints.Location = new System.Drawing.Point(617, 90);
            this.lblPlayer_PowerplayPoints.Name = "lblPlayer_PowerplayPoints";
            this.lblPlayer_PowerplayPoints.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_PowerplayPoints.TabIndex = 88;
            // 
            // lblPlayer_PowerplayAssists
            // 
            this.lblPlayer_PowerplayAssists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_PowerplayAssists.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_PowerplayAssists.Location = new System.Drawing.Point(617, 63);
            this.lblPlayer_PowerplayAssists.Name = "lblPlayer_PowerplayAssists";
            this.lblPlayer_PowerplayAssists.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_PowerplayAssists.TabIndex = 87;
            // 
            // lblPlayer_PowerplayGoals
            // 
            this.lblPlayer_PowerplayGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_PowerplayGoals.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_PowerplayGoals.Location = new System.Drawing.Point(617, 36);
            this.lblPlayer_PowerplayGoals.Name = "lblPlayer_PowerplayGoals";
            this.lblPlayer_PowerplayGoals.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_PowerplayGoals.TabIndex = 86;
            // 
            // lblPlayer_HatTricks
            // 
            this.lblPlayer_HatTricks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_HatTricks.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_HatTricks.Location = new System.Drawing.Point(617, 9);
            this.lblPlayer_HatTricks.Name = "lblPlayer_HatTricks";
            this.lblPlayer_HatTricks.Size = new System.Drawing.Size(45, 23);
            this.lblPlayer_HatTricks.TabIndex = 85;
            // 
            // lblPlayer_PenaltyMinutes
            // 
            this.lblPlayer_PenaltyMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_PenaltyMinutes.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_PenaltyMinutes.Location = new System.Drawing.Point(380, 198);
            this.lblPlayer_PenaltyMinutes.Name = "lblPlayer_PenaltyMinutes";
            this.lblPlayer_PenaltyMinutes.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_PenaltyMinutes.TabIndex = 84;
            // 
            // lblPlayer_ShotPercentage
            // 
            this.lblPlayer_ShotPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_ShotPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_ShotPercentage.Location = new System.Drawing.Point(380, 171);
            this.lblPlayer_ShotPercentage.Name = "lblPlayer_ShotPercentage";
            this.lblPlayer_ShotPercentage.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_ShotPercentage.TabIndex = 83;
            // 
            // lblPlayer_GameTyingGoals
            // 
            this.lblPlayer_GameTyingGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_GameTyingGoals.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_GameTyingGoals.Location = new System.Drawing.Point(380, 144);
            this.lblPlayer_GameTyingGoals.Name = "lblPlayer_GameTyingGoals";
            this.lblPlayer_GameTyingGoals.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_GameTyingGoals.TabIndex = 82;
            // 
            // lblPlayer_GameWinningGoals
            // 
            this.lblPlayer_GameWinningGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_GameWinningGoals.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_GameWinningGoals.Location = new System.Drawing.Point(380, 117);
            this.lblPlayer_GameWinningGoals.Name = "lblPlayer_GameWinningGoals";
            this.lblPlayer_GameWinningGoals.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_GameWinningGoals.TabIndex = 81;
            // 
            // lblPlayer_FaceoffPercent
            // 
            this.lblPlayer_FaceoffPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_FaceoffPercent.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_FaceoffPercent.Location = new System.Drawing.Point(380, 90);
            this.lblPlayer_FaceoffPercent.Name = "lblPlayer_FaceoffPercent";
            this.lblPlayer_FaceoffPercent.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_FaceoffPercent.TabIndex = 80;
            // 
            // lblPlayer_FaceoffLosses
            // 
            this.lblPlayer_FaceoffLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_FaceoffLosses.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_FaceoffLosses.Location = new System.Drawing.Point(380, 63);
            this.lblPlayer_FaceoffLosses.Name = "lblPlayer_FaceoffLosses";
            this.lblPlayer_FaceoffLosses.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_FaceoffLosses.TabIndex = 79;
            // 
            // lblPlayer_FaceoffWins
            // 
            this.lblPlayer_FaceoffWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_FaceoffWins.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_FaceoffWins.Location = new System.Drawing.Point(380, 36);
            this.lblPlayer_FaceoffWins.Name = "lblPlayer_FaceoffWins";
            this.lblPlayer_FaceoffWins.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_FaceoffWins.TabIndex = 78;
            // 
            // lblPlayer_Faceoffs
            // 
            this.lblPlayer_Faceoffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Faceoffs.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Faceoffs.Location = new System.Drawing.Point(380, 9);
            this.lblPlayer_Faceoffs.Name = "lblPlayer_Faceoffs";
            this.lblPlayer_Faceoffs.Size = new System.Drawing.Size(60, 23);
            this.lblPlayer_Faceoffs.TabIndex = 77;
            // 
            // lblPlayer_Penalties
            // 
            this.lblPlayer_Penalties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Penalties.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Penalties.Location = new System.Drawing.Point(133, 198);
            this.lblPlayer_Penalties.Name = "lblPlayer_Penalties";
            this.lblPlayer_Penalties.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_Penalties.TabIndex = 76;
            // 
            // lblPlayer_Hits
            // 
            this.lblPlayer_Hits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Hits.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Hits.Location = new System.Drawing.Point(133, 171);
            this.lblPlayer_Hits.Name = "lblPlayer_Hits";
            this.lblPlayer_Hits.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_Hits.TabIndex = 75;
            // 
            // lblPlayer_Shots
            // 
            this.lblPlayer_Shots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Shots.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Shots.Location = new System.Drawing.Point(133, 144);
            this.lblPlayer_Shots.Name = "lblPlayer_Shots";
            this.lblPlayer_Shots.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_Shots.TabIndex = 74;
            // 
            // lblPlayer_PlusMinus
            // 
            this.lblPlayer_PlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_PlusMinus.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_PlusMinus.Location = new System.Drawing.Point(133, 117);
            this.lblPlayer_PlusMinus.Name = "lblPlayer_PlusMinus";
            this.lblPlayer_PlusMinus.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_PlusMinus.TabIndex = 73;
            // 
            // lblPlayer_Points
            // 
            this.lblPlayer_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Points.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Points.Location = new System.Drawing.Point(133, 90);
            this.lblPlayer_Points.Name = "lblPlayer_Points";
            this.lblPlayer_Points.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_Points.TabIndex = 72;
            // 
            // lblPlayer_Assists
            // 
            this.lblPlayer_Assists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Assists.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Assists.Location = new System.Drawing.Point(133, 63);
            this.lblPlayer_Assists.Name = "lblPlayer_Assists";
            this.lblPlayer_Assists.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_Assists.TabIndex = 71;
            // 
            // lblPlayer_Goals
            // 
            this.lblPlayer_Goals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_Goals.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_Goals.Location = new System.Drawing.Point(133, 36);
            this.lblPlayer_Goals.Name = "lblPlayer_Goals";
            this.lblPlayer_Goals.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_Goals.TabIndex = 70;
            // 
            // lblPlayer_GamesPlayed
            // 
            this.lblPlayer_GamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_GamesPlayed.ForeColor = System.Drawing.Color.White;
            this.lblPlayer_GamesPlayed.Location = new System.Drawing.Point(133, 9);
            this.lblPlayer_GamesPlayed.Name = "lblPlayer_GamesPlayed";
            this.lblPlayer_GamesPlayed.Size = new System.Drawing.Size(50, 23);
            this.lblPlayer_GamesPlayed.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(447, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 23);
            this.label18.TabIndex = 68;
            this.label18.Text = "Short-handed Points:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(431, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 23);
            this.label19.TabIndex = 67;
            this.label19.Text = "Short-handed Assists:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(443, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 23);
            this.label20.TabIndex = 66;
            this.label20.Text = "Short-handed Goals:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(463, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 23);
            this.label21.TabIndex = 65;
            this.label21.Text = "Powerplay Points:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(465, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 23);
            this.label22.TabIndex = 64;
            this.label22.Text = "Powerplay Assists:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(473, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 23);
            this.label23.TabIndex = 63;
            this.label23.Text = "Powerplay Goals:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(511, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 62;
            this.label24.Text = "Hat Tricks:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(240, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "Penalty Minutes:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(219, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 23);
            this.label10.TabIndex = 60;
            this.label10.Text = "Shot Percentage:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(219, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 23);
            this.label11.TabIndex = 59;
            this.label11.Text = "Game-tying Goals:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(201, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 23);
            this.label12.TabIndex = 58;
            this.label12.Text = "Game-winning Goals:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(215, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 23);
            this.label13.TabIndex = 57;
            this.label13.Text = "Faceoff Percent:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(251, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 23);
            this.label14.TabIndex = 56;
            this.label14.Text = "Faceoff Losses:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(247, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 23);
            this.label15.TabIndex = 55;
            this.label15.Text = "Faceoff Wins:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(274, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 54;
            this.label16.Text = "Faceoffs:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "Penalties:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 52;
            this.label7.Text = "Hits:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Shots:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "+/-:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Points:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Assists:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Goals:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Games Played:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbpgGoalies
            // 
            this.tbpgGoalies.BackColor = System.Drawing.Color.Black;
            this.tbpgGoalies.Controls.Add(this.lblGoalie_GamesStarted);
            this.tbpgGoalies.Controls.Add(this.label77);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_SavePercentage);
            this.tbpgGoalies.Controls.Add(this.label72);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_GoalsAgainstAverage);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_MinutesPlayed);
            this.tbpgGoalies.Controls.Add(this.label75);
            this.tbpgGoalies.Controls.Add(this.label76);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_CreditForGame);
            this.tbpgGoalies.Controls.Add(this.label38);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_ShorthandedPoints);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_ShorthandedAssists);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_ShorthandedGoals);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_PowerplayPoints);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_PowerplayAssists);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_PowerplayGoals);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_HatTricks);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_PenaltyMinutes);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Shutouts);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_GameTyingGoals);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_GameWinningGoals);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_OvertimeLosses);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_OvertimeWins);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Losses);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Wins);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Penalties);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_GoalsAgainst);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Saves);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_ShotsAgainst);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Points);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Assists);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_Goals);
            this.tbpgGoalies.Controls.Add(this.lblGoalie_GamesPlayed);
            this.tbpgGoalies.Controls.Add(this.label47);
            this.tbpgGoalies.Controls.Add(this.label48);
            this.tbpgGoalies.Controls.Add(this.label49);
            this.tbpgGoalies.Controls.Add(this.label50);
            this.tbpgGoalies.Controls.Add(this.label51);
            this.tbpgGoalies.Controls.Add(this.label52);
            this.tbpgGoalies.Controls.Add(this.label53);
            this.tbpgGoalies.Controls.Add(this.label54);
            this.tbpgGoalies.Controls.Add(this.label55);
            this.tbpgGoalies.Controls.Add(this.label56);
            this.tbpgGoalies.Controls.Add(this.label57);
            this.tbpgGoalies.Controls.Add(this.label58);
            this.tbpgGoalies.Controls.Add(this.label59);
            this.tbpgGoalies.Controls.Add(this.label60);
            this.tbpgGoalies.Controls.Add(this.label61);
            this.tbpgGoalies.Controls.Add(this.label62);
            this.tbpgGoalies.Controls.Add(this.label63);
            this.tbpgGoalies.Controls.Add(this.label64);
            this.tbpgGoalies.Controls.Add(this.label65);
            this.tbpgGoalies.Controls.Add(this.label66);
            this.tbpgGoalies.Controls.Add(this.label67);
            this.tbpgGoalies.Controls.Add(this.label68);
            this.tbpgGoalies.Controls.Add(this.label69);
            this.tbpgGoalies.Location = new System.Drawing.Point(4, 29);
            this.tbpgGoalies.Name = "tbpgGoalies";
            this.tbpgGoalies.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgGoalies.Size = new System.Drawing.Size(703, 277);
            this.tbpgGoalies.TabIndex = 1;
            this.tbpgGoalies.Text = "Goalies";
            // 
            // lblGoalie_GamesStarted
            // 
            this.lblGoalie_GamesStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_GamesStarted.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_GamesStarted.Location = new System.Drawing.Point(133, 252);
            this.lblGoalie_GamesStarted.Name = "lblGoalie_GamesStarted";
            this.lblGoalie_GamesStarted.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_GamesStarted.TabIndex = 147;
            // 
            // label77
            // 
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(0, 252);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(127, 23);
            this.label77.TabIndex = 146;
            this.label77.Text = "Games Started:";
            this.label77.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoalie_SavePercentage
            // 
            this.lblGoalie_SavePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_SavePercentage.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_SavePercentage.Location = new System.Drawing.Point(617, 225);
            this.lblGoalie_SavePercentage.Name = "lblGoalie_SavePercentage";
            this.lblGoalie_SavePercentage.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_SavePercentage.TabIndex = 145;
            // 
            // label72
            // 
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(447, 225);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(164, 23);
            this.label72.TabIndex = 144;
            this.label72.Text = "Save Percentage:";
            this.label72.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoalie_GoalsAgainstAverage
            // 
            this.lblGoalie_GoalsAgainstAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_GoalsAgainstAverage.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_GoalsAgainstAverage.Location = new System.Drawing.Point(380, 225);
            this.lblGoalie_GoalsAgainstAverage.Name = "lblGoalie_GoalsAgainstAverage";
            this.lblGoalie_GoalsAgainstAverage.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_GoalsAgainstAverage.TabIndex = 143;
            // 
            // lblGoalie_MinutesPlayed
            // 
            this.lblGoalie_MinutesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_MinutesPlayed.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_MinutesPlayed.Location = new System.Drawing.Point(133, 225);
            this.lblGoalie_MinutesPlayed.Name = "lblGoalie_MinutesPlayed";
            this.lblGoalie_MinutesPlayed.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_MinutesPlayed.TabIndex = 142;
            // 
            // label75
            // 
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(189, 225);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(185, 23);
            this.label75.TabIndex = 141;
            this.label75.Text = "Goals Against Average:";
            this.label75.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label76
            // 
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(6, 225);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(121, 23);
            this.label76.TabIndex = 140;
            this.label76.Text = "Minutes Played:";
            this.label76.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoalie_CreditForGame
            // 
            this.lblGoalie_CreditForGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_CreditForGame.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_CreditForGame.Location = new System.Drawing.Point(617, 198);
            this.lblGoalie_CreditForGame.Name = "lblGoalie_CreditForGame";
            this.lblGoalie_CreditForGame.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_CreditForGame.TabIndex = 139;
            // 
            // label38
            // 
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(447, 198);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(164, 23);
            this.label38.TabIndex = 138;
            this.label38.Text = "Credit For Game:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoalie_ShorthandedPoints
            // 
            this.lblGoalie_ShorthandedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_ShorthandedPoints.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_ShorthandedPoints.Location = new System.Drawing.Point(617, 171);
            this.lblGoalie_ShorthandedPoints.Name = "lblGoalie_ShorthandedPoints";
            this.lblGoalie_ShorthandedPoints.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_ShorthandedPoints.TabIndex = 137;
            // 
            // lblGoalie_ShorthandedAssists
            // 
            this.lblGoalie_ShorthandedAssists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_ShorthandedAssists.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_ShorthandedAssists.Location = new System.Drawing.Point(617, 144);
            this.lblGoalie_ShorthandedAssists.Name = "lblGoalie_ShorthandedAssists";
            this.lblGoalie_ShorthandedAssists.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_ShorthandedAssists.TabIndex = 136;
            // 
            // lblGoalie_ShorthandedGoals
            // 
            this.lblGoalie_ShorthandedGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_ShorthandedGoals.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_ShorthandedGoals.Location = new System.Drawing.Point(617, 117);
            this.lblGoalie_ShorthandedGoals.Name = "lblGoalie_ShorthandedGoals";
            this.lblGoalie_ShorthandedGoals.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_ShorthandedGoals.TabIndex = 135;
            // 
            // lblGoalie_PowerplayPoints
            // 
            this.lblGoalie_PowerplayPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_PowerplayPoints.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_PowerplayPoints.Location = new System.Drawing.Point(617, 90);
            this.lblGoalie_PowerplayPoints.Name = "lblGoalie_PowerplayPoints";
            this.lblGoalie_PowerplayPoints.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_PowerplayPoints.TabIndex = 134;
            // 
            // lblGoalie_PowerplayAssists
            // 
            this.lblGoalie_PowerplayAssists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_PowerplayAssists.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_PowerplayAssists.Location = new System.Drawing.Point(617, 63);
            this.lblGoalie_PowerplayAssists.Name = "lblGoalie_PowerplayAssists";
            this.lblGoalie_PowerplayAssists.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_PowerplayAssists.TabIndex = 133;
            // 
            // lblGoalie_PowerplayGoals
            // 
            this.lblGoalie_PowerplayGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_PowerplayGoals.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_PowerplayGoals.Location = new System.Drawing.Point(617, 36);
            this.lblGoalie_PowerplayGoals.Name = "lblGoalie_PowerplayGoals";
            this.lblGoalie_PowerplayGoals.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_PowerplayGoals.TabIndex = 132;
            // 
            // lblGoalie_HatTricks
            // 
            this.lblGoalie_HatTricks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_HatTricks.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_HatTricks.Location = new System.Drawing.Point(617, 9);
            this.lblGoalie_HatTricks.Name = "lblGoalie_HatTricks";
            this.lblGoalie_HatTricks.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_HatTricks.TabIndex = 131;
            // 
            // lblGoalie_PenaltyMinutes
            // 
            this.lblGoalie_PenaltyMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_PenaltyMinutes.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_PenaltyMinutes.Location = new System.Drawing.Point(380, 198);
            this.lblGoalie_PenaltyMinutes.Name = "lblGoalie_PenaltyMinutes";
            this.lblGoalie_PenaltyMinutes.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_PenaltyMinutes.TabIndex = 130;
            // 
            // lblGoalie_Shutouts
            // 
            this.lblGoalie_Shutouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Shutouts.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Shutouts.Location = new System.Drawing.Point(380, 171);
            this.lblGoalie_Shutouts.Name = "lblGoalie_Shutouts";
            this.lblGoalie_Shutouts.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_Shutouts.TabIndex = 129;
            // 
            // lblGoalie_GameTyingGoals
            // 
            this.lblGoalie_GameTyingGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_GameTyingGoals.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_GameTyingGoals.Location = new System.Drawing.Point(380, 144);
            this.lblGoalie_GameTyingGoals.Name = "lblGoalie_GameTyingGoals";
            this.lblGoalie_GameTyingGoals.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_GameTyingGoals.TabIndex = 128;
            // 
            // lblGoalie_GameWinningGoals
            // 
            this.lblGoalie_GameWinningGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_GameWinningGoals.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_GameWinningGoals.Location = new System.Drawing.Point(380, 117);
            this.lblGoalie_GameWinningGoals.Name = "lblGoalie_GameWinningGoals";
            this.lblGoalie_GameWinningGoals.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_GameWinningGoals.TabIndex = 127;
            // 
            // lblGoalie_OvertimeLosses
            // 
            this.lblGoalie_OvertimeLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_OvertimeLosses.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_OvertimeLosses.Location = new System.Drawing.Point(380, 90);
            this.lblGoalie_OvertimeLosses.Name = "lblGoalie_OvertimeLosses";
            this.lblGoalie_OvertimeLosses.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_OvertimeLosses.TabIndex = 126;
            // 
            // lblGoalie_OvertimeWins
            // 
            this.lblGoalie_OvertimeWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_OvertimeWins.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_OvertimeWins.Location = new System.Drawing.Point(380, 63);
            this.lblGoalie_OvertimeWins.Name = "lblGoalie_OvertimeWins";
            this.lblGoalie_OvertimeWins.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_OvertimeWins.TabIndex = 125;
            // 
            // lblGoalie_Losses
            // 
            this.lblGoalie_Losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Losses.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Losses.Location = new System.Drawing.Point(380, 36);
            this.lblGoalie_Losses.Name = "lblGoalie_Losses";
            this.lblGoalie_Losses.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_Losses.TabIndex = 124;
            // 
            // lblGoalie_Wins
            // 
            this.lblGoalie_Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Wins.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Wins.Location = new System.Drawing.Point(380, 9);
            this.lblGoalie_Wins.Name = "lblGoalie_Wins";
            this.lblGoalie_Wins.Size = new System.Drawing.Size(60, 23);
            this.lblGoalie_Wins.TabIndex = 123;
            // 
            // lblGoalie_Penalties
            // 
            this.lblGoalie_Penalties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Penalties.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Penalties.Location = new System.Drawing.Point(133, 198);
            this.lblGoalie_Penalties.Name = "lblGoalie_Penalties";
            this.lblGoalie_Penalties.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_Penalties.TabIndex = 122;
            // 
            // lblGoalie_GoalsAgainst
            // 
            this.lblGoalie_GoalsAgainst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_GoalsAgainst.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_GoalsAgainst.Location = new System.Drawing.Point(133, 171);
            this.lblGoalie_GoalsAgainst.Name = "lblGoalie_GoalsAgainst";
            this.lblGoalie_GoalsAgainst.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_GoalsAgainst.TabIndex = 121;
            // 
            // lblGoalie_Saves
            // 
            this.lblGoalie_Saves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Saves.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Saves.Location = new System.Drawing.Point(133, 144);
            this.lblGoalie_Saves.Name = "lblGoalie_Saves";
            this.lblGoalie_Saves.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_Saves.TabIndex = 120;
            // 
            // lblGoalie_ShotsAgainst
            // 
            this.lblGoalie_ShotsAgainst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_ShotsAgainst.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_ShotsAgainst.Location = new System.Drawing.Point(133, 117);
            this.lblGoalie_ShotsAgainst.Name = "lblGoalie_ShotsAgainst";
            this.lblGoalie_ShotsAgainst.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_ShotsAgainst.TabIndex = 119;
            // 
            // lblGoalie_Points
            // 
            this.lblGoalie_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Points.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Points.Location = new System.Drawing.Point(133, 90);
            this.lblGoalie_Points.Name = "lblGoalie_Points";
            this.lblGoalie_Points.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_Points.TabIndex = 118;
            // 
            // lblGoalie_Assists
            // 
            this.lblGoalie_Assists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Assists.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Assists.Location = new System.Drawing.Point(133, 63);
            this.lblGoalie_Assists.Name = "lblGoalie_Assists";
            this.lblGoalie_Assists.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_Assists.TabIndex = 117;
            // 
            // lblGoalie_Goals
            // 
            this.lblGoalie_Goals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_Goals.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_Goals.Location = new System.Drawing.Point(133, 36);
            this.lblGoalie_Goals.Name = "lblGoalie_Goals";
            this.lblGoalie_Goals.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_Goals.TabIndex = 116;
            // 
            // lblGoalie_GamesPlayed
            // 
            this.lblGoalie_GamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalie_GamesPlayed.ForeColor = System.Drawing.Color.White;
            this.lblGoalie_GamesPlayed.Location = new System.Drawing.Point(133, 9);
            this.lblGoalie_GamesPlayed.Name = "lblGoalie_GamesPlayed";
            this.lblGoalie_GamesPlayed.Size = new System.Drawing.Size(50, 23);
            this.lblGoalie_GamesPlayed.TabIndex = 115;
            // 
            // label47
            // 
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(447, 171);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(164, 23);
            this.label47.TabIndex = 114;
            this.label47.Text = "Short-handed Points:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label48
            // 
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(431, 144);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(180, 23);
            this.label48.TabIndex = 113;
            this.label48.Text = "Short-handed Assists:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label49
            // 
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(443, 117);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(168, 23);
            this.label49.TabIndex = 112;
            this.label49.Text = "Short-handed Goals:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label50
            // 
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(463, 90);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(148, 23);
            this.label50.TabIndex = 111;
            this.label50.Text = "Powerplay Points:";
            this.label50.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label51
            // 
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(465, 63);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(146, 23);
            this.label51.TabIndex = 110;
            this.label51.Text = "Powerplay Assists:";
            this.label51.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label52
            // 
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(473, 36);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(138, 23);
            this.label52.TabIndex = 109;
            this.label52.Text = "Powerplay Goals:";
            this.label52.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label53
            // 
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(511, 9);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(100, 23);
            this.label53.TabIndex = 108;
            this.label53.Text = "Hat Tricks:";
            this.label53.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label54
            // 
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(240, 198);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(134, 23);
            this.label54.TabIndex = 107;
            this.label54.Text = "Penalty Minutes:";
            this.label54.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label55
            // 
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(219, 171);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(155, 23);
            this.label55.TabIndex = 106;
            this.label55.Text = "Shutouts:";
            this.label55.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label56
            // 
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(219, 144);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(155, 23);
            this.label56.TabIndex = 105;
            this.label56.Text = "Game-tying Goals:";
            this.label56.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label57
            // 
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(201, 117);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(173, 23);
            this.label57.TabIndex = 104;
            this.label57.Text = "Game-winning Goals:";
            this.label57.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label58
            // 
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(215, 90);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(159, 23);
            this.label58.TabIndex = 103;
            this.label58.Text = "Overtime Losses:";
            this.label58.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label59
            // 
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(251, 63);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(123, 23);
            this.label59.TabIndex = 102;
            this.label59.Text = "Overtime Wins:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label60
            // 
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(247, 36);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(127, 23);
            this.label60.TabIndex = 101;
            this.label60.Text = "Losses:";
            this.label60.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label61
            // 
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(274, 9);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(100, 23);
            this.label61.TabIndex = 100;
            this.label61.Text = "Wins:";
            this.label61.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label62
            // 
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(27, 198);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(100, 23);
            this.label62.TabIndex = 99;
            this.label62.Text = "Penalties:";
            this.label62.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label63
            // 
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(8, 171);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(119, 23);
            this.label63.TabIndex = 98;
            this.label63.Text = "Goals Against:";
            this.label63.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label64
            // 
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(27, 144);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(100, 23);
            this.label64.TabIndex = 97;
            this.label64.Text = "Saves:";
            this.label64.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label65
            // 
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(8, 117);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(119, 23);
            this.label65.TabIndex = 96;
            this.label65.Text = "Shots Against:";
            this.label65.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label66
            // 
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(27, 90);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(100, 23);
            this.label66.TabIndex = 95;
            this.label66.Text = "Points:";
            this.label66.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label67
            // 
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(27, 63);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(100, 23);
            this.label67.TabIndex = 94;
            this.label67.Text = "Assists:";
            this.label67.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label68
            // 
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(27, 36);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(100, 23);
            this.label68.TabIndex = 93;
            this.label68.Text = "Goals:";
            this.label68.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label69
            // 
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(4, 9);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(123, 23);
            this.label69.TabIndex = 92;
            this.label69.Text = "Games Played:";
            this.label69.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbpgLeagueSettings
            // 
            this.tbpgLeagueSettings.Controls.Add(this.label29);
            this.tbpgLeagueSettings.Controls.Add(this.lstScoring);
            this.tbpgLeagueSettings.Location = new System.Drawing.Point(179, 4);
            this.tbpgLeagueSettings.Name = "tbpgLeagueSettings";
            this.tbpgLeagueSettings.Size = new System.Drawing.Size(1173, 641);
            this.tbpgLeagueSettings.TabIndex = 3;
            this.tbpgLeagueSettings.Text = "League Settings";
            this.tbpgLeagueSettings.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(399, 82);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(361, 46);
            this.label29.TabIndex = 1;
            this.label29.Text = "Scoring Categories";
            // 
            // lstScoring
            // 
            this.lstScoring.FormattingEnabled = true;
            this.lstScoring.ItemHeight = 20;
            this.lstScoring.Location = new System.Drawing.Point(353, 143);
            this.lstScoring.Name = "lstScoring";
            this.lstScoring.Size = new System.Drawing.Size(435, 364);
            this.lstScoring.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1356, 682);
            this.Controls.Add(this.tbctrlMain);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Fantasy Sports";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tbctrlMain.ResumeLayout(false);
            this.tbpgMyTeam.ResumeLayout(false);
            this.tbpgMyTeam.PerformLayout();
            this.tbpgStandings.ResumeLayout(false);
            this.tbpgStandings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).EndInit();
            this.tbpgSearchPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.tbctrlStats.ResumeLayout(false);
            this.tbpgPlayers.ResumeLayout(false);
            this.tbpgGoalies.ResumeLayout(false);
            this.tbpgLeagueSettings.ResumeLayout(false);
            this.tbpgLeagueSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuItmLogOut;
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.TabPage tbpgMyTeam;
        private System.Windows.Forms.TabPage tbpgStandings;
        private System.Windows.Forms.TabPage tbpgSearchPlayers;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.PictureBox picMugshot;
        private System.Windows.Forms.Label lblName;
        private TablessTabControl tbctrlStats;
        private System.Windows.Forms.TabPage tbpgPlayers;
        private System.Windows.Forms.Label lblPlayer_ShorthandedPoints;
        private System.Windows.Forms.Label lblPlayer_ShorthandedAssists;
        private System.Windows.Forms.Label lblPlayer_ShorthandedGoals;
        private System.Windows.Forms.Label lblPlayer_PowerplayPoints;
        private System.Windows.Forms.Label lblPlayer_PowerplayAssists;
        private System.Windows.Forms.Label lblPlayer_PowerplayGoals;
        private System.Windows.Forms.Label lblPlayer_HatTricks;
        private System.Windows.Forms.Label lblPlayer_PenaltyMinutes;
        private System.Windows.Forms.Label lblPlayer_ShotPercentage;
        private System.Windows.Forms.Label lblPlayer_GameTyingGoals;
        private System.Windows.Forms.Label lblPlayer_GameWinningGoals;
        private System.Windows.Forms.Label lblPlayer_FaceoffPercent;
        private System.Windows.Forms.Label lblPlayer_FaceoffLosses;
        private System.Windows.Forms.Label lblPlayer_FaceoffWins;
        private System.Windows.Forms.Label lblPlayer_Faceoffs;
        private System.Windows.Forms.Label lblPlayer_Penalties;
        private System.Windows.Forms.Label lblPlayer_Hits;
        private System.Windows.Forms.Label lblPlayer_Shots;
        private System.Windows.Forms.Label lblPlayer_PlusMinus;
        private System.Windows.Forms.Label lblPlayer_Points;
        private System.Windows.Forms.Label lblPlayer_Assists;
        private System.Windows.Forms.Label lblPlayer_Goals;
        private System.Windows.Forms.Label lblPlayer_GamesPlayed;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpgGoalies;
        private System.Windows.Forms.Label lblGoalie_ShorthandedPoints;
        private System.Windows.Forms.Label lblGoalie_ShorthandedAssists;
        private System.Windows.Forms.Label lblGoalie_ShorthandedGoals;
        private System.Windows.Forms.Label lblGoalie_PowerplayPoints;
        private System.Windows.Forms.Label lblGoalie_PowerplayAssists;
        private System.Windows.Forms.Label lblGoalie_PowerplayGoals;
        private System.Windows.Forms.Label lblGoalie_HatTricks;
        private System.Windows.Forms.Label lblGoalie_PenaltyMinutes;
        private System.Windows.Forms.Label lblGoalie_Shutouts;
        private System.Windows.Forms.Label lblGoalie_GameTyingGoals;
        private System.Windows.Forms.Label lblGoalie_GameWinningGoals;
        private System.Windows.Forms.Label lblGoalie_OvertimeLosses;
        private System.Windows.Forms.Label lblGoalie_OvertimeWins;
        private System.Windows.Forms.Label lblGoalie_Losses;
        private System.Windows.Forms.Label lblGoalie_Wins;
        private System.Windows.Forms.Label lblGoalie_Penalties;
        private System.Windows.Forms.Label lblGoalie_GoalsAgainst;
        private System.Windows.Forms.Label lblGoalie_Saves;
        private System.Windows.Forms.Label lblGoalie_ShotsAgainst;
        private System.Windows.Forms.Label lblGoalie_Points;
        private System.Windows.Forms.Label lblGoalie_Assists;
        private System.Windows.Forms.Label lblGoalie_Goals;
        private System.Windows.Forms.Label lblGoalie_GamesPlayed;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label lblGoalie_SavePercentage;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label lblGoalie_GoalsAgainstAverage;
        private System.Windows.Forms.Label lblGoalie_MinutesPlayed;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label lblGoalie_CreditForGame;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblGoalie_GamesStarted;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.ListBox lstMyTeam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox lstOtherTeam;
        private System.Windows.Forms.ComboBox cmboOtherTeam;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgvStandings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.TabPage tbpgLeagueSettings;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListBox lstScoring;
    }
}