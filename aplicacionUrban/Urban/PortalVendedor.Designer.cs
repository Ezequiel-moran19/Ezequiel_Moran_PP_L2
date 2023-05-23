namespace web_login
{
    partial class PortalVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalVendedor));
            lblNombreVendedor = new Label();
            label2 = new Label();
            BtnDetalleVenta = new Button();
            btnConsultarHistorial = new Button();
            BtnConsultarMontoTotal = new Button();
            menuStrip1 = new MenuStrip();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.BackColor = Color.Transparent;
            lblNombreVendedor.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreVendedor.ForeColor = Color.FromArgb(128, 128, 255);
            lblNombreVendedor.Location = new Point(291, 42);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(103, 30);
            lblNombreVendedor.TabIndex = 1;
            lblNombreVendedor.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(73, 42);
            label2.Name = "label2";
            label2.Size = new Size(225, 30);
            label2.TabIndex = 4;
            label2.Text = "Hola, Bienvenido/a";
            // 
            // BtnDetalleVenta
            // 
            BtnDetalleVenta.BackColor = SystemColors.ActiveCaption;
            BtnDetalleVenta.BackgroundImage = Urban.Properties.Resources.Añadir_un_título__5_;
            BtnDetalleVenta.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDetalleVenta.FlatStyle = FlatStyle.Popup;
            BtnDetalleVenta.Location = new Point(275, 122);
            BtnDetalleVenta.Name = "BtnDetalleVenta";
            BtnDetalleVenta.Size = new Size(164, 147);
            BtnDetalleVenta.TabIndex = 7;
            BtnDetalleVenta.UseVisualStyleBackColor = false;
            BtnDetalleVenta.Click += BtnVerDetalleVenta_Click;
            // 
            // btnConsultarHistorial
            // 
            btnConsultarHistorial.BackColor = SystemColors.ActiveCaption;
            btnConsultarHistorial.BackgroundImage = (Image)resources.GetObject("btnConsultarHistorial.BackgroundImage");
            btnConsultarHistorial.BackgroundImageLayout = ImageLayout.Stretch;
            btnConsultarHistorial.FlatStyle = FlatStyle.Popup;
            btnConsultarHistorial.Location = new Point(73, 122);
            btnConsultarHistorial.Name = "btnConsultarHistorial";
            btnConsultarHistorial.Size = new Size(164, 147);
            btnConsultarHistorial.TabIndex = 11;
            btnConsultarHistorial.UseVisualStyleBackColor = false;
            btnConsultarHistorial.Click += BtnConsultarHistorial_Click;
            // 
            // BtnConsultarMontoTotal
            // 
            BtnConsultarMontoTotal.BackColor = SystemColors.ActiveCaption;
            BtnConsultarMontoTotal.BackgroundImage = (Image)resources.GetObject("BtnConsultarMontoTotal.BackgroundImage");
            BtnConsultarMontoTotal.BackgroundImageLayout = ImageLayout.Stretch;
            BtnConsultarMontoTotal.FlatStyle = FlatStyle.Popup;
            BtnConsultarMontoTotal.ForeColor = SystemColors.ActiveCaption;
            BtnConsultarMontoTotal.Location = new Point(472, 122);
            BtnConsultarMontoTotal.Name = "BtnConsultarMontoTotal";
            BtnConsultarMontoTotal.Size = new Size(164, 147);
            BtnConsultarMontoTotal.TabIndex = 12;
            BtnConsultarMontoTotal.UseVisualStyleBackColor = false;
            BtnConsultarMontoTotal.Click += BtnConsultarMontoTotal_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cerrarSesionToolStripMenuItem.ForeColor = Color.Black;
            cerrarSesionToolStripMenuItem.Image = (Image)resources.GetObject("cerrarSesionToolStripMenuItem.Image");
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(107, 20);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += CerrarSesionToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(73, 72);
            label1.Name = "label1";
            label1.Size = new Size(417, 30);
            label1.TabIndex = 14;
            label1.Text = "elige la opción que deseas realizar.";
            // 
            // PortalVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Urban.Properties.Resources.up__1_2;
            ClientSize = new Size(758, 367);
            Controls.Add(label1);
            Controls.Add(BtnConsultarMontoTotal);
            Controls.Add(btnConsultarHistorial);
            Controls.Add(BtnDetalleVenta);
            Controls.Add(label2);
            Controls.Add(lblNombreVendedor);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PortalVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PortalVendedor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreVendedor;
        private Label label2;
        private Button BtnDetalleVenta;
        private Button btnConsultarHistorial;
        private Button BtnConsultarMontoTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private Label label1;
    }
}