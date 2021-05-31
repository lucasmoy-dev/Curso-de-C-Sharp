using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = Double.Parse(textoPeso); // peso en kilogramos

            string textoAltura = txtAltura.Text;
            double altura = Double.Parse(textoAltura); // altura en metros

            double imc = peso / (altura * altura);

            MessageBox.Show("El IMC es: " + imc);
            
        }
    }
}
