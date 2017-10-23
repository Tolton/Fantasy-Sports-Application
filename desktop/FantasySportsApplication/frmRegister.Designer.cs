namespace FantasySportsApplication
{
    partial class frmRegister
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUsername = new FantasySportsApplication.PlaceHolderTextBox();
            this.txtPassword = new FantasySportsApplication.PlaceHolderTextBox();
            this.txtPasswordConfirm = new FantasySportsApplication.PlaceHolderTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.tmrSuccess = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(74, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(147, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(74, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(147, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(74, 101);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(147, 23);
            this.lblPasswordConfirm.TabIndex = 5;
            this.lblPasswordConfirm.Text = "Confirm Password:";
            this.lblPasswordConfirm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(129, 176);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(110, 36);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(227, 34);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceHolderText = "";
            this.txtUsername.Size = new System.Drawing.Size(228, 26);
            this.txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(227, 66);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "";
            this.txtPassword.Size = new System.Drawing.Size(228, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.txtPasswordConfirm.isPassword = true;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(227, 98);
            this.txtPasswordConfirm.MaxLength = 30;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PlaceHolderText = "";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(228, 26);
            this.txtPasswordConfirm.TabIndex = 10;
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(12, 140);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(464, 23);
            this.lblError.TabIndex = 11;
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
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(488, 224);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegister";
            this.Text = "Register Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private PlaceHolderTextBox txtUsername;
        private PlaceHolderTextBox txtPassword;
        private PlaceHolderTextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrError;
        private System.Windows.Forms.Timer tmrSuccess;
    }
}