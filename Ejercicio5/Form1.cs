using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void frmDatosPersonales_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();           

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }

            string nombre = (txtNombre.Text + " " + txtApellido.Text);

            if (!(txtApellido.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || txtDireccion.Text == ""))
            {
                txtApellido.BackColor = Color.White;
                txtNombre.BackColor = Color.White;
                txtEdad.BackColor = Color.White;
                txtDireccion.BackColor = Color.White;
                
                txtResultado.Text = ("Apellido y Nombre: " + nombre + "\r\n" + "Edad: " + txtEdad.Text + "\r\n" + "Dirección: " + txtDireccion.Text);
            } else
            {
                MessageBox.Show("Debe completar todos los campos.");
            }


            DateTime d1 = new DateTime(1996, 2, 26);

            DateTime fechaNacimiento = d1;

            DateTime ahora = DateTime.Now;



           

            

            


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;



           

           

        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
