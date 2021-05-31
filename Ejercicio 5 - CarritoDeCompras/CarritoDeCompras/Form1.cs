using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalón");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritoDeCompras.Items.Add(productoSeleccionado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Pantalon 20
            // Camisa 35
            // Zapatos 24
            double precioFinal = 0;

            int totalProductosCargados = listCarritoDeCompras.Items.Count;

            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = listCarritoDeCompras.Items[i].ToString();
                if (productoElegido == "Pantalón")
                {
                    precioFinal += 20;
                }
                else if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                if (productoElegido == "Zapatos")
                {
                    precioFinal += 24;
                }
            }

            if (txtCodigoDescuento.Text == "NAVIDAD")
            {
                precioFinal = precioFinal * 0.9;
            }
            MessageBox.Show("El precio final es: $" + precioFinal);
        }
    }
}
