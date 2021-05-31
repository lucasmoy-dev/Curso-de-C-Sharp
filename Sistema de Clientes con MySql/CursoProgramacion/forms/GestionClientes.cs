using CursoProgramacion.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoProgramacion
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.ObtenerListadoDeClientes();

            listClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.TarjetaDeCredito = txtTarjetaDeCredito.Text;
            cliente.Telefono = txtTelefono.Text;

            if (lblId.Text != "")
            {
                cliente.Id = lblId.Text;
            }

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();
            limpiarInputs();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) listClientes.SelectedItem;

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(cliente);
            actualizarLista();
            limpiarInputs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaDeCredito.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarInputs();
        }

        private void limpiarInputs()
        {

            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjetaDeCredito.Text = "";
        }
    }
}
