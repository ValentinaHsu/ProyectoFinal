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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Properties.Form3 myNewForm = new Form3();
            myNewForm.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Properties.Form4 myNewForm = new Form4();
            myNewForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
