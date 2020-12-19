using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonApp_V1
{
    public partial class Form1 : Form
    {
        //--Método para mostrar un formulario en un panel
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(childForm);
            PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //--Método para mostrar un formulario en un panel
        //--Método para mostrar un formulario en un panel
        private Form activeForm2 = null;
        private void openChildForm2(Form childForm2)
        {
            if (activeForm2 != null)
                activeForm2.Close();
            activeForm2 = childForm2;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;
            PanelSecundario.Controls.Add(childForm2);
            PanelSecundario.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();
        }
        //--Método para mostrar un formulario en un panel
        public Form1()
        {
            InitializeComponent();
            openChildForm(new Login());
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int posX = 0;
        int posY = 0;
        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            openChildForm(new Login());
        }

        private void BTNUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm2(new Usuarios());
        }

        private void BTNCampañas_Click(object sender, EventArgs e)
        {
            openChildForm2(new Campañas());
        }

        private void BTNDonaciones_Click(object sender, EventArgs e)
        {
            openChildForm2(new Donaciones());
        }

        private void BTNHistorial_Click(object sender, EventArgs e)
        {
            openChildForm2(new Historial());
        }
    }
}
