
namespace CarritoDeCompras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCarritoDeCompras = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoDescuento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listCarritoDeCompras
            // 
            this.listCarritoDeCompras.FormattingEnabled = true;
            this.listCarritoDeCompras.ItemHeight = 15;
            this.listCarritoDeCompras.Location = new System.Drawing.Point(34, 28);
            this.listCarritoDeCompras.Name = "listCarritoDeCompras";
            this.listCarritoDeCompras.Size = new System.Drawing.Size(190, 259);
            this.listCarritoDeCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(260, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(341, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Pecio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(260, 62);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(198, 23);
            this.cboProductos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código de Descuento:";
            // 
            // txtCodigoDescuento
            // 
            this.txtCodigoDescuento.Location = new System.Drawing.Point(390, 152);
            this.txtCodigoDescuento.Name = "txtCodigoDescuento";
            this.txtCodigoDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoDescuento.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 336);
            this.Controls.Add(this.txtCodigoDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listCarritoDeCompras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCarritoDeCompras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoDescuento;
    }
}

