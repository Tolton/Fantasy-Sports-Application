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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblMyTeam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picMugshot = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).BeginInit();
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
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.DimGray;
            this.pnlSidebar.Controls.Add(this.lblMyTeam);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 39);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(255, 646);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblMyTeam
            // 
            this.lblMyTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMyTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyTeam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyTeam.ForeColor = System.Drawing.Color.White;
            this.lblMyTeam.Location = new System.Drawing.Point(0, 2);
            this.lblMyTeam.Name = "lblMyTeam";
            this.lblMyTeam.Size = new System.Drawing.Size(255, 50);
            this.lblMyTeam.TabIndex = 0;
            this.lblMyTeam.Text = "My Team";
            this.lblMyTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMyTeam.MouseEnter += new System.EventHandler(this.lblMyTeam_MouseEnter);
            this.lblMyTeam.MouseLeave += new System.EventHandler(this.lblMyTeam_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPlayers);
            this.groupBox1.Location = new System.Drawing.Point(270, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 20;
            this.lstPlayers.Location = new System.Drawing.Point(9, 25);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(384, 144);
            this.lstPlayers.TabIndex = 0;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToOrderColumns = true;
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosition,
            this.colName,
            this.colGoals,
            this.colAssists,
            this.colPoints});
            this.dgvPlayers.Location = new System.Drawing.Point(270, 376);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowTemplate.Height = 28;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(1030, 294);
            this.dgvPlayers.TabIndex = 3;
            this.dgvPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellClick);
            this.dgvPlayers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellDoubleClick);
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colGoals
            // 
            this.colGoals.HeaderText = "Goals";
            this.colGoals.Name = "colGoals";
            this.colGoals.ReadOnly = true;
            // 
            // colAssists
            // 
            this.colAssists.HeaderText = "Assists";
            this.colAssists.Name = "colAssists";
            this.colAssists.ReadOnly = true;
            // 
            // colPoints
            // 
            this.colPoints.HeaderText = "Points";
            this.colPoints.Name = "colPoints";
            this.colPoints.ReadOnly = true;
            // 
            // picMugshot
            // 
            this.picMugshot.ErrorImage = global::FantasySportsApplication.Properties.Resources.UnknownMugshot;
            this.picMugshot.InitialImage = global::FantasySportsApplication.Properties.Resources.UnknownMugshot;
            this.picMugshot.Location = new System.Drawing.Point(1002, 59);
            this.picMugshot.Name = "picMugshot";
            this.picMugshot.Size = new System.Drawing.Size(286, 299);
            this.picMugshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMugshot.TabIndex = 4;
            this.picMugshot.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1300, 682);
            this.Controls.Add(this.picMugshot);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Fantasy Sports";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblMyTeam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssists;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
        private System.Windows.Forms.PictureBox picMugshot;
    }
}