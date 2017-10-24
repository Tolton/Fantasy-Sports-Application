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
            this.tbpgStandings = new System.Windows.Forms.TabPage();
            this.tbpgSearchPlayers = new System.Windows.Forms.TabPage();
            this.picMugshot = new System.Windows.Forms.PictureBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.tbctrlMain.SuspendLayout();
            this.tbpgSearchPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
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
            this.mnuMain.Size = new System.Drawing.Size(1300, 33);
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
            this.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbctrlMain.ItemSize = new System.Drawing.Size(40, 175);
            this.tbctrlMain.Location = new System.Drawing.Point(0, 33);
            this.tbctrlMain.Multiline = true;
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(1300, 649);
            this.tbctrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbctrlMain.TabIndex = 1;
            this.tbctrlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbctrlMain_DrawItem);
            // 
            // tbpgMyTeam
            // 
            this.tbpgMyTeam.Location = new System.Drawing.Point(179, 4);
            this.tbpgMyTeam.Name = "tbpgMyTeam";
            this.tbpgMyTeam.Size = new System.Drawing.Size(1117, 641);
            this.tbpgMyTeam.TabIndex = 0;
            this.tbpgMyTeam.Text = "My Team";
            this.tbpgMyTeam.UseVisualStyleBackColor = true;
            // 
            // tbpgStandings
            // 
            this.tbpgStandings.Location = new System.Drawing.Point(204, 4);
            this.tbpgStandings.Name = "tbpgStandings";
            this.tbpgStandings.Size = new System.Drawing.Size(1092, 641);
            this.tbpgStandings.TabIndex = 1;
            this.tbpgStandings.Text = "Standings";
            this.tbpgStandings.UseVisualStyleBackColor = true;
            // 
            // tbpgSearchPlayers
            // 
            this.tbpgSearchPlayers.Controls.Add(this.lblName);
            this.tbpgSearchPlayers.Controls.Add(this.picMugshot);
            this.tbpgSearchPlayers.Controls.Add(this.dgvPlayers);
            this.tbpgSearchPlayers.Location = new System.Drawing.Point(179, 4);
            this.tbpgSearchPlayers.Name = "tbpgSearchPlayers";
            this.tbpgSearchPlayers.Size = new System.Drawing.Size(1117, 641);
            this.tbpgSearchPlayers.TabIndex = 2;
            this.tbpgSearchPlayers.Text = "Search Players";
            this.tbpgSearchPlayers.UseVisualStyleBackColor = true;
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
            this.dgvPlayers.Location = new System.Drawing.Point(0, 380);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowTemplate.Height = 28;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(1117, 261);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_RowEnter);
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(374, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(623, 42);
            this.lblName.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1300, 682);
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
            this.tbpgSearchPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
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
    }
}