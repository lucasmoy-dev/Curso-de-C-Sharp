using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorYMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = Int32.Parse(textBox1.Text);

            /*
             * Forma alternativa
             * 
            double resultado = numero / 2;

            if (resultado == Math.Round(resultado))
            {
                MessageBox.Show("El número es par");
            } else
            {
                MessageBox.Show("El número es impar");
            }
            */


            if (numero % 2 == 0)
            {
                MessageBox.Show("El número es par");
            } else
            {
                MessageBox.Show("El número es impar");
            }

        }
    }
}
