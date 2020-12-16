namespace DonApp_V1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNMaximizar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.BTNHistorial = new System.Windows.Forms.Button();
            this.BTNDonaciones = new System.Windows.Forms.Button();
            this.BTNCampañas = new System.Windows.Forms.Button();
            this.BTNUsuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.UserSideMenuPic = new System.Windows.Forms.PictureBox();
            this.PanelSecundario = new System.Windows.Forms.Panel();
            this.LogoMainMenu = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserSideMenuPic)).BeginInit();
            this.PanelSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BarraSuperior.Controls.Add(this.button1);
            this.BarraSuperior.Controls.Add(this.BTNMaximizar);
            this.BarraSuperior.Controls.Add(this.BTNCerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(838, 36);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(734, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = " _";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BTNMaximizar
            // 
            this.BTNMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNMaximizar.FlatAppearance.BorderSize = 0;
            this.BTNMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMaximizar.ForeColor = System.Drawing.Color.White;
            this.BTNMaximizar.Location = new System.Drawing.Point(769, 0);
            this.BTNMaximizar.Name = "BTNMaximizar";
            this.BTNMaximizar.Size = new System.Drawing.Size(34, 34);
            this.BTNMaximizar.TabIndex = 1;
            this.BTNMaximizar.Text = " □";
            this.BTNMaximizar.UseVisualStyleBackColor = false;
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNCerrar.FlatAppearance.BorderSize = 0;
            this.BTNCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCerrar.ForeColor = System.Drawing.Color.White;
            this.BTNCerrar.Location = new System.Drawing.Point(804, 0);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(34, 34);
            this.BTNCerrar.TabIndex = 0;
            this.BTNCerrar.Text = "X";
            this.BTNCerrar.UseVisualStyleBackColor = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.SideMenu);
            this.PanelPrincipal.Controls.Add(this.PanelSecundario);
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 36);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(838, 434);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.SideMenu.Controls.Add(this.lblLogOut);
            this.SideMenu.Controls.Add(this.BTNHistorial);
            this.SideMenu.Controls.Add(this.BTNDonaciones);
            this.SideMenu.Controls.Add(this.BTNCampañas);
            this.SideMenu.Controls.Add(this.BTNUsuarios);
            this.SideMenu.Controls.Add(this.pictureBox1);
            this.SideMenu.Controls.Add(this.lblAdministrador);
            this.SideMenu.Controls.Add(this.UserSideMenuPic);
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(201, 434);
            this.SideMenu.TabIndex = 0;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblLogOut.Location = new System.Drawing.Point(32, 401);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(138, 24);
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Cerrar Sesión";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // BTNHistorial
            // 
            this.BTNHistorial.FlatAppearance.BorderSize = 0;
            this.BTNHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(95)))));
            this.BTNHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNHistorial.Image = ((System.Drawing.Image)(resources.GetObject("BTNHistorial.Image")));
            this.BTNHistorial.Location = new System.Drawing.Point(-1, 307);
            this.BTNHistorial.Name = "BTNHistorial";
            this.BTNHistorial.Size = new System.Drawing.Size(201, 41);
            this.BTNHistorial.TabIndex = 6;
            this.BTNHistorial.Text = "Historial";
            this.BTNHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNHistorial.UseVisualStyleBackColor = true;
            // 
            // BTNDonaciones
            // 
            this.BTNDonaciones.FlatAppearance.BorderSize = 0;
            this.BTNDonaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(95)))));
            this.BTNDonaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNDonaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDonaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDonaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNDonaciones.Image = ((System.Drawing.Image)(resources.GetObject("BTNDonaciones.Image")));
            this.BTNDonaciones.Location = new System.Drawing.Point(-1, 260);
            this.BTNDonaciones.Name = "BTNDonaciones";
            this.BTNDonaciones.Size = new System.Drawing.Size(201, 41);
            this.BTNDonaciones.TabIndex = 5;
            this.BTNDonaciones.Text = "Donaciones";
            this.BTNDonaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNDonaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNDonaciones.UseVisualStyleBackColor = true;
            // 
            // BTNCampañas
            // 
            this.BTNCampañas.FlatAppearance.BorderSize = 0;
            this.BTNCampañas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(95)))));
            this.BTNCampañas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNCampañas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCampañas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCampañas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNCampañas.Image = ((System.Drawing.Image)(resources.GetObject("BTNCampañas.Image")));
            this.BTNCampañas.Location = new System.Drawing.Point(-1, 213);
            this.BTNCampañas.Name = "BTNCampañas";
            this.BTNCampañas.Size = new System.Drawing.Size(201, 41);
            this.BTNCampañas.TabIndex = 4;
            this.BTNCampañas.Text = "Campañas";
            this.BTNCampañas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCampañas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCampañas.UseVisualStyleBackColor = true;
            this.BTNCampañas.Click += new System.EventHandler(this.BTNCampañas_Click);
            // 
            // BTNUsuarios
            // 
            this.BTNUsuarios.FlatAppearance.BorderSize = 0;
            this.BTNUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(95)))));
            this.BTNUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BTNUsuarios.Image")));
            this.BTNUsuarios.Location = new System.Drawing.Point(-1, 166);
            this.BTNUsuarios.Name = "BTNUsuarios";
            this.BTNUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTNUsuarios.Size = new System.Drawing.Size(201, 41);
            this.BTNUsuarios.TabIndex = 3;
            this.BTNUsuarios.Text = "Usuarios";
            this.BTNUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNUsuarios.UseVisualStyleBackColor = true;
            this.BTNUsuarios.Click += new System.EventHandler(this.BTNUsuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 26);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblAdministrador.Location = new System.Drawing.Point(32, 126);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(139, 24);
            this.lblAdministrador.TabIndex = 2;
            this.lblAdministrador.Text = "Administrador";
            // 
            // UserSideMenuPic
            // 
            this.UserSideMenuPic.BackColor = System.Drawing.Color.Transparent;
            this.UserSideMenuPic.Image = ((System.Drawing.Image)(resources.GetObject("UserSideMenuPic.Image")));
            this.UserSideMenuPic.Location = new System.Drawing.Point(67, 59);
            this.UserSideMenuPic.Name = "UserSideMenuPic";
            this.UserSideMenuPic.Size = new System.Drawing.Size(64, 64);
            this.UserSideMenuPic.TabIndex = 2;
            this.UserSideMenuPic.TabStop = false;
            // 
            // PanelSecundario
            // 
            this.PanelSecundario.Controls.Add(this.LogoMainMenu);
            this.PanelSecundario.Location = new System.Drawing.Point(206, 6);
            this.PanelSecundario.Name = "PanelSecundario";
            this.PanelSecundario.Size = new System.Drawing.Size(629, 425);
            this.PanelSecundario.TabIndex = 1;
            // 
            // LogoMainMenu
            // 
            this.LogoMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.LogoMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("LogoMainMenu.Image")));
            this.LogoMainMenu.Location = new System.Drawing.Point(187, 79);
            this.LogoMainMenu.Name = "LogoMainMenu";
            this.LogoMainMenu.Size = new System.Drawing.Size(252, 263);
            this.LogoMainMenu.TabIndex = 1;
            this.LogoMainMenu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserSideMenuPic)).EndInit();
            this.PanelSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button BTNMaximizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelSecundario;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.PictureBox LogoMainMenu;
        private System.Windows.Forms.PictureBox UserSideMenuPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button BTNUsuarios;
        private System.Windows.Forms.Button BTNCampañas;
        private System.Windows.Forms.Button BTNHistorial;
        private System.Windows.Forms.Button BTNDonaciones;
        private System.Windows.Forms.Label lblLogOut;
    }
}

