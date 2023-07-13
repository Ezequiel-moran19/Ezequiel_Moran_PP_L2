namespace Urban
{
    partial class FrmCategoria
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
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label8 = new Label();
            btn_Limpiar = new FontAwesome.Sharp.IconButton();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            btn_Agregar = new FontAwesome.Sharp.IconButton();
            cmbEstado = new ComboBox();
            label7 = new Label();
            txtDescripcion = new TextBox();
            label9 = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(121, 138);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(25, 23);
            txtIndice.TabIndex = 127;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Location = new Point(694, 90);
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
            btnLimpiarBuscador.Location = new Point(898, 90);
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
            btnBuscar.Location = new Point(853, 90);
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
            cmbBusqueda.Location = new Point(585, 90);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(103, 23);
            cmbBusqueda.TabIndex = 123;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(514, 94);
            label10.Name = "label10";
            label10.Size = new Size(65, 13);
            label10.TabIndex = 122;
            label10.Text = "Buscar por:";
            // 
            // txtId
            // 
            txtId.Location = new Point(152, 138);
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
            label1.Location = new Point(204, 69);
            label1.Name = "label1";
            label1.Size = new Size(750, 60);
            label1.TabIndex = 120;
            label1.Text = "Lista de Categorias";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, Descripcion, EstadoValor, Estado });
            dgvData.Location = new Point(202, 132);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(752, 335);
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
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 150;
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
            label8.Location = new Point(12, 118);
            label8.Name = "label8";
            label8.Size = new Size(115, 17);
            label8.TabIndex = 118;
            label8.Text = "Detalle Categoria";
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
            btn_Limpiar.Location = new Point(17, 266);
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
            btn_Eliminar.Location = new Point(17, 293);
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
            btn_Agregar.Location = new Point(17, 238);
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
            cmbEstado.Location = new Point(19, 209);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(158, 23);
            cmbEstado.TabIndex = 114;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 193);
            label7.Name = "label7";
            label7.Size = new Size(45, 13);
            label7.TabIndex = 112;
            label7.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(18, 167);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(158, 23);
            txtDescripcion.TabIndex = 106;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 153);
            label9.Name = "label9";
            label9.Size = new Size(70, 13);
            label9.TabIndex = 101;
            label9.Text = "Descripcion:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.White;
            lblUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario.Dock = DockStyle.Left;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(198, 484);
            lblUsuario.TabIndex = 100;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(954, 484);
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
            Controls.Add(txtDescripcion);
            Controls.Add(label9);
            Controls.Add(lblUsuario);
            Name = "FrmCategoria";
            Text = "FmrCategoria";
            Load += FrmCategoria_Load;
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
        private TextBox txtDescripcion;
        private Label label9;
        private Label lblUsuario;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}