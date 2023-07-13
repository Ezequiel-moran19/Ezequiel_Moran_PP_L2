namespace CapaPresentacion.Modal
{
    partial class MD_Proveedor
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtBusqueda = new TextBox();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            cmbBusqueda = new ComboBox();
            label10 = new Label();
            label1 = new Label();
            dgvData = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Location = new Point(506, 38);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(162, 23);
            txtBusqueda.TabIndex = 157;
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
            btnLimpiarBuscador.Location = new Point(728, 39);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(33, 22);
            btnLimpiarBuscador.TabIndex = 156;
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
            btnBuscar.Location = new Point(683, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 22);
            btnBuscar.TabIndex = 155;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(380, 38);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(112, 23);
            cmbBusqueda.TabIndex = 154;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(301, 42);
            label10.Name = "label10";
            label10.Size = new Size(65, 13);
            label10.TabIndex = 153;
            label10.Text = "Buscar por:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(759, 46);
            label1.TabIndex = 152;
            label1.Text = "Lista de Proveedores";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { id, Documento, RazonSocial });
            dgvData.Location = new Point(25, 86);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            dgvData.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvData.RowTemplate.Height = 28;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(759, 338);
            dgvData.TabIndex = 151;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
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
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 180;
            // 
            // MD_Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBusqueda);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(cmbBusqueda);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Name = "MD_Proveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD_Proveedor";
            Load += MD_Proveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private ComboBox cmbBusqueda;
        private Label label10;
        private Label label1;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn RazonSocial;
    }
}