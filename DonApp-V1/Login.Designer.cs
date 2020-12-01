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
            this.PanelLoginSuperior = new System.Windows.Forms.Panel();
            this.PanelLoginInferior = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelLoginSuperior
            // 
            this.PanelLoginSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.PanelLoginSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLoginSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelLoginSuperior.Name = "PanelLoginSuperior";
            this.PanelLoginSuperior.Size = new System.Drawing.Size(838, 220);
            this.PanelLoginSuperior.TabIndex = 1;
            // 
            // PanelLoginInferior
            // 
            this.PanelLoginInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.PanelLoginInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelLoginInferior.Location = new System.Drawing.Point(0, 220);
            this.PanelLoginInferior.Name = "PanelLoginInferior";
            this.PanelLoginInferior.Size = new System.Drawing.Size(838, 221);
            this.PanelLoginInferior.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.PanelLoginInferior);
            this.Controls.Add(this.PanelLoginSuperior);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoginSuperior;
        private System.Windows.Forms.Panel PanelLoginInferior;
    }
}