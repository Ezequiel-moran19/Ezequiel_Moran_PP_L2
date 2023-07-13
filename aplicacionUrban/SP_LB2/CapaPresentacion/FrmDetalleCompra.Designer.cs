namespace Urban
{
    partial class FrmDetalleCompra
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
            BtnEliminar = new DataGridViewButtonColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            dgvdata = new DataGridView();
            SubTotal = new DataGridViewTextBoxColumn();
            txtMontoTotal = new TextBox();
            label11 = new Label();
            grp_InfoCompra = new GroupBox();
            txtUsuario = new TextBox();
            label6 = new Label();
            txtTipoDocumento = new TextBox();
            label3 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grp_InfoProveedor = new GroupBox();
            txtNumDocumento = new TextBox();
            txtRazonSocial = new TextBox();
            label4 = new Label();
            txtDocProveedor = new TextBox();
            label5 = new Label();
            txtBusqueda = new TextBox();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            btnDescargaPdf = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            grp_InfoCompra.SuspendLayout();
            grp_InfoProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "";
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Width = 40;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PrecioCompra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, BtnEliminar });
            dgvdata.Location = new Point(165, 277);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(588, 171);
            dgvdata.TabIndex = 138;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.ForeColor = Color.Black;
            txtMontoTotal.Location = new Point(236, 450);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(96, 23);
            txtMontoTotal.TabIndex = 136;
            txtMontoTotal.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(156, 453);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 135;
            label11.Text = "Monto total";
            // 
            // grp_InfoCompra
            // 
            grp_InfoCompra.BackColor = Color.White;
            grp_InfoCompra.Controls.Add(txtUsuario);
            grp_InfoCompra.Controls.Add(label6);
            grp_InfoCompra.Controls.Add(txtTipoDocumento);
            grp_InfoCompra.Controls.Add(label3);
            grp_InfoCompra.Controls.Add(txtFecha);
            grp_InfoCompra.Controls.Add(label2);
            grp_InfoCompra.Location = new Point(165, 130);
            grp_InfoCompra.Name = "grp_InfoCompra";
            grp_InfoCompra.Size = new Size(588, 65);
            grp_InfoCompra.TabIndex = 131;
            grp_InfoCompra.TabStop = false;
            grp_InfoCompra.Text = "Informacion Compra";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(417, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(147, 23);
            txtUsuario.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 18);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 5;
            label6.Text = "Usuario";
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Location = new Point(221, 36);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(148, 23);
            txtTipoDocumento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 18);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo Documento";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(34, 36);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(151, 23);
            txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 87);
            label1.Name = "label1";
            label1.Size = new Size(643, 395);
            label1.TabIndex = 130;
            label1.Text = "Detalle Compra";
            // 
            // grp_InfoProveedor
            // 
            grp_InfoProveedor.BackColor = Color.White;
            grp_InfoProveedor.Controls.Add(txtNumDocumento);
            grp_InfoProveedor.Controls.Add(txtRazonSocial);
            grp_InfoProveedor.Controls.Add(label4);
            grp_InfoProveedor.Controls.Add(txtDocProveedor);
            grp_InfoProveedor.Controls.Add(label5);
            grp_InfoProveedor.Location = new Point(165, 201);
            grp_InfoProveedor.Name = "grp_InfoProveedor";
            grp_InfoProveedor.Size = new Size(588, 70);
            grp_InfoProveedor.TabIndex = 132;
            grp_InfoProveedor.TabStop = false;
            grp_InfoProveedor.Text = "Informacio Proveedor";
            // 
            // txtNumDocumento
            // 
            txtNumDocumento.Location = new Point(509, 34);
            txtNumDocumento.Name = "txtNumDocumento";
            txtNumDocumento.Size = new Size(55, 23);
            txtNumDocumento.TabIndex = 99;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(221, 38);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(151, 23);
            txtRazonSocial.TabIndex = 98;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 19);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Razon Social";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.Location = new Point(32, 34);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(153, 23);
            txtDocProveedor.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 16);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 0;
            label5.Text = "Nro Documento";
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Location = new Point(462, 110);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(156, 23);
            txtBusqueda.TabIndex = 142;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.White;
            btnLimpiarBuscador.Cursor = Cursors.Hand;
            btnLimpiarBuscador.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarBuscador.ForeColor = Color.Black;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarBuscador.IconColor = Color.Black;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 18;
            btnLimpiarBuscador.Location = new Point(700, 110);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(53, 22);
            btnLimpiarBuscador.TabIndex = 141;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 18;
            btnBuscar.Location = new Point(634, 111);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 22);
            btnBuscar.TabIndex = 140;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(342, 115);
            label10.Name = "label10";
            label10.Size = new Size(111, 13);
            label10.TabIndex = 139;
            label10.Text = "Numero Documento";
            // 
            // btnDescargaPdf
            // 
            btnDescargaPdf.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDescargaPdf.IconColor = Color.Black;
            btnDescargaPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargaPdf.Location = new Point(573, 450);
            btnDescargaPdf.Name = "btnDescargaPdf";
            btnDescargaPdf.Size = new Size(117, 23);
            btnDescargaPdf.TabIndex = 143;
            btnDescargaPdf.Text = "Descargar PDF";
            btnDescargaPdf.UseVisualStyleBackColor = true;
            // 
            // FrmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(792, 485);
            Controls.Add(btnDescargaPdf);
            Controls.Add(txtBusqueda);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(label10);
            Controls.Add(dgvdata);
            Controls.Add(txtMontoTotal);
            Controls.Add(label11);
            Controls.Add(grp_InfoCompra);
            Controls.Add(grp_InfoProveedor);
            Controls.Add(label1);
            Name = "FrmDetalleCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDetalleCompra";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            grp_InfoCompra.ResumeLayout(false);
            grp_InfoCompra.PerformLayout();
            grp_InfoProveedor.ResumeLayout(false);
            grp_InfoProveedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewButtonColumn BtnEliminar;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn SubTotal;
        private TextBox txtMontoTotal;
        private Label label11;
        private GroupBox grp_InfoCompra;
        private TextBox txtTipoDocumento;
        private Label label3;
        private TextBox txtFecha;
        private Label label2;
        private Label label1;
        private GroupBox grp_InfoProveedor;
        private TextBox txtNumDocumento;
        private TextBox txtRazonSocial;
        private Label label4;
        private TextBox txtDocProveedor;
        private Label label5;
        private TextBox txtUsuario;
        private Label label6;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnDescargaPdf;
    }
}