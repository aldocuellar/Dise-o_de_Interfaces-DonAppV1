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
            this.PanelLoginSuperior = new System.Windows.Forms.Panel();
            this.PanelLoginInferior = new System.Windows.Forms.Panel();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.DonApp = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBUserPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelLoginSuperior.SuspendLayout();
            this.PanelLoginInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLoginSuperior
            // 
            this.PanelLoginSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLoginSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.PanelLoginSuperior.Controls.Add(this.DonApp);
            this.PanelLoginSuperior.Controls.Add(this.LoginLogo);
            this.PanelLoginSuperior.Location = new System.Drawing.Point(0, -2);
            this.PanelLoginSuperior.Name = "PanelLoginSuperior";
            this.PanelLoginSuperior.Size = new System.Drawing.Size(838, 226);
            this.PanelLoginSuperior.TabIndex = 1;
            // 
            // PanelLoginInferior
            // 
            this.PanelLoginInferior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLoginInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.PanelLoginInferior.Controls.Add(this.button1);
            this.PanelLoginInferior.Controls.Add(this.TBUserPassword);
            this.PanelLoginInferior.Controls.Add(this.TBUsername);
            this.PanelLoginInferior.Location = new System.Drawing.Point(0, 216);
            this.PanelLoginInferior.Name = "PanelLoginInferior";
            this.PanelLoginInferior.Size = new System.Drawing.Size(838, 225);
            this.PanelLoginInferior.TabIndex = 2;
            // 
            // LoginLogo
            // 
            this.LoginLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.LoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginLogo.Image")));
            this.LoginLogo.Location = new System.Drawing.Point(361, 40);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(120, 120);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginLogo.TabIndex = 0;
            this.LoginLogo.TabStop = false;
            // 
            // DonApp
            // 
            this.DonApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DonApp.AutoSize = true;
            this.DonApp.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonApp.ForeColor = System.Drawing.Color.White;
            this.DonApp.Location = new System.Drawing.Point(302, 160);
            this.DonApp.Name = "DonApp";
            this.DonApp.Size = new System.Drawing.Size(246, 55);
            this.DonApp.TabIndex = 1;
            this.DonApp.Text = "DONAPP";
            // 
            // TBUsername
            // 
            this.TBUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.TBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsername.ForeColor = System.Drawing.Color.White;
            this.TBUsername.Location = new System.Drawing.Point(340, 19);
            this.TBUsername.Multiline = true;
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(166, 34);
            this.TBUsername.TabIndex = 0;
            // 
            // TBUserPassword
            // 
            this.TBUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.TBUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUserPassword.ForeColor = System.Drawing.Color.White;
            this.TBUserPassword.Location = new System.Drawing.Point(340, 59);
            this.TBUserPassword.Multiline = true;
            this.TBUserPassword.Name = "TBUserPassword";
            this.TBUserPassword.Size = new System.Drawing.Size(166, 33);
            this.TBUserPassword.TabIndex = 1;
            this.TBUserPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.PanelLoginInferior);
            this.Controls.Add(this.PanelLoginSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.PanelLoginSuperior.ResumeLayout(false);
            this.PanelLoginSuperior.PerformLayout();
            this.PanelLoginInferior.ResumeLayout(false);
            this.PanelLoginInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoginSuperior;
        private System.Windows.Forms.Panel PanelLoginInferior;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.Label DonApp;
        private System.Windows.Forms.TextBox TBUserPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Button button1;
    }
}