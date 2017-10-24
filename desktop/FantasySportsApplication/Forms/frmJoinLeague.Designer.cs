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
            this.lblError = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtLeaguePassword = new System.Windows.Forms.TextBox();
            this.txtLeagueName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrSuccess = new System.Windows.Forms.Timer(this.components);
            this.tmrFailure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(5, 125);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(415, 50);
            this.lblError.TabIndex = 25;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(196, 86);
            this.txtTeamName.MaxLength = 30;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(184, 26);
            this.txtTeamName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "My Team Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 195);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 32);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Join";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtLeaguePassword
            // 
            this.txtLeaguePassword.Location = new System.Drawing.Point(196, 54);
            this.txtLeaguePassword.MaxLength = 30;
            this.txtLeaguePassword.Name = "txtLeaguePassword";
            this.txtLeaguePassword.Size = new System.Drawing.Size(184, 26);
            this.txtLeaguePassword.TabIndex = 15;
            // 
            // txtLeagueName
            // 
            this.txtLeagueName.Location = new System.Drawing.Point(196, 22);
            this.txtLeagueName.MaxLength = 30;
            this.txtLeagueName.Name = "txtLeagueName";
            this.txtLeagueName.Size = new System.Drawing.Size(184, 26);
            this.txtLeagueName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "League Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "League Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tmrFailure
            // 
            this.tmrFailure.Interval = 50;
            // 
            // frmJoinLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(421, 249);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtLeaguePassword);
            this.Controls.Add(this.txtLeagueName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJoinLeague";
            this.Text = "frmJoinLeague";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtLeaguePassword;
        private System.Windows.Forms.TextBox txtLeagueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSuccess;
        private System.Windows.Forms.Timer tmrFailure;
    }
}