namespace FantasySportsApplication
{
    partial class frmSplash
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginFail = new System.Windows.Forms.Label();
            this.txtUsername = new FantasySportsApplication.PlaceHolderTextBox();
            this.txtPassword = new FantasySportsApplication.PlaceHolderTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.tmrLoginFail = new System.Windows.Forms.Timer(this.components);
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblLoginFail);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(12, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(851, 44);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblLoginFail
            // 
            this.lblLoginFail.AutoSize = true;
            this.lblLoginFail.ForeColor = System.Drawing.Color.Black;
            this.lblLoginFail.Location = new System.Drawing.Point(6, 13);
            this.lblLoginFail.Name = "lblLoginFail";
            this.lblLoginFail.Size = new System.Drawing.Size(342, 20);
            this.lblLoginFail.TabIndex = 3;
            this.lblLoginFail.Text = "Incorrect username/password, please try again.";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(362, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceHolderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(143, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(509, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(143, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(738, 8);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 32);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(657, 8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picExit
            // 
            this.picExit.Image = global::FantasySportsApplication.Properties.Resources.exit_normal;
            this.picExit.Location = new System.Drawing.Point(785, 587);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(75, 100);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseClick);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // tmrLoginFail
            // 
            this.tmrLoginFail.Interval = 50;
            this.tmrLoginFail.Tick += new System.EventHandler(this.tmrLoginFail_Tick);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.btnLogout);
            this.pnlWelcome.Location = new System.Drawing.Point(12, 12);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(851, 44);
            this.pnlWelcome.TabIndex = 2;
            this.pnlWelcome.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(10, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(719, 23);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, username!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(738, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 32);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 699);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy Sports";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.pnlWelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private PlaceHolderTextBox txtPassword;
        private PlaceHolderTextBox txtUsername;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblLoginFail;
        private System.Windows.Forms.Timer tmrLoginFail;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}

