namespace Urban
{
    partial class Contenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            btn_iniciar = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = Color.FromArgb(64, 64, 64);
            btn_iniciar.FlatStyle = FlatStyle.Popup;
            btn_iniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_iniciar.ForeColor = Color.Black;
            btn_iniciar.ImageKey = "(ninguna)";
            btn_iniciar.Location = new Point(397, 264);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(169, 26);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Iniciar sesion";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += Btn_iniciar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(64, 64, 64);
            btn_salir.FlatStyle = FlatStyle.Popup;
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.Black;
            btn_salir.ImageKey = "(ninguna)";
            btn_salir.Location = new Point(181, 264);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(169, 26);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "Cerrar";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += Btn_salir_Click;
            // 
            // Contenedor
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 369);
            Controls.Add(btn_salir);
            Controls.Add(btn_iniciar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Contenedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_iniciar;
        private Button btn_salir;
    }
}