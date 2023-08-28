namespace Tiendecita_Pa_Vender_Lo_Que_Ustedes_No_Pueden
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
            groupBox1 = new GroupBox();
            txtCliente = new TextBox();
            label4 = new Label();
            lblFecha = new Label();
            Fecha = new Label();
            lblHora = new Label();
            lblCliente = new Label();
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtCantidad = new TextBox();
            cmbProducto = new ComboBox();
            label8 = new Label();
            Cantidad = new Label();
            lblPrecio = new Label();
            label7 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label10 = new Label();
            lblTotalNeto = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(Fecha);
            groupBox1.Controls.Add(lblHora);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(93, 38);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(146, 27);
            txtCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(414, 43);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lblFecha";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(414, 0);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(49, 20);
            Fecha.TabIndex = 1;
            Fecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(634, 38);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(46, 15);
            lblHora.TabIndex = 0;
            lblHora.Text = "lblHora";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(31, 41);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(56, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(Cantidad);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Venta";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(664, 63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(664, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(95, 32);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(339, 42);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(77, 27);
            txtCantidad.TabIndex = 5;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(93, 42);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(144, 28);
            cmbProducto.TabIndex = 4;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(510, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 3;
            label8.Text = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cantidad.Location = new Point(263, 42);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(70, 20);
            Cantidad.TabIndex = 1;
            Cantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(510, 42);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "lblPrecio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(15, 42);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 2;
            label7.Text = "Producto";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(12, 297);
            listView1.Name = "listView1";
            listView1.Size = new Size(628, 97);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Subtotal";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Neto";
            columnHeader6.Width = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(676, 297);
            label10.Name = "label10";
            label10.Size = new Size(71, 17);
            label10.TabIndex = 4;
            label10.Text = "Total Neto";
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalNeto.Location = new Point(676, 340);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(81, 17);
            lblTotalNeto.TabIndex = 5;
            lblTotalNeto.Text = "lblTotalNeto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(27, 33);
            label12.Name = "label12";
            label12.Size = new Size(242, 21);
            label12.TabIndex = 6;
            label12.Text = "Control de Ventas de Producto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(label12);
            Controls.Add(lblTotalNeto);
            Controls.Add(label10);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Tiendecita";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCliente;
        private Label label4;
        private Label lblFecha;
        private Label Fecha;
        private Label lblHora;
        private Label lblCliente;
        private GroupBox groupBox2;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtCantidad;
        private ComboBox cmbProducto;
        private Label label8;
        private Label Cantidad;
        private Label lblPrecio;
        private Label label7;
        private ListView listView1;
        private Label label10;
        private Label lblTotalNeto;
        private Label label12;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}

