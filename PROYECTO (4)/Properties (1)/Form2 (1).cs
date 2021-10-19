using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO.Properties
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        string nombre;
        int edad;
        public Form2()
        {
          

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnContinuar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenidanote_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            edad = Convert.ToInt32(txtEdad.Text);
            

         }

                private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
        private void controlBotones()
        {
            if (nombre.Trim() != string.Empty && nombre.All(Char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(nombre.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");
                }
                btnContinuar.Enabled = false;
                txtNombre.Focus();
            }
        }
    }
}
