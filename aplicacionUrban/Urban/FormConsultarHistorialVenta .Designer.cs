namespace Urban
{
    partial class FormConsultarHistorialVenta
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
            lblVentas = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            VolvelToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.BackgroundColor = Color.Silver;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Location = new Point(12, 57);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.RowTemplate.Height = 25;
            dgvHistorialVentas.Size = new Size(367, 306);
            dgvHistorialVentas.TabIndex = 0;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.Transparent;
            lblVentas.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVentas.ForeColor = Color.FromArgb(128, 128, 255);
            lblVentas.Location = new Point(291, 31);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(64, 23);
            lblVentas.TabIndex = 1;
            lblVentas.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(277, 23);
            label1.TabIndex = 2;
            label1.Text = "Cantidad de ventas realizadas";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { VolvelToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // VolvelToolStripMenuItem
            // 
            VolvelToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VolvelToolStripMenuItem.Image = Properties.Resources.previous_left_direction_rewind_backward_back_arrow_icon_2328035;
            VolvelToolStripMenuItem.Name = "VolvelToolStripMenuItem";
            VolvelToolStripMenuItem.Size = new Size(71, 20);
            VolvelToolStripMenuItem.Text = "Volver";
            VolvelToolStripMenuItem.Click += VolverToolStripMenuItem_Click;
            // 
            // FormConsultarHistorialVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(758, 367);
            Controls.Add(label1);
            Controls.Add(lblVentas);
            Controls.Add(dgvHistorialVentas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultarHistorialVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarHistorialVentaForm";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorialVentas;
        private Label lblVentas;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem VolvelToolStripMenuItem;
    }
}