namespace Urban
{
    partial class FrmClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtIndice = new TextBox();
            txtBusqueda = new TextBox();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            cmbBusqueda = new ComboBox();
            label10 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label8 = new Label();
            btn_Limpiar = new FontAwesome.Sharp.IconButton();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            btn_Agregar = new FontAwesome.Sharp.IconButton();
            cmbEstado = new ComboBox();
            label7 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(120, 97);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(25, 23);
            txtIndice.TabIndex = 127;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Location = new Point(703, 102);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(153, 23);
            txtBusqueda.TabIndex = 126;
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
            btnLimpiarBuscador.Location = new Point(907, 102);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(39, 23);
            btnLimpiarBuscador.TabIndex = 125;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
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
            btnBuscar.Location = new Point(862, 102);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 23);
            btnBuscar.TabIndex = 124;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(594, 102);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(103, 23);
            cmbBusqueda.TabIndex = 123;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(523, 106);
            label10.Name = "label10";
            label10.Size = new Size(65, 13);
            label10.TabIndex = 122;
            label10.Text = "Buscar por:";
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 97);
            txtId.Name = "txtId";
            txtId.Size = new Size(25, 23);
            txtId.TabIndex = 121;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 89);
            label1.Name = "label1";
            label1.Size = new Size(750, 47);
            label1.TabIndex = 120;
            label1.Text = "Lista de clientes";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Documento, Nombre, Correo, Telefono, EstadoValor, Estado });
            dgvData.Location = new Point(206, 141);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(752, 339);
            dgvData.TabIndex = 119;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Completo";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 86);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 118;
            label8.Text = "Detalle Cliente";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.Blue;
            btn_Limpiar.Cursor = Cursors.Hand;
            btn_Limpiar.FlatAppearance.BorderColor = Color.Black;
            btn_Limpiar.FlatStyle = FlatStyle.Flat;
            btn_Limpiar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Limpiar.ForeColor = Color.White;
            btn_Limpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Limpiar.IconColor = Color.Black;
            btn_Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Limpiar.Location = new Point(16, 350);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(158, 23);
            btn_Limpiar.TabIndex = 117;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.Red;
            btn_Eliminar.Cursor = Cursors.Hand;
            btn_Eliminar.FlatAppearance.BorderColor = Color.Black;
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Eliminar.IconColor = Color.Black;
            btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar.Location = new Point(16, 377);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(158, 23);
            btn_Eliminar.TabIndex = 116;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.ForestGreen;
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.FlatAppearance.BorderColor = Color.Black;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Agregar.ForeColor = Color.White;
            btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Agregar.IconColor = Color.Black;
            btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Agregar.Location = new Point(16, 322);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(158, 23);
            btn_Agregar.TabIndex = 115;
            btn_Agregar.Text = "Guardar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(16, 292);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(158, 23);
            cmbEstado.TabIndex = 114;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 276);
            label7.Name = "label7";
            label7.Size = new Size(42, 13);
            label7.TabIndex = 112;
            label7.Text = "Estado";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(18, 202);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(158, 23);
            txtCorreo.TabIndex = 109;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(18, 244);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(158, 23);
            txtTelefono.TabIndex = 108;
            txtTelefono.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(18, 162);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 107;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Location = new Point(18, 124);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(158, 23);
            txtDocumento.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 228);
            label4.Name = "label4";
            label4.Size = new Size(51, 13);
            label4.TabIndex = 104;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 188);
            label3.Name = "label3";
            label3.Size = new Size(45, 13);
            label3.TabIndex = 103;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 149);
            label2.Name = "label2";
            label2.Size = new Size(106, 13);
            label2.TabIndex = 102;
            label2.Text = "Nombre Completo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(16, 110);
            label9.Name = "label9";
            label9.Size = new Size(91, 13);
            label9.TabIndex = 101;
            label9.Text = "Nro Documento:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.White;
            lblUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario.Dock = DockStyle.Left;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(191, 573);
            lblUsuario.TabIndex = 100;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(964, 573);
            Controls.Add(txtIndice);
            Controls.Add(txtBusqueda);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(cmbBusqueda);
            Controls.Add(label10);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Controls.Add(label8);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(lblUsuario);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIndice;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private ComboBox cmbBusqueda;
        private Label label10;
        private TextBox txtId;
        private Label label1;
        private DataGridView dgvData;
        private Label label8;
        private FontAwesome.Sharp.IconButton btn_Limpiar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private ComboBox cmbEstado;
        private Label label7;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label lblUsuario;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}