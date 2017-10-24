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
            this.tmrLoginFail = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.tbctrlLogin = new FantasySportsApplication.TablessTabControl();
            this.tbpgSignedOut = new System.Windows.Forms.TabPage();
            this.lblLoginFail = new System.Windows.Forms.Label();
            this.txtUsername = new FantasySportsApplication.PlaceHolderTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new FantasySportsApplication.PlaceHolderTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbpgSignedIn = new System.Windows.Forms.TabPage();
            this.picJoin = new System.Windows.Forms.PictureBox();
            this.picCreate = new System.Windows.Forms.PictureBox();
            this.tbctrlChooseLeague = new FantasySportsApplication.TablessTabControl();
            this.tbpgChooseLeague = new System.Windows.Forms.TabPage();
            this.btnEnterLeague = new System.Windows.Forms.Button();
            this.cmboLeague = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpgNoLeagues = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.tbctrlLogin.SuspendLayout();
            this.tbpgSignedOut.SuspendLayout();
            this.tbpgSignedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreate)).BeginInit();
            this.tbctrlChooseLeague.SuspendLayout();
            this.tbpgChooseLeague.SuspendLayout();
            this.tbpgNoLeagues.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrLoginFail
            // 
            this.tmrLoginFail.Interval = 50;
            this.tmrLoginFail.Tick += new System.EventHandler(this.tmrLoginFail_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 1);
            this.label1.TabIndex = 5;
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::FantasySportsApplication.Properties.Resources.exit_normal;
            this.picExit.Location = new System.Drawing.Point(810, 261);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(60, 80);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 6;
            this.picExit.TabStop = false;
            this.picExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseClick);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // tbctrlLogin
            // 
            this.tbctrlLogin.Controls.Add(this.tbpgSignedOut);
            this.tbctrlLogin.Controls.Add(this.tbpgSignedIn);
            this.tbctrlLogin.Location = new System.Drawing.Point(14, 5);
            this.tbctrlLogin.Multiline = true;
            this.tbctrlLogin.Name = "tbctrlLogin";
            this.tbctrlLogin.SelectedIndex = 0;
            this.tbctrlLogin.Size = new System.Drawing.Size(851, 336);
            this.tbctrlLogin.TabIndex = 4;
            // 
            // tbpgSignedOut
            // 
            this.tbpgSignedOut.BackColor = System.Drawing.Color.Black;
            this.tbpgSignedOut.Controls.Add(this.lblLoginFail);
            this.tbpgSignedOut.Controls.Add(this.txtUsername);
            this.tbpgSignedOut.Controls.Add(this.btnRegister);
            this.tbpgSignedOut.Controls.Add(this.txtPassword);
            this.tbpgSignedOut.Controls.Add(this.btnLogin);
            this.tbpgSignedOut.Location = new System.Drawing.Point(4, 29);
            this.tbpgSignedOut.Name = "tbpgSignedOut";
            this.tbpgSignedOut.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSignedOut.Size = new System.Drawing.Size(843, 303);
            this.tbpgSignedOut.TabIndex = 0;
            this.tbpgSignedOut.Text = "SignedOut";
            // 
            // lblLoginFail
            // 
            this.lblLoginFail.AutoSize = true;
            this.lblLoginFail.ForeColor = System.Drawing.Color.Black;
            this.lblLoginFail.Location = new System.Drawing.Point(6, 8);
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
            this.txtUsername.Location = new System.Drawing.Point(350, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceHolderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(143, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(729, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 32);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(500, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(143, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(650, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbpgSignedIn
            // 
            this.tbpgSignedIn.BackColor = System.Drawing.Color.Black;
            this.tbpgSignedIn.Controls.Add(this.picJoin);
            this.tbpgSignedIn.Controls.Add(this.picCreate);
            this.tbpgSignedIn.Controls.Add(this.tbctrlChooseLeague);
            this.tbpgSignedIn.Controls.Add(this.btnLogout);
            this.tbpgSignedIn.Controls.Add(this.lblWelcome);
            this.tbpgSignedIn.Location = new System.Drawing.Point(4, 29);
            this.tbpgSignedIn.Name = "tbpgSignedIn";
            this.tbpgSignedIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSignedIn.Size = new System.Drawing.Size(843, 303);
            this.tbpgSignedIn.TabIndex = 1;
            this.tbpgSignedIn.Text = "SignedIn";
            // 
            // picJoin
            // 
            this.picJoin.BackColor = System.Drawing.Color.White;
            this.picJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picJoin.Image = global::FantasySportsApplication.Properties.Resources.join;
            this.picJoin.Location = new System.Drawing.Point(493, 199);
            this.picJoin.Name = "picJoin";
            this.picJoin.Size = new System.Drawing.Size(200, 100);
            this.picJoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJoin.TabIndex = 9;
            this.picJoin.TabStop = false;
            this.picJoin.Click += new System.EventHandler(this.picJoin_Click);
            this.picJoin.MouseEnter += new System.EventHandler(this.picJoin_MouseEnter);
            this.picJoin.MouseLeave += new System.EventHandler(this.picJoin_MouseLeave);
            // 
            // picCreate
            // 
            this.picCreate.BackColor = System.Drawing.Color.White;
            this.picCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCreate.Image = global::FantasySportsApplication.Properties.Resources.create;
            this.picCreate.Location = new System.Drawing.Point(127, 199);
            this.picCreate.Name = "picCreate";
            this.picCreate.Size = new System.Drawing.Size(200, 100);
            this.picCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCreate.TabIndex = 8;
            this.picCreate.TabStop = false;
            this.picCreate.Click += new System.EventHandler(this.picCreate_Click);
            this.picCreate.MouseEnter += new System.EventHandler(this.picCreate_MouseEnter);
            this.picCreate.MouseLeave += new System.EventHandler(this.picCreate_MouseLeave);
            // 
            // tbctrlChooseLeague
            // 
            this.tbctrlChooseLeague.Controls.Add(this.tbpgChooseLeague);
            this.tbctrlChooseLeague.Controls.Add(this.tbpgNoLeagues);
            this.tbctrlChooseLeague.Location = new System.Drawing.Point(-3, 69);
            this.tbctrlChooseLeague.Multiline = true;
            this.tbctrlChooseLeague.Name = "tbctrlChooseLeague";
            this.tbctrlChooseLeague.SelectedIndex = 0;
            this.tbctrlChooseLeague.Size = new System.Drawing.Size(849, 69);
            this.tbctrlChooseLeague.TabIndex = 7;
            // 
            // tbpgChooseLeague
            // 
            this.tbpgChooseLeague.BackColor = System.Drawing.Color.Black;
            this.tbpgChooseLeague.Controls.Add(this.btnEnterLeague);
            this.tbpgChooseLeague.Controls.Add(this.cmboLeague);
            this.tbpgChooseLeague.Controls.Add(this.label3);
            this.tbpgChooseLeague.Location = new System.Drawing.Point(4, 29);
            this.tbpgChooseLeague.Name = "tbpgChooseLeague";
            this.tbpgChooseLeague.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgChooseLeague.Size = new System.Drawing.Size(841, 36);
            this.tbpgChooseLeague.TabIndex = 0;
            this.tbpgChooseLeague.Text = "ChooseLeague";
            // 
            // btnEnterLeague
            // 
            this.btnEnterLeague.Location = new System.Drawing.Point(669, -3);
            this.btnEnterLeague.Name = "btnEnterLeague";
            this.btnEnterLeague.Size = new System.Drawing.Size(75, 35);
            this.btnEnterLeague.TabIndex = 2;
            this.btnEnterLeague.Text = "Go!";
            this.btnEnterLeague.UseVisualStyleBackColor = true;
            // 
            // cmboLeague
            // 
            this.cmboLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLeague.FormattingEnabled = true;
            this.cmboLeague.Location = new System.Drawing.Point(282, -1);
            this.cmboLeague.Name = "cmboLeague";
            this.cmboLeague.Size = new System.Drawing.Size(368, 28);
            this.cmboLeague.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select your league:";
            // 
            // tbpgNoLeagues
            // 
            this.tbpgNoLeagues.BackColor = System.Drawing.Color.Black;
            this.tbpgNoLeagues.Controls.Add(this.label2);
            this.tbpgNoLeagues.Location = new System.Drawing.Point(4, 29);
            this.tbpgNoLeagues.Name = "tbpgNoLeagues";
            this.tbpgNoLeagues.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgNoLeagues.Size = new System.Drawing.Size(841, 36);
            this.tbpgNoLeagues.TabIndex = 1;
            this.tbpgNoLeagues.Text = "NoLeagues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(683, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oops! It looks like you\'re not currently in any leagues.";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(734, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 32);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(3, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(719, 23);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, username!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 345);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbctrlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy Sports";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.tbctrlLogin.ResumeLayout(false);
            this.tbpgSignedOut.ResumeLayout(false);
            this.tbpgSignedOut.PerformLayout();
            this.tbpgSignedIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreate)).EndInit();
            this.tbctrlChooseLeague.ResumeLayout(false);
            this.tbpgChooseLeague.ResumeLayout(false);
            this.tbpgChooseLeague.PerformLayout();
            this.tbpgNoLeagues.ResumeLayout(false);
            this.tbpgNoLeagues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private PlaceHolderTextBox txtPassword;
        private PlaceHolderTextBox txtUsername;
        private System.Windows.Forms.Label lblLoginFail;
        private System.Windows.Forms.Timer tmrLoginFail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private TablessTabControl tbctrlLogin;
        private System.Windows.Forms.TabPage tbpgSignedOut;
        private System.Windows.Forms.TabPage tbpgSignedIn;
        private System.Windows.Forms.Label label1;
        private TablessTabControl tbctrlChooseLeague;
        private System.Windows.Forms.TabPage tbpgNoLeagues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpgChooseLeague;
        private System.Windows.Forms.Button btnEnterLeague;
        private System.Windows.Forms.ComboBox cmboLeague;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picJoin;
        private System.Windows.Forms.PictureBox picCreate;
    }
}

