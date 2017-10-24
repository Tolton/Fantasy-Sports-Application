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
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.tmrSuccess = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "League Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sport:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Players:";
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
            this.txtLeaguePassword.Location = new System.Drawing.Point(207, 49);
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
            this.cmboSport.Location = new System.Drawing.Point(208, 81);
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
            this.numMaxPlayers.Location = new System.Drawing.Point(208, 119);
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
            this.btnCreate.Location = new System.Drawing.Point(98, 259);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 32);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(207, 165);
            this.txtTeamName.MaxLength = 30;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(184, 26);
            this.txtTeamName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "My Team Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 206);
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
            // frmCreateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(443, 314);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numMaxPlayers);
            this.Controls.Add(this.cmboSport);
            this.Controls.Add(this.txtLeaguePassword);
            this.Controls.Add(this.txtLeagueName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCreateLeague";
            this.Text = "Create a League";
            this.Load += new System.EventHandler(this.frmCreateLeague_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
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
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrError;
        private System.Windows.Forms.Timer tmrSuccess;
    }
}