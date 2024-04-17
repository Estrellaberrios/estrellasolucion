using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estrella
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto= textBox1.Text;

            if (texto == "rata")

            { Form2 ventana = new Form2();
                ventana.ShowDialog(); }


            else
                MessageBox.Show("El codigo es incorrecto");
        }
    }
}
