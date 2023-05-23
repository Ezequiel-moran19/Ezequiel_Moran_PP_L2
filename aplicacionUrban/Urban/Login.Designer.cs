namespace web_login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            bton_Ingresar = new Button();
            btn_Salir = new Button();
            Txt_Usuario = new TextBox();
            txt_Contraseña = new TextBox();
            listBoxUsuarios = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(516, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // bton_Ingresar
            // 
            bton_Ingresar.BackColor = Color.Silver;
            bton_Ingresar.BackgroundImageLayout = ImageLayout.Zoom;
            bton_Ingresar.FlatStyle = FlatStyle.Popup;
            bton_Ingresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bton_Ingresar.Location = new Point(516, 228);
            bton_Ingresar.Name = "bton_Ingresar";
            bton_Ingresar.Size = new Size(140, 34);
            bton_Ingresar.TabIndex = 5;
            bton_Ingresar.Text = "Ingresar";
            bton_Ingresar.UseVisualStyleBackColor = false;
            bton_Ingresar.Click += Bton_Ingresar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Silver;
            btn_Salir.FlatStyle = FlatStyle.Popup;
            btn_Salir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location = new Point(362, 228);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(136, 34);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += Btn_Salir_Click;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.BackColor = Color.Silver;
            Txt_Usuario.Location = new Point(457, 126);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.PlaceholderText = "Nombre";
            Txt_Usuario.Size = new Size(199, 23);
            Txt_Usuario.TabIndex = 7;
            Txt_Usuario.KeyPress += Txt_Usuario_KeyPress;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.BackColor = Color.Silver;
            txt_Contraseña.Location = new Point(457, 179);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PlaceholderText = "Contraseña";
            txt_Contraseña.Size = new Size(199, 23);
            txt_Contraseña.TabIndex = 8;
            txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.BackColor = Color.Silver;
            listBoxUsuarios.BorderStyle = BorderStyle.None;
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.ItemHeight = 15;
            listBoxUsuarios.Location = new Point(12, 35);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(275, 240);
            listBoxUsuarios.TabIndex = 9;
            listBoxUsuarios.SelectedIndexChanged += ListBoxUsuario_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Urban.Properties.Resources.icons8_nombre_24;
            pictureBox1.Location = new Point(362, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(362, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Urban.Properties.Resources.account_member_login_user_icon_220048;
            pictureBox3.Location = new Point(345, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Urban.Properties.Resources.up__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 369);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(bton_Ingresar);
            Controls.Add(listBoxUsuarios);
            Controls.Add(pictureBox2);
            Controls.Add(txt_Contraseña);
            Controls.Add(btn_Salir);
            Controls.Add(Txt_Usuario);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bton_Ingresar;
        private Button btn_Salir;
        private TextBox Txt_Usuario;
        private TextBox txt_Contraseña;
        private ListBox listBoxUsuarios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}