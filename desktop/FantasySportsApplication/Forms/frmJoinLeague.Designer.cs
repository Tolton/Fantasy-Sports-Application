namespace FantasySportsApplication.Forms
{
    partial class frmJoinLeague
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrSuccess = new System.Windows.Forms.Timer(this.components);
            this.tmrFailure = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.dgvLeagues = new System.Windows.Forms.DataGridView();
            this.colLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeagueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoin = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colLeagueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagues)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSuccess
            // 
            this.tmrSuccess.Tick += new System.EventHandler(this.tmrSuccess_Tick);
            // 
            // tmrFailure
            // 
            this.tmrFailure.Interval = 50;
            this.tmrFailure.Tick += new System.EventHandler(this.tmrFailure_Tick);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(264, 324);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(616, 27);
            this.lblError.TabIndex = 25;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLeagues
            // 
            this.dgvLeagues.AllowUserToAddRows = false;
            this.dgvLeagues.AllowUserToDeleteRows = false;
            this.dgvLeagues.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeagues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeagues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocked,
            this.colLeagueName,
            this.colType,
            this.colTeams,
            this.colJoined,
            this.colJoin,
            this.colLeagueID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeagues.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLeagues.EnableHeadersVisualStyles = false;
            this.dgvLeagues.Location = new System.Drawing.Point(70, 30);
            this.dgvLeagues.MultiSelect = false;
            this.dgvLeagues.Name = "dgvLeagues";
            this.dgvLeagues.ReadOnly = true;
            this.dgvLeagues.RowHeadersVisible = false;
            this.dgvLeagues.RowTemplate.Height = 28;
            this.dgvLeagues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeagues.Size = new System.Drawing.Size(1041, 248);
            this.dgvLeagues.TabIndex = 26;
            this.dgvLeagues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeagues_CellContentClick);
            // 
            // colLocked
            // 
            this.colLocked.HeaderText = "";
            this.colLocked.Name = "colLocked";
            this.colLocked.ReadOnly = true;
            this.colLocked.Width = 30;
            // 
            // colLeagueName
            // 
            this.colLeagueName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLeagueName.HeaderText = "League Name";
            this.colLeagueName.Name = "colLeagueName";
            this.colLeagueName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "League Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 150;
            // 
            // colTeams
            // 
            this.colTeams.HeaderText = "Registered Teams";
            this.colTeams.Name = "colTeams";
            this.colTeams.ReadOnly = true;
            this.colTeams.Width = 150;
            // 
            // colJoined
            // 
            this.colJoined.HeaderText = "Availability";
            this.colJoined.Name = "colJoined";
            this.colJoined.ReadOnly = true;
            this.colJoined.Width = 150;
            // 
            // colJoin
            // 
            this.colJoin.HeaderText = "";
            this.colJoin.Name = "colJoin";
            this.colJoin.ReadOnly = true;
            this.colJoin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colJoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colLeagueID
            // 
            this.colLeagueID.HeaderText = "LeagueID";
            this.colLeagueID.Name = "colLeagueID";
            this.colLeagueID.ReadOnly = true;
            this.colLeagueID.Visible = false;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(443, 284);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(264, 26);
            this.txtTeamName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Team Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmJoinLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1175, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.dgvLeagues);
            this.Controls.Add(this.lblError);
            this.Name = "frmJoinLeague";
            this.Text = "frmJoinLeague";
            this.Load += new System.EventHandler(this.frmJoinLeague_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrSuccess;
        private System.Windows.Forms.Timer tmrFailure;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvLeagues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeagueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoined;
        private System.Windows.Forms.DataGridViewButtonColumn colJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeagueID;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
    }
}