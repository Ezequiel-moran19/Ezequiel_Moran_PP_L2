namespace Urban
{
    partial class FormVerDetalleVenta
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
            dgvHistorialVentas = new DataGridView();
            txtCodigoCompra = new TextBox();
            btnDetalleVenta = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.BackgroundColor = Color.Silver;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Location = new Point(22, 35);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.RowTemplate.Height = 25;
            dgvHistorialVentas.Size = new Size(367, 306);
            dgvHistorialVentas.TabIndex = 0;
            // 
            // txtCodigoCompra
            // 
            txtCodigoCompra.Location = new Point(414, 73);
            txtCodigoCompra.Name = "txtCodigoCompra";
            txtCodigoCompra.Size = new Size(180, 23);
            txtCodigoCompra.TabIndex = 1;
            // 
            // btnDetalleVenta
            // 
            btnDetalleVenta.BackColor = SystemColors.ActiveCaption;
            btnDetalleVenta.BackgroundImage = Properties.Resources.Añadir_un_título__11_;
            btnDetalleVenta.BackgroundImageLayout = ImageLayout.Stretch;
            btnDetalleVenta.FlatStyle = FlatStyle.Popup;
            btnDetalleVenta.Location = new Point(414, 126);
            btnDetalleVenta.Name = "btnDetalleVenta";
            btnDetalleVenta.Size = new Size(180, 102);
            btnDetalleVenta.TabIndex = 2;
            btnDetalleVenta.UseVisualStyleBackColor = false;
            btnDetalleVenta.Click += BtnDetalleVenta_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(414, 35);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese código de compra";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { atrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            atrasToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            atrasToolStripMenuItem.Image = Properties.Resources.previous_left_direction_rewind_backward_back_arrow_icon_2328033;
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(71, 20);
            atrasToolStripMenuItem.Text = "Volver";
            atrasToolStripMenuItem.Click += VolverToolStripMenuItem_Click;
            // 
            // FormVerDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(758, 367);
            Controls.Add(label1);
            Controls.Add(btnDetalleVenta);
            Controls.Add(txtCodigoCompra);
            Controls.Add(dgvHistorialVentas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVerDetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerDetalleVentaForm";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorialVentas;
        private TextBox txtCodigoCompra;
        private Button btnDetalleVenta;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atrasToolStripMenuItem;
    }
}