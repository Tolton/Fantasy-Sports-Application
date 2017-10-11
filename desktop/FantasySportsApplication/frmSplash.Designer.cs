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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.placeHolderTextBox1 = new FantasySportsApplication.PlaceHolderTextBox();
            this.placeHolderTextBox2 = new FantasySportsApplication.PlaceHolderTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.placeHolderTextBox1);
            this.pnlLogin.Controls.Add(this.placeHolderTextBox2);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(373, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(490, 44);
            this.pnlLogin.TabIndex = 0;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.isPassword = false;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(6, 8);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Username";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(143, 26);
            this.placeHolderTextBox1.TabIndex = 1;
            this.placeHolderTextBox1.Text = "Username";
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox2.isPassword = true;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(153, 8);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceHolderText = "Password";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(143, 26);
            this.placeHolderTextBox2.TabIndex = 2;
            this.placeHolderTextBox2.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(382, 8);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 32);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(301, 8);
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
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 699);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy Sports";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private PlaceHolderTextBox placeHolderTextBox2;
        private PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.PictureBox picExit;
    }
}

