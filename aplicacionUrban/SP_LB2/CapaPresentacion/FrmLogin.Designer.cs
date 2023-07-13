namespace web_login
{
    partial class FrmLogin
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
            label1 = new Label();
            bton_Ingresar = new Button();
            btn_Salir = new Button();
            txt_Dni = new TextBox();
            txt_Contraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(362, 75);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // bton_Ingresar
            // 
            bton_Ingresar.BackColor = Color.DodgerBlue;
            bton_Ingresar.BackgroundImageLayout = ImageLayout.Zoom;
            bton_Ingresar.Cursor = Cursors.Hand;
            bton_Ingresar.FlatStyle = FlatStyle.Popup;
            bton_Ingresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bton_Ingresar.ForeColor = Color.White;
            bton_Ingresar.Location = new Point(412, 241);
            bton_Ingresar.Name = "bton_Ingresar";
            bton_Ingresar.Size = new Size(90, 34);
            bton_Ingresar.TabIndex = 5;
            bton_Ingresar.Text = "Ingresar";
            bton_Ingresar.UseVisualStyleBackColor = false;
            bton_Ingresar.Click += Bton_Ingresar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Red;
            btn_Salir.Cursor = Cursors.Hand;
            btn_Salir.FlatStyle = FlatStyle.Popup;
            btn_Salir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.ForeColor = Color.WhiteSmoke;
            btn_Salir.Location = new Point(302, 241);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(94, 34);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Cancelar";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += Btn_Salir_Click;
            // 
            // txt_Dni
            // 
            txt_Dni.BackColor = Color.Silver;
            txt_Dni.Location = new Point(303, 139);
            txt_Dni.Name = "txt_Dni";
            txt_Dni.PlaceholderText = "Nro. Documento";
            txt_Dni.Size = new Size(199, 23);
            txt_Dni.TabIndex = 7;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.BackColor = Color.Silver;
            txt_Contraseña.Location = new Point(303, 192);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PlaceholderText = "Contraseña";
            txt_Contraseña.Size = new Size(199, 23);
            txt_Contraseña.TabIndex = 8;
            txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(303, 121);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 13;
            label2.Text = "Nro Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(303, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 14;
            label3.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 369);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bton_Ingresar);
            Controls.Add(txt_Contraseña);
            Controls.Add(btn_Salir);
            Controls.Add(txt_Dni);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bton_Ingresar;
        private Button btn_Salir;
        private TextBox txt_Dni;
        private TextBox txt_Contraseña;
        private Label label2;
        private Label label3;
    }
}