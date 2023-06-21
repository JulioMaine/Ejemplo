using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edad
{
    public partial class frmEdad : Form
    {
        public frmEdad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdad_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor ingrese su fecha de nacimiento.");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFecha.Value;
            DateTime fechaActual = DateTime.Now;


            TimeSpan diferencia = fechaActual - fechaNacimiento;

            

            double dias = diferencia.TotalDays;

            double años = Math.Floor(dias / 365.25);


            if (fechaNacimiento.AddSeconds(60) < fechaActual)
            {
                if (fechaNacimiento.Day == fechaActual.Day)
                {
                    años++;
                    MessageBox.Show("Tienes " + años + " años.");
                }
                else
                {
                    MessageBox.Show("Tienes " + años + " años.");
                }
                
            } 
            else
            {
                MessageBox.Show("La fecha ingresada no es correcta.");

            }


          

           
            



            

            //if (fechaActual.Year > fechaNacimiento.Year && fechaNacimiento.Year != (fechaActual.Year-1))
            //{
            //    if (fechaNacimiento.Month >= fechaActual.Month)
            //    {
            //        if(fechaNacimiento.Day > fechaActual.Day)
            //        {
            //            int edad = (fechaActual.Year - fechaNacimiento.Year) - 1;

            //            if ((fechaActual.Year-2) == fechaNacimiento.Year && fechaNacimiento.Day >= fechaActual.Day)
            //            {
            //                MessageBox.Show("Usted tiene 1 año.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Usted tiene " + edad + " años.");
            //            }
                        
            //        }
            //        else
            //        {
            //            if (fechaActual.Day >= fechaNacimiento.Day)
            //            {
            //                int edad = fechaActual.Year - fechaNacimiento.Year;
            //                MessageBox.Show("Usted tiene " + edad + " años.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Usted tiene un año.");
            //            }

            //        }

            //    }
            //    else
            //    {
            //        int edad = fechaActual.Year - fechaNacimiento.Year;
            //        MessageBox.Show("Usted tiene " + edad + " años.");
            //    }
            //}
            //else if (fechaActual.Year == fechaNacimiento.Year)
            //{
            //    if (fechaActual.Month >= fechaNacimiento.Month)
            //    {
            //        int meses = fechaActual.Month - fechaNacimiento.Month;
            //        if (fechaActual.Month == fechaNacimiento.Month)
            //        {
            //            MessageBox.Show("Tu bebe tiene unos dias de vida o casi 1 mes .");                           
            //        }
            //        else if (fechaNacimiento.Month == (fechaActual.Month - 1))
            //        {
            //            MessageBox.Show("Tu bebe tiene aproximadamente 1 mes de vida");
                            
            //        }
            //        else
            //        {
            //            MessageBox.Show("Tu bebe tiene " + meses + " meses de vida aprox.");
            //        }
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("No naciste todavia crack.");
            //    }
               

            //}
            //else if ((fechaActual.Year-1) == fechaNacimiento.Year)
            //{
            //    MessageBox.Show("tienes unos meses de vida, casi un 1 año o mas de 1 año.");
            //}
            //else
            //{
            //    MessageBox.Show("No naciste todavia crack.");
            //}




        }
    }
}
