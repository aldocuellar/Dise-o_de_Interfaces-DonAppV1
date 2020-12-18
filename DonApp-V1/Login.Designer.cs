namespace DonApp_V1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.TBUserPassword = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.PassPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLogo
            // 
            this.LoginLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.LoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginLogo.Image")));
            this.LoginLogo.Location = new System.Drawing.Point(363, 76);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(120, 120);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginLogo.TabIndex = 0;
            this.LoginLogo.TabStop = false;
            // 
            // BTNLogin
            // 
            this.BTNLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNLogin.BackColor = System.Drawing.Color.Transparent;
            this.BTNLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNLogin.FlatAppearance.BorderSize = 0;
            this.BTNLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.Image = ((System.Drawing.Image)(resources.GetObject("BTNLogin.Image")));
            this.BTNLogin.Location = new System.Drawing.Point(340, 328);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(170, 40);
            this.BTNLogin.TabIndex = 2;
            this.BTNLogin.Text = "Iniciar Sesión";
            this.BTNLogin.UseVisualStyleBackColor = false;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // TBUserPassword
            // 
            this.TBUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.TBUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserPassword.ForeColor = System.Drawing.Color.White;
            this.TBUserPassword.Location = new System.Drawing.Point(356, 276);
            this.TBUserPassword.Multiline = true;
            this.TBUserPassword.Name = "TBUserPassword";
            this.TBUserPassword.PasswordChar = '*';
            this.TBUserPassword.Size = new System.Drawing.Size(151, 33);
            this.TBUserPassword.TabIndex = 1;
            this.TBUserPassword.UseSystemPasswordChar = true;
            // 
            // TBUsername
            // 
            this.TBUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.TBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsername.ForeColor = System.Drawing.Color.White;
            this.TBUsername.Location = new System.Drawing.Point(356, 236);
            this.TBUsername.Multiline = true;
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(151, 34);
            this.TBUsername.TabIndex = 0;
            // 
            // UserPic
            // 
            this.UserPic.BackColor = System.Drawing.Color.Transparent;
            this.UserPic.Image = ((System.Drawing.Image)(resources.GetObject("UserPic.Image")));
            this.UserPic.Location = new System.Drawing.Point(334, 244);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(16, 16);
            this.UserPic.TabIndex = 3;
            this.UserPic.TabStop = false;
            // 
            // PassPic
            // 
            this.PassPic.BackColor = System.Drawing.Color.Transparent;
            this.PassPic.Image = ((System.Drawing.Image)(resources.GetObject("PassPic.Image")));
            this.PassPic.Location = new System.Drawing.Point(334, 282);
            this.PassPic.Name = "PassPic";
            this.PassPic.Size = new System.Drawing.Size(16, 19);
            this.PassPic.TabIndex = 4;
            this.PassPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PassPic);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.UserPic);
            this.Controls.Add(this.TBUserPassword);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.LoginLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.TextBox TBUserPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.PictureBox PassPic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}