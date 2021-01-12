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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BTNCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario almacenado","Mensaje de estado");
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            TBNombre.Clear();
            TBApPaterno.Clear();
            TBApMaterno.Clear();
            TBNickname.Clear();
            TBFechaNac.Clear();
            TBEmail.Clear();
            TBDescripciónUser.Clear();
            MessageBox.Show("Usuario modificado", "Mensaje de estado");
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario eliminado", "Mensaje de estado");
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            if(TBBuscarUsuario.Text=="1")
            {
                TBNombre.Text="Pablo José";
                TBApPaterno.Text = "Perez";
                TBApMaterno.Text = "García";
                TBNickname.Text = "Pabloperez16";
                TBFechaNac.Text = "12/01/1985";
                TBEmail.Text = "Pablo.perez16@donapp.com";
                TBDescripciónUser.Text = "Supervisor";
            }else
            {
                MessageBox.Show("Usuario no encontrado","Advertencia");
            }
        }
    }
}
