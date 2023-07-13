namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            lblUsuario = new Label();
            label8 = new Label();
            btn_Limpiar = new FontAwesome.Sharp.IconButton();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            btn_Agregar = new FontAwesome.Sharp.IconButton();
            cmbEstado = new ComboBox();
            cmbrol = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtConfirmarClave = new TextBox();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtId = new TextBox();
            label10 = new Label();
            cmbBusqueda = new ComboBox();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            txtIndice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.White;
            lblUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario.Dock = DockStyle.Left;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(198, 467);
            lblUsuario.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 84);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 90;
            label8.Text = "Detalle Usuario";
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
            btn_Limpiar.Location = new Point(20, 426);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(158, 23);
            btn_Limpiar.TabIndex = 89;
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
            btn_Eliminar.Location = new Point(20, 453);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(158, 23);
            btn_Eliminar.TabIndex = 88;
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
            btn_Agregar.Location = new Point(20, 398);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(158, 23);
            btn_Agregar.TabIndex = 87;
            btn_Agregar.Text = "Guardar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(20, 368);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(158, 23);
            cmbEstado.TabIndex = 86;
            // 
            // cmbrol
            // 
            cmbrol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrol.FormattingEnabled = true;
            cmbrol.Location = new Point(20, 326);
            cmbrol.Name = "cmbrol";
            cmbrol.Size = new Size(158, 23);
            cmbrol.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 352);
            label7.Name = "label7";
            label7.Size = new Size(42, 13);
            label7.TabIndex = 84;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 311);
            label6.Name = "label6";
            label6.Size = new Size(24, 13);
            label6.TabIndex = 83;
            label6.Text = "Rol";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(20, 284);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.Size = new Size(158, 23);
            txtConfirmarClave.TabIndex = 82;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(20, 200);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(158, 23);
            txtCorreo.TabIndex = 81;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(20, 242);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(158, 23);
            txtClave.TabIndex = 80;
            txtClave.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 79;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Location = new Point(20, 122);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(158, 23);
            txtDocumento.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 269);
            label5.Name = "label5";
            label5.Size = new Size(124, 13);
            label5.TabIndex = 77;
            label5.Text = "Confirmar Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 226);
            label4.Name = "label4";
            label4.Size = new Size(69, 13);
            label4.TabIndex = 76;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 186);
            label3.Name = "label3";
            label3.Size = new Size(45, 13);
            label3.TabIndex = 75;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 147);
            label2.Name = "label2";
            label2.Size = new Size(107, 13);
            label2.TabIndex = 74;
            label2.Text = "Nombre Completo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 108);
            label9.Name = "label9";
            label9.Size = new Size(94, 13);
            label9.TabIndex = 73;
            label9.Text = "Nro Documento:";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdUsuario, Documento, Nombre, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvData.Location = new Point(204, 141);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(752, 339);
            dgvData.TabIndex = 91;
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
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
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
            Nombre.HeaderText = "Nombre";
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
            // Clave
            // 
            Clave.HeaderText = "Contrasena";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
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
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 89);
            label1.Name = "label1";
            label1.Size = new Size(750, 47);
            label1.TabIndex = 92;
            label1.Text = "Lista de usuarios";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 95);
            txtId.Name = "txtId";
            txtId.Size = new Size(25, 23);
            txtId.TabIndex = 93;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(519, 106);
            label10.Name = "label10";
            label10.Size = new Size(65, 13);
            label10.TabIndex = 94;
            label10.Text = "Buscar por:";
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(590, 102);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(103, 23);
            cmbBusqueda.TabIndex = 95;
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
            btnLimpiarBuscador.Location = new Point(903, 102);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(39, 23);
            btnLimpiarBuscador.TabIndex = 97;
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
            btnBuscar.Location = new Point(858, 102);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 23);
            btnBuscar.TabIndex = 96;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Location = new Point(699, 102);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(153, 23);
            txtBusqueda.TabIndex = 98;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(122, 95);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(25, 23);
            txtIndice.TabIndex = 99;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(966, 467);
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
            Controls.Add(cmbrol);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtConfirmarClave);
            Controls.Add(txtCorreo);
            Controls.Add(txtClave);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(lblUsuario);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label label8;
        private FontAwesome.Sharp.IconButton btn_Limpiar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private ComboBox cmbEstado;
        private ComboBox cmbrol;
        private Label label7;
        private Label label6;
        private TextBox txtConfirmarClave;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private DataGridView dgvData;
        private Label label1;
        private TextBox txtId;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Label label10;
        private ComboBox cmbBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private TextBox txtIndice;
    }
}