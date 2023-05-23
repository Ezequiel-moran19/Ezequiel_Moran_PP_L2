namespace Urban
{
    partial class FormConsultarMontoTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarMontoTotal));
            btnCredito = new Button();
            dgvHistorialVentas = new DataGridView();
            menuStrip1 = new MenuStrip();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCredito
            // 
            btnCredito.BackColor = Color.FromArgb(255, 192, 128);
            btnCredito.BackgroundImage = (Image)resources.GetObject("btnCredito.BackgroundImage");
            btnCredito.BackgroundImageLayout = ImageLayout.Stretch;
            btnCredito.FlatStyle = FlatStyle.Popup;
            btnCredito.Location = new Point(445, 121);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(150, 99);
            btnCredito.TabIndex = 11;
            btnCredito.UseVisualStyleBackColor = false;
            btnCredito.Click += BtnCredito_Click;
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.BackgroundColor = Color.Silver;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Location = new Point(34, 36);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.RowTemplate.Height = 25;
            dgvHistorialVentas.Size = new Size(367, 306);
            dgvHistorialVentas.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { atrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            atrasToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            atrasToolStripMenuItem.Image = Properties.Resources.previous_left_direction_rewind_backward_back_arrow_icon_2328034;
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(71, 20);
            atrasToolStripMenuItem.Text = "Volver";
            atrasToolStripMenuItem.Click += VolverToolStripMenuItem_Click;
            // 
            // FormConsultarMontoTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.up__1_3;
            ClientSize = new Size(758, 367);
            Controls.Add(btnCredito);
            Controls.Add(dgvHistorialVentas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormConsultarMontoTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarMontoTotal";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCredito;
        private DataGridView dgvHistorialVentas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atrasToolStripMenuItem;
    }
}