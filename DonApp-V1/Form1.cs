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
        public Form1()
        {
            InitializeComponent();
            SideMenu.Visible =false;
            openChildForm(new Login());
        }
        
    
    }
}
