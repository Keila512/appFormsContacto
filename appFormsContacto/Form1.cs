using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFormsContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contacto x = new Contacto();

        private void btnRegistro_ClicK(object sender, EventArgs e)
        {
            x.Nombre = tbNombre.Text;
            x.FechaNacimiento = DateTime.Parse(tbfecha.Text);
            x.Telefono = tbTelefono.Text;
            MessageBox.Show(x.ToString());

        }

       
    }
}
