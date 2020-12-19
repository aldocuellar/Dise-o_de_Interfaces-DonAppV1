namespace DonApp_V1
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.PBHistorial = new System.Windows.Forms.PictureBox();
            this.BTNFiltrar = new System.Windows.Forms.Button();
            this.CBCampaña = new System.Windows.Forms.CheckBox();
            this.CBFecha = new System.Windows.Forms.CheckBox();
            this.TBFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // PBHistorial
            // 
            this.PBHistorial.Image = ((System.Drawing.Image)(resources.GetObject("PBHistorial.Image")));
            this.PBHistorial.Location = new System.Drawing.Point(51, 148);
            this.PBHistorial.Name = "PBHistorial";
            this.PBHistorial.Size = new System.Drawing.Size(524, 234);
            this.PBHistorial.TabIndex = 0;
            this.PBHistorial.TabStop = false;
            // 
            // BTNFiltrar
            // 
            this.BTNFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.BTNFiltrar.FlatAppearance.BorderSize = 0;
            this.BTNFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BTNFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BTNFiltrar.Image")));
            this.BTNFiltrar.Location = new System.Drawing.Point(327, 80);
            this.BTNFiltrar.Name = "BTNFiltrar";
            this.BTNFiltrar.Size = new System.Drawing.Size(101, 32);
            this.BTNFiltrar.TabIndex = 49;
            this.BTNFiltrar.Text = "Filtrar";
            this.BTNFiltrar.UseVisualStyleBackColor = false;
            // 
            // CBCampaña
            // 
            this.CBCampaña.AutoSize = true;
            this.CBCampaña.BackColor = System.Drawing.SystemColors.Control;
            this.CBCampaña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCampaña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CBCampaña.Location = new System.Drawing.Point(185, 46);
            this.CBCampaña.Name = "CBCampaña";
            this.CBCampaña.Size = new System.Drawing.Size(101, 24);
            this.CBCampaña.TabIndex = 50;
            this.CBCampaña.Text = "Campaña";
            this.CBCampaña.UseVisualStyleBackColor = false;
            // 
            // CBFecha
            // 
            this.CBFecha.AutoSize = true;
            this.CBFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CBFecha.Location = new System.Drawing.Point(353, 46);
            this.CBFecha.Name = "CBFecha";
            this.CBFecha.Size = new System.Drawing.Size(75, 24);
            this.CBFecha.TabIndex = 51;
            this.CBFecha.Text = "Fecha";
            this.CBFecha.UseVisualStyleBackColor = true;
            // 
            // TBFiltro
            // 
            this.TBFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.TBFiltro.Location = new System.Drawing.Point(185, 79);
            this.TBFiltro.Multiline = true;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Size = new System.Drawing.Size(136, 34);
            this.TBFiltro.TabIndex = 52;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 425);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.CBFecha);
            this.Controls.Add(this.CBCampaña);
            this.Controls.Add(this.BTNFiltrar);
            this.Controls.Add(this.PBHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.PBHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBHistorial;
        private System.Windows.Forms.Button BTNFiltrar;
        private System.Windows.Forms.CheckBox CBCampaña;
        private System.Windows.Forms.CheckBox CBFecha;
        private System.Windows.Forms.TextBox TBFiltro;
    }
}