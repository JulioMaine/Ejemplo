using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class MiPrimerAplicación : Form
    {
        public MiPrimerAplicación()
        {
            InitializeComponent();
        }

     

        private void MiPrimerAplicación_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a C#");
        }

        private void MiPrimerAplicación_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chau Chau ...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            if (textBox1.Text == "")
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void MiPrimerAplicación_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;// Aqui ocurre el casteo explícito para poder adquirir las propiedades de MouseEventArgs. 
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Cyan;
            
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = System.Drawing.SystemColors.Control;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + textBox2.Text.Length + " Caracteres");
        }
    }
}
