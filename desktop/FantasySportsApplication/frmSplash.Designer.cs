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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tmrLoginFail = new System.Windows.Forms.Timer(this.components);
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnFootball = new System.Windows.Forms.Button();
            this.btnHockey = new System.Windows.Forms.Button();
            this.btnBaseball = new System.Windows.Forms.Button();
            this.btnBasketball = new System.Windows.Forms.Button();
            this.txtUsername = new FantasySportsApplication.PlaceHolderTextBox();
            this.txtPassword = new FantasySportsApplication.PlaceHolderTextBox();
            this.pnlLogin.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
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
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 1);
            this.label1.TabIndex = 3;
            // 
            // picExit
            // 
            this.picExit.Image = global::FantasySportsApplication.Properties.Resources.exit_normal;
            this.picExit.Location = new System.Drawing.Point(803, 608);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(60, 80);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseClick);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // btnFootball
            // 
            this.btnFootball.Enabled = false;
            this.btnFootball.Location = new System.Drawing.Point(68, 126);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(359, 200);
            this.btnFootball.TabIndex = 4;
            this.btnFootball.Text = "Football";
            this.btnFootball.UseVisualStyleBackColor = true;
            // 
            // btnHockey
            // 
            this.btnHockey.Enabled = false;
            this.btnHockey.Location = new System.Drawing.Point(433, 126);
            this.btnHockey.Name = "btnHockey";
            this.btnHockey.Size = new System.Drawing.Size(359, 200);
            this.btnHockey.TabIndex = 5;
            this.btnHockey.Text = "Hockey";
            this.btnHockey.UseVisualStyleBackColor = true;
            this.btnHockey.Click += new System.EventHandler(this.btnHockey_Click);
            // 
            // btnBaseball
            // 
            this.btnBaseball.Enabled = false;
            this.btnBaseball.Location = new System.Drawing.Point(68, 332);
            this.btnBaseball.Name = "btnBaseball";
            this.btnBaseball.Size = new System.Drawing.Size(359, 200);
            this.btnBaseball.TabIndex = 6;
            this.btnBaseball.Text = "Baseball";
            this.btnBaseball.UseVisualStyleBackColor = true;
            // 
            // btnBasketball
            // 
            this.btnBasketball.Enabled = false;
            this.btnBasketball.Location = new System.Drawing.Point(433, 332);
            this.btnBasketball.Name = "btnBasketball";
            this.btnBasketball.Size = new System.Drawing.Size(359, 200);
            this.btnBasketball.TabIndex = 7;
            this.btnBasketball.Text = "Basketball";
            this.btnBasketball.UseVisualStyleBackColor = true;
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
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 700);
            this.Controls.Add(this.btnBasketball);
            this.Controls.Add(this.btnBaseball);
            this.Controls.Add(this.btnHockey);
            this.Controls.Add(this.btnFootball);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy Sports";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFootball;
        private System.Windows.Forms.Button btnHockey;
        private System.Windows.Forms.Button btnBaseball;
        private System.Windows.Forms.Button btnBasketball;
    }
}

