namespace web_login
{
    partial class PortalAdmin
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
            label1 = new Label();
            lstUsuarios = new ListBox();
            menuStrip1 = new MenuStrip();
            AgregarToolStripMenuItem1 = new ToolStripMenuItem();
            EliminarToolStripMenuItem = new ToolStripMenuItem();
            AtrasToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(108, 40);
            label1.TabIndex = 0;
            label1.Text = "Portal ";
            // 
            // lstUsuarios
            // 
            lstUsuarios.BackColor = Color.Gray;
            lstUsuarios.BorderStyle = BorderStyle.None;
            lstUsuarios.ForeColor = Color.White;
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(311, 29);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(281, 255);
            lstUsuarios.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { AgregarToolStripMenuItem1, EliminarToolStripMenuItem, AtrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // AgregarToolStripMenuItem1
            // 
            AgregarToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarToolStripMenuItem1.ForeColor = Color.White;
            AgregarToolStripMenuItem1.Image = Urban.Properties.Resources.person_add_icon_icons_com_50077;
            AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1";
            AgregarToolStripMenuItem1.Size = new Size(80, 20);
            AgregarToolStripMenuItem1.Text = "Agregar";
            AgregarToolStripMenuItem1.Click += AgregarToolStripMenuItem1_Click;
            // 
            // EliminarToolStripMenuItem
            // 
            EliminarToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EliminarToolStripMenuItem.ForeColor = Color.White;
            EliminarToolStripMenuItem.Image = Urban.Properties.Resources.eraser_garbage_delete_trash_erase_remove_bin_icon_232819;
            EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            EliminarToolStripMenuItem.Size = new Size(79, 20);
            EliminarToolStripMenuItem.Text = "Eliminar";
            EliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_Click_1;
            // 
            // AtrasToolStripMenuItem
            // 
            AtrasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AtrasToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            AtrasToolStripMenuItem.Name = "AtrasToolStripMenuItem";
            AtrasToolStripMenuItem.Size = new Size(91, 20);
            AtrasToolStripMenuItem.Text = "Cerrar sesion";
            AtrasToolStripMenuItem.Click += AtrasToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(216, 40);
            label2.TabIndex = 7;
            label2.Text = "Administrador";
            // 
            // PortalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Urban.Properties.Resources.up__1_1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(758, 367);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(lstUsuarios);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PortalAdmin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PortalAdmin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstUsuarios;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem EliminarToolStripMenuItem;
        private ToolStripMenuItem AgregarToolStripMenuItem1;
        private ToolStripMenuItem AtrasToolStripMenuItem;
        private Label label2;
    }
}