namespace FantasySportsApplication
{
    partial class frmCreateLeague
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeagueName = new System.Windows.Forms.TextBox();
            this.txtLeaguePassword = new System.Windows.Forms.TextBox();
            this.cmboSport = new System.Windows.Forms.ComboBox();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.tmrSuccess = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbctrlStats = new System.Windows.Forms.TabControl();
            this.tbpgPlayerStats = new System.Windows.Forms.TabPage();
            this.chklstPlayerStats = new System.Windows.Forms.CheckedListBox();
            this.tbpgGoalieStats = new System.Windows.Forms.TabPage();
            this.chklstGoalieStats = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numD = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numRW = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numLW = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdPublic = new System.Windows.Forms.RadioButton();
            this.rdPrivate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbctrlStats.SuspendLayout();
            this.tbpgPlayerStats.SuspendLayout();
            this.tbpgGoalieStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "League Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "League Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sport:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Teams:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLeagueName
            // 
            this.txtLeagueName.Location = new System.Drawing.Point(207, 17);
            this.txtLeagueName.MaxLength = 30;
            this.txtLeagueName.Name = "txtLeagueName";
            this.txtLeagueName.Size = new System.Drawing.Size(184, 26);
            this.txtLeagueName.TabIndex = 0;
            // 
            // txtLeaguePassword
            // 
            this.txtLeaguePassword.Enabled = false;
            this.txtLeaguePassword.Location = new System.Drawing.Point(207, 78);
            this.txtLeaguePassword.MaxLength = 30;
            this.txtLeaguePassword.Name = "txtLeaguePassword";
            this.txtLeaguePassword.Size = new System.Drawing.Size(184, 26);
            this.txtLeaguePassword.TabIndex = 1;
            // 
            // cmboSport
            // 
            this.cmboSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSport.FormattingEnabled = true;
            this.cmboSport.Items.AddRange(new object[] {
            "NHL"});
            this.cmboSport.Location = new System.Drawing.Point(208, 119);
            this.cmboSport.Name = "cmboSport";
            this.cmboSport.Size = new System.Drawing.Size(183, 28);
            this.cmboSport.TabIndex = 2;
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMaxPlayers.Location = new System.Drawing.Point(206, 33);
            this.numMaxPlayers.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMaxPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(183, 26);
            this.numMaxPlayers.TabIndex = 3;
            this.numMaxPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMaxPlayers.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(94, 889);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 32);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 889);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 836);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(415, 50);
            this.lblError.TabIndex = 12;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrError
            // 
            this.tmrError.Interval = 50;
            this.tmrError.Tick += new System.EventHandler(this.tmrError_Tick);
            // 
            // tmrSuccess
            // 
            this.tmrSuccess.Tick += new System.EventHandler(this.tmrSuccess_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbctrlStats);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numG);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numRW);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numLW);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMaxPlayers);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 606);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "League Rules";
            // 
            // tbctrlStats
            // 
            this.tbctrlStats.Controls.Add(this.tbpgPlayerStats);
            this.tbctrlStats.Controls.Add(this.tbpgGoalieStats);
            this.tbctrlStats.Location = new System.Drawing.Point(6, 233);
            this.tbctrlStats.Name = "tbctrlStats";
            this.tbctrlStats.SelectedIndex = 0;
            this.tbctrlStats.Size = new System.Drawing.Size(389, 367);
            this.tbctrlStats.TabIndex = 14;
            // 
            // tbpgPlayerStats
            // 
            this.tbpgPlayerStats.BackColor = System.Drawing.Color.Black;
            this.tbpgPlayerStats.Controls.Add(this.chklstPlayerStats);
            this.tbpgPlayerStats.ForeColor = System.Drawing.Color.White;
            this.tbpgPlayerStats.Location = new System.Drawing.Point(4, 29);
            this.tbpgPlayerStats.Name = "tbpgPlayerStats";
            this.tbpgPlayerStats.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgPlayerStats.Size = new System.Drawing.Size(381, 334);
            this.tbpgPlayerStats.TabIndex = 0;
            this.tbpgPlayerStats.Text = "Player Stats";
            // 
            // chklstPlayerStats
            // 
            this.chklstPlayerStats.BackColor = System.Drawing.Color.Black;
            this.chklstPlayerStats.ForeColor = System.Drawing.Color.White;
            this.chklstPlayerStats.FormattingEnabled = true;
            this.chklstPlayerStats.Items.AddRange(new object[] {
            "Assists",
            "Faceoff Losses",
            "Faceoff Percentage",
            "Faceoff Wins",
            "Faceoffs",
            "Game-Tying Goals",
            "Game-Winning Goals",
            "Games Played",
            "Goals",
            "Hat Tricks",
            "Hits",
            "Penalties",
            "Penalty Minutes",
            "Plus/Minus",
            "Points",
            "Powerplay Assists",
            "Powerplay Goals",
            "Powerplay Points",
            "Shorthanded Assists",
            "Shorthanded Goals",
            "Shorthanded Points",
            "Shot Percentage",
            "Shots"});
            this.chklstPlayerStats.Location = new System.Drawing.Point(19, 18);
            this.chklstPlayerStats.Name = "chklstPlayerStats";
            this.chklstPlayerStats.Size = new System.Drawing.Size(343, 298);
            this.chklstPlayerStats.Sorted = true;
            this.chklstPlayerStats.TabIndex = 0;
            // 
            // tbpgGoalieStats
            // 
            this.tbpgGoalieStats.BackColor = System.Drawing.Color.Black;
            this.tbpgGoalieStats.Controls.Add(this.chklstGoalieStats);
            this.tbpgGoalieStats.Location = new System.Drawing.Point(4, 29);
            this.tbpgGoalieStats.Name = "tbpgGoalieStats";
            this.tbpgGoalieStats.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgGoalieStats.Size = new System.Drawing.Size(381, 334);
            this.tbpgGoalieStats.TabIndex = 1;
            this.tbpgGoalieStats.Text = "Goalie Stats";
            // 
            // chklstGoalieStats
            // 
            this.chklstGoalieStats.BackColor = System.Drawing.Color.Black;
            this.chklstGoalieStats.ForeColor = System.Drawing.Color.White;
            this.chklstGoalieStats.FormattingEnabled = true;
            this.chklstGoalieStats.Items.AddRange(new object[] {
            "Credit For Game",
            "Games Started",
            "Goals Against",
            "Goals Against Average",
            "Losses",
            "Minutes Played",
            "Overtime Losses",
            "Overtime Wins",
            "Save Percentage",
            "Saves",
            "Shots Against",
            "Shutouts",
            "Wins"});
            this.chklstGoalieStats.Location = new System.Drawing.Point(19, 18);
            this.chklstGoalieStats.Name = "chklstGoalieStats";
            this.chklstGoalieStats.Size = new System.Drawing.Size(343, 298);
            this.chklstGoalieStats.Sorted = true;
            this.chklstGoalieStats.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Max G per Team:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(205, 193);
            this.numG.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(183, 26);
            this.numG.TabIndex = 13;
            this.numG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numG.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Max D per Team:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numD
            // 
            this.numD.Location = new System.Drawing.Point(205, 161);
            this.numD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numD.Name = "numD";
            this.numD.Size = new System.Drawing.Size(183, 26);
            this.numD.TabIndex = 11;
            this.numD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Max RW per Team:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numRW
            // 
            this.numRW.Location = new System.Drawing.Point(205, 129);
            this.numRW.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numRW.Name = "numRW";
            this.numRW.Size = new System.Drawing.Size(183, 26);
            this.numRW.TabIndex = 9;
            this.numRW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRW.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max LW per Team:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numLW
            // 
            this.numLW.Location = new System.Drawing.Point(206, 97);
            this.numLW.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numLW.Name = "numLW";
            this.numLW.Size = new System.Drawing.Size(183, 26);
            this.numLW.TabIndex = 7;
            this.numLW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLW.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max C per Team:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(206, 65);
            this.numC.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(183, 26);
            this.numC.TabIndex = 5;
            this.numC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numC.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(231, 779);
            this.txtTeamName.MaxLength = 30;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(184, 26);
            this.txtTeamName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 782);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "My Team Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Availability:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdPublic
            // 
            this.rdPublic.Checked = true;
            this.rdPublic.ForeColor = System.Drawing.Color.White;
            this.rdPublic.Location = new System.Drawing.Point(208, 48);
            this.rdPublic.Name = "rdPublic";
            this.rdPublic.Size = new System.Drawing.Size(86, 24);
            this.rdPublic.TabIndex = 17;
            this.rdPublic.TabStop = true;
            this.rdPublic.Text = "Public";
            this.rdPublic.UseVisualStyleBackColor = true;
            // 
            // rdPrivate
            // 
            this.rdPrivate.ForeColor = System.Drawing.Color.White;
            this.rdPrivate.Location = new System.Drawing.Point(300, 48);
            this.rdPrivate.Name = "rdPrivate";
            this.rdPrivate.Size = new System.Drawing.Size(114, 24);
            this.rdPrivate.TabIndex = 18;
            this.rdPrivate.Text = "Private";
            this.rdPrivate.UseVisualStyleBackColor = true;
            this.rdPrivate.CheckedChanged += new System.EventHandler(this.rdPrivate_CheckedChanged);
            // 
            // frmCreateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(451, 934);
            this.Controls.Add(this.rdPrivate);
            this.Controls.Add(this.rdPublic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmboSport);
            this.Controls.Add(this.txtLeaguePassword);
            this.Controls.Add(this.txtLeagueName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCreateLeague";
            this.Text = "Create a League";
            this.Load += new System.EventHandler(this.frmCreateLeague_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tbctrlStats.ResumeLayout(false);
            this.tbpgPlayerStats.ResumeLayout(false);
            this.tbpgGoalieStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeagueName;
        private System.Windows.Forms.TextBox txtLeaguePassword;
        private System.Windows.Forms.ComboBox cmboSport;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrError;
        private System.Windows.Forms.Timer tmrSuccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numRW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numLW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdPublic;
        private System.Windows.Forms.RadioButton rdPrivate;
        private System.Windows.Forms.TabControl tbctrlStats;
        private System.Windows.Forms.TabPage tbpgPlayerStats;
        private System.Windows.Forms.CheckedListBox chklstPlayerStats;
        private System.Windows.Forms.TabPage tbpgGoalieStats;
        private System.Windows.Forms.CheckedListBox chklstGoalieStats;
    }
}