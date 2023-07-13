namespace Urban
{
    partial class FrmCompras
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
            label1 = new Label();
            grp_InfoCompra = new GroupBox();
            label3 = new Label();
            cmbTipoDocumento = new ComboBox();
            txtFecha = new TextBox();
            label2 = new Label();
            grp_InfoProveedor = new GroupBox();
            txtIdProveedor = new TextBox();
            txtRazonSocial = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            txtDocProveedor = new TextBox();
            label5 = new Label();
            grp_InfoProducto = new GroupBox();
            txtCantidad = new NumericUpDown();
            label10 = new Label();
            txtPrecioCompra = new TextBox();
            label8 = new Label();
            txtPrecioVenta = new TextBox();
            label9 = new Label();
            txtIdProducto = new TextBox();
            txtProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            txtCodProducto = new TextBox();
            label7 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            txtTotalAPagar = new TextBox();
            label11 = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            grp_InfoCompra.SuspendLayout();
            grp_InfoProveedor.SuspendLayout();
            grp_InfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 85);
            label1.Name = "label1";
            label1.Size = new Size(777, 408);
            label1.TabIndex = 120;
            label1.Text = "Registrar Compra";
            // 
            // grp_InfoCompra
            // 
            grp_InfoCompra.BackColor = Color.White;
            grp_InfoCompra.Controls.Add(label3);
            grp_InfoCompra.Controls.Add(cmbTipoDocumento);
            grp_InfoCompra.Controls.Add(txtFecha);
            grp_InfoCompra.Controls.Add(label2);
            grp_InfoCompra.Location = new Point(137, 132);
            grp_InfoCompra.Name = "grp_InfoCompra";
            grp_InfoCompra.Size = new Size(308, 83);
            grp_InfoCompra.TabIndex = 121;
            grp_InfoCompra.TabStop = false;
            grp_InfoCompra.Text = "Informacion Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 28);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo Documento";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(143, 48);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(151, 23);
            cmbTipoDocumento.TabIndex = 2;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(9, 48);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(116, 23);
            txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 28);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha";
            // 
            // grp_InfoProveedor
            // 
            grp_InfoProveedor.BackColor = Color.White;
            grp_InfoProveedor.Controls.Add(txtIdProveedor);
            grp_InfoProveedor.Controls.Add(txtRazonSocial);
            grp_InfoProveedor.Controls.Add(btnBuscar);
            grp_InfoProveedor.Controls.Add(label4);
            grp_InfoProveedor.Controls.Add(txtDocProveedor);
            grp_InfoProveedor.Controls.Add(label5);
            grp_InfoProveedor.Location = new Point(460, 132);
            grp_InfoProveedor.Name = "grp_InfoProveedor";
            grp_InfoProveedor.Size = new Size(361, 83);
            grp_InfoProveedor.TabIndex = 122;
            grp_InfoProveedor.TabStop = false;
            grp_InfoProveedor.Text = "Informacio Proveedor";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(321, 20);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(34, 23);
            txtIdProveedor.TabIndex = 99;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(204, 47);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(151, 23);
            txtRazonSocial.TabIndex = 98;
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
            btnBuscar.Location = new Point(157, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 23);
            btnBuscar.TabIndex = 97;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 29);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Razon Social";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.Location = new Point(23, 47);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(128, 23);
            txtDocProveedor.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 29);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 0;
            label5.Text = "Nro Documento";
            // 
            // grp_InfoProducto
            // 
            grp_InfoProducto.BackColor = Color.White;
            grp_InfoProducto.Controls.Add(txtCantidad);
            grp_InfoProducto.Controls.Add(label10);
            grp_InfoProducto.Controls.Add(txtPrecioCompra);
            grp_InfoProducto.Controls.Add(label8);
            grp_InfoProducto.Controls.Add(txtPrecioVenta);
            grp_InfoProducto.Controls.Add(label9);
            grp_InfoProducto.Controls.Add(txtIdProducto);
            grp_InfoProducto.Controls.Add(txtProducto);
            grp_InfoProducto.Controls.Add(btnBuscarProducto);
            grp_InfoProducto.Controls.Add(label6);
            grp_InfoProducto.Controls.Add(txtCodProducto);
            grp_InfoProducto.Controls.Add(label7);
            grp_InfoProducto.Location = new Point(137, 221);
            grp_InfoProducto.Name = "grp_InfoProducto";
            grp_InfoProducto.Size = new Size(631, 81);
            grp_InfoProducto.TabIndex = 123;
            grp_InfoProducto.TabStop = false;
            grp_InfoProducto.Text = "Informacio Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(560, 49);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(35, 23);
            txtCantidad.TabIndex = 107;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(551, 28);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 106;
            label10.Text = "Cantidad";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(345, 46);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 105;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 28);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 104;
            label8.Text = "Precio Compra";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(455, 46);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(80, 23);
            txtPrecioVenta.TabIndex = 103;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(455, 28);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 102;
            label9.Text = "Precio Venta";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(103, 20);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(34, 23);
            txtIdProducto.TabIndex = 99;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(182, 46);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(151, 23);
            txtProducto.TabIndex = 98;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.White;
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProducto.ForeColor = Color.Black;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProducto.IconColor = Color.Black;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 18;
            btnBuscarProducto.Location = new Point(143, 46);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(29, 23);
            btnBuscarProducto.TabIndex = 97;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += iconButton1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 28);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 3;
            label6.Text = "Producto";
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(9, 46);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(128, 23);
            txtCodProducto.TabIndex = 1;
            txtCodProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 28);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 0;
            label7.Text = "Cod. Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregar.IconColor = Color.LimeGreen;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(781, 234);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 68);
            btnAgregar.TabIndex = 125;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += iconButton2_Click;
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.ForeColor = Color.Black;
            txtTotalAPagar.Location = new Point(774, 397);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.Size = new Size(96, 23);
            txtTotalAPagar.TabIndex = 127;
            txtTotalAPagar.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(776, 379);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 126;
            label11.Text = "Total a Pagar";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.IconSize = 20;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(774, 436);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 36);
            btnRegistrar.TabIndex = 128;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, BtnEliminar });
            dgvdata.Location = new Point(120, 322);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(633, 171);
            dgvdata.TabIndex = 129;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PrecioCompra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "";
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Width = 40;
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(972, 524);
            Controls.Add(dgvdata);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTotalAPagar);
            Controls.Add(label11);
            Controls.Add(btnAgregar);
            Controls.Add(grp_InfoProducto);
            Controls.Add(grp_InfoProveedor);
            Controls.Add(grp_InfoCompra);
            Controls.Add(label1);
            Name = "FrmCompras";
            Text = "FmrCompras";
            Load += FrmCompras_Load;
            grp_InfoCompra.ResumeLayout(false);
            grp_InfoCompra.PerformLayout();
            grp_InfoProveedor.ResumeLayout(false);
            grp_InfoProveedor.PerformLayout();
            grp_InfoProducto.ResumeLayout(false);
            grp_InfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grp_InfoCompra;
        private Label label3;
        private ComboBox cmbTipoDocumento;
        private TextBox txtFecha;
        private Label label2;
        private GroupBox grp_InfoProveedor;
        private Label label4;
        private TextBox txtDocProveedor;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtIdProveedor;
        private TextBox txtRazonSocial;
        private GroupBox grp_InfoProducto;
        private TextBox txtIdProducto;
        private TextBox txtProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label label6;
        private TextBox txtCodProducto;
        private Label label7;
        private NumericUpDown txtCantidad;
        private Label label10;
        private TextBox txtPrecioCompra;
        private Label label8;
        private TextBox txtPrecioVenta;
        private Label label9;

        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox txtTotalAPagar;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn BtnEliminar;
    }
}