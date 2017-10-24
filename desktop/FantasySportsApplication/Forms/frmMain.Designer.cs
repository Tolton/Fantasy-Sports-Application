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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbctrlMain = new System.Windows.Forms.TabControl();
            this.tbpgMyTeam = new System.Windows.Forms.TabPage();
            this.tbpgStandings = new System.Windows.Forms.TabPage();
            this.tbpgSearchPlayers = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tbctrlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.editToolStripMenuItem.Text = "Account";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbctrlMain.Controls.Add(this.tbpgMyTeam);
            this.tbctrlMain.Controls.Add(this.tbpgStandings);
            this.tbctrlMain.Controls.Add(this.tbpgSearchPlayers);
            this.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbctrlMain.ItemSize = new System.Drawing.Size(40, 200);
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
            this.tbpgMyTeam.Location = new System.Drawing.Point(204, 4);
            this.tbpgMyTeam.Name = "tbpgMyTeam";
            this.tbpgMyTeam.Size = new System.Drawing.Size(1092, 641);
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
            this.tbpgSearchPlayers.Location = new System.Drawing.Point(204, 4);
            this.tbpgSearchPlayers.Name = "tbpgSearchPlayers";
            this.tbpgSearchPlayers.Size = new System.Drawing.Size(1092, 641);
            this.tbpgSearchPlayers.TabIndex = 2;
            this.tbpgSearchPlayers.Text = "Search Players";
            this.tbpgSearchPlayers.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1300, 682);
            this.Controls.Add(this.tbctrlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Fantasy Sports";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbctrlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.TabPage tbpgMyTeam;
        private System.Windows.Forms.TabPage tbpgStandings;
        private System.Windows.Forms.TabPage tbpgSearchPlayers;
    }
}