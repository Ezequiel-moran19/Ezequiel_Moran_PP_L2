namespace Urban
{
    partial class FrmContenedor
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
            menu = new MenuStrip();
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuHerramientas = new FontAwesome.Sharp.IconMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarCompra = new ToolStripMenuItem();
            subMenuVerDetalleCompra = new ToolStripMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            pnl_Contenedor = new Panel();
            btnSalir = new Button();
            menu.SuspendLayout();
            pnl_Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.RoyalBlue;
            menu.Items.AddRange(new ToolStripItem[] { menuUsuarios, iconMenuItem2, iconMenuItem1, menuHerramientas, menuCompras, menuClientes, menuProveedores });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1026, 73);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            menuUsuarios.AutoSize = false;
            menuUsuarios.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuUsuarios.ForeColor = Color.White;
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            menuUsuarios.IconColor = Color.White;
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(80, 69);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.AutoSize = false;
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            iconMenuItem2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconMenuItem2.ForeColor = Color.White;
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.White;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(122, 69);
            iconMenuItem2.Text = "Ajustes";
            iconMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(130, 22);
            toolStripMenuItem1.Text = "Categoria";
            toolStripMenuItem1.Click += categoriaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(130, 22);
            toolStripMenuItem2.Text = "Productos";
            toolStripMenuItem2.Click += productosToolStripMenuItem_Click;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconMenuItem1.ForeColor = Color.White;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.White;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(80, 69);
            iconMenuItem1.Text = "Usuarios";
            iconMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconMenuItem1.Click += menuUsuarios_Click;
            // 
            // menuHerramientas
            // 
            menuHerramientas.AutoSize = false;
            menuHerramientas.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, productosToolStripMenuItem });
            menuHerramientas.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuHerramientas.ForeColor = Color.White;
            menuHerramientas.IconChar = FontAwesome.Sharp.IconChar.None;
            menuHerramientas.IconColor = Color.White;
            menuHerramientas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuHerramientas.ImageScaling = ToolStripItemImageScaling.None;
            menuHerramientas.Name = "menuHerramientas";
            menuHerramientas.Size = new Size(122, 69);
            menuHerramientas.Text = "Ajustes";
            menuHerramientas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(130, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(130, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarCompra, subMenuVerDetalleCompra });
            menuCompras.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuCompras.ForeColor = Color.White;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            menuCompras.IconColor = Color.White;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(80, 69);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Size = new Size(137, 22);
            subMenuRegistrarCompra.Text = "Registrar";
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // subMenuVerDetalleCompra
            // 
            subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            subMenuVerDetalleCompra.Size = new Size(137, 22);
            subMenuVerDetalleCompra.Text = "Ver Detalle";
            subMenuVerDetalleCompra.Click += subMenuVerDetalleCompra_Click;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuClientes.ForeColor = Color.White;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            menuClientes.IconColor = Color.White;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(80, 69);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuProveedores.ForeColor = Color.White;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            menuProveedores.IconColor = Color.White;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(80, 69);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // pnl_Contenedor
            // 
            pnl_Contenedor.AutoSize = true;
            pnl_Contenedor.BackColor = Color.Black;
            pnl_Contenedor.Controls.Add(btnSalir);
            pnl_Contenedor.Dock = DockStyle.Fill;
            pnl_Contenedor.ForeColor = SystemColors.ControlText;
            pnl_Contenedor.Location = new Point(0, 0);
            pnl_Contenedor.Name = "pnl_Contenedor";
            pnl_Contenedor.Size = new Size(1026, 518);
            pnl_Contenedor.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(981, 73);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(45, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnCerrarSesion_Click;
            // 
            // FrmContenedor
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1026, 518);
            Controls.Add(menu);
            Controls.Add(pnl_Contenedor);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmContenedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosing += FrmContenedor_FormClosing;
            Load += FrmContenedor_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            pnl_Contenedor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuHerramientas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem subMenuRegistrarCompra;
        private ToolStripMenuItem subMenuVerDetalleCompra;
        private Panel pnl_Contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Button btnSalir;
    }
}