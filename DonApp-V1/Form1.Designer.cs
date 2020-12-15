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
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNMaximizar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.PanelSecundario = new System.Windows.Forms.Panel();
            this.BarraSuperior.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
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
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.PanelSecundario);
            this.PanelPrincipal.Controls.Add(this.SideMenu);
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 36);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(838, 434);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(209)))), ((int)(((byte)(154)))));
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(200, 434);
            this.SideMenu.TabIndex = 0;
            // 
            // PanelSecundario
            // 
            this.PanelSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSecundario.Location = new System.Drawing.Point(200, 0);
            this.PanelSecundario.Name = "PanelSecundario";
            this.PanelSecundario.Size = new System.Drawing.Size(638, 434);
            this.PanelSecundario.TabIndex = 1;
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
    }
}

