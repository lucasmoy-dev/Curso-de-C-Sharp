
namespace CursoProgramacion
{
    partial class GestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listClientes = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtTarjetaDeCredito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.ItemHeight = 15;
            this.listClientes.Location = new System.Drawing.Point(12, 23);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(266, 274);
            this.listClientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(460, 187);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(385, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(203, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(385, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 23);
            this.txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(385, 111);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 23);
            this.txtTelefono.TabIndex = 8;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(325, 111);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(55, 15);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // txtTarjetaDeCredito
            // 
            this.txtTarjetaDeCredito.Location = new System.Drawing.Point(325, 158);
            this.txtTarjetaDeCredito.Name = "txtTarjetaDeCredito";
            this.txtTarjetaDeCredito.Size = new System.Drawing.Size(210, 23);
            this.txtTarjetaDeCredito.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarjeta de Crédito";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(122, 303);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(386, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTarjetaDeCredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.listClientes);
            this.Name = "GestionClientes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtTarjetaDeCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAgregar;
    }
}