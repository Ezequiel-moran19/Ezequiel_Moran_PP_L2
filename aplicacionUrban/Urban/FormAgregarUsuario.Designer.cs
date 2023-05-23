namespace web_login
{
    partial class FormAgregarUsuario
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
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            cmbRol = new ComboBox();
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(258, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(206, 23);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += TxtNombre_KeyPress;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(258, 120);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(206, 23);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(258, 163);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(206, 23);
            cmbRol.TabIndex = 2;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.AutoSize = true;
            btn_Aceptar.BackColor = Color.FromArgb(128, 128, 255);
            btn_Aceptar.FlatStyle = FlatStyle.Popup;
            btn_Aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Aceptar.ForeColor = Color.Black;
            btn_Aceptar.Location = new Point(367, 210);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(97, 25);
            btn_Aceptar.TabIndex = 3;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += Btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(128, 128, 255);
            btn_Cancelar.FlatStyle = FlatStyle.Popup;
            btn_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(258, 212);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(103, 23);
            btn_Cancelar.TabIndex = 4;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(258, 36);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 5;
            label1.Text = "Agregar Usuario";
            // 
            // FormAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(758, 367);
            Controls.Add(label1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Controls.Add(cmbRol);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtContraseña;
        private ComboBox cmbRol;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label label1;
    }
}