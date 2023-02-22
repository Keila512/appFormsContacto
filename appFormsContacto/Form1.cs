using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Contacto[] registro;
        int i = 0;

        private void btnRegistro_ClicK(object sender, EventArgs e)
        {
            if (i < registro.Length)
            {
                Contacto x = new Contacto();
                x.Nombre = tbNombre.Text;
                x.FechaNacimiento = DateTime.Parse(tbfecha.Text);
                x.Telefono = tbTelefono.Text;
                registro[i] = x;
                listaContactos.Items.Add(x.ToString());
                i++;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            registro = new Contacto[int.Parse(tbCantidad.Text)];
        }

       
    }
}
