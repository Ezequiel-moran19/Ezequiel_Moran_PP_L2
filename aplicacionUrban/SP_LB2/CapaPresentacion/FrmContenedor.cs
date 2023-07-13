using CapaDatos.Logs;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion;
using FontAwesome.Sharp;
using web_login;
namespace Urban
{
    public partial class FrmContenedor : Form
    {
        private static Usuario? usuarioActual;
        private static IconMenuItem? MenuActivo = null;
        private static Form? FormularioActivo = null;
        private Logger logger;
        public FrmLogin loginForm;
        public FrmContenedor(Usuario Obj_usuario)
        {
            usuarioActual = Obj_usuario;

            InitializeComponent();
            logger = new Logger();
        }

        private void FrmContenedor_Load(object sender, EventArgs e)
        {
            List<Permiso> listPermisos = new CN_Permisos().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem Imenu in menu.Items)
            {
                bool entrado = listPermisos.Any(m => m.NombreMenu == Imenu.Name);

                if (entrado == false)
                {
                    Imenu.Visible = false;
                }
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo is not null)
            {
                MenuActivo.BackColor = Color.Black;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo is not null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            pnl_Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuHerramientas, new FrmCategoria());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuHerramientas, new FrmProducto());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new FrmCompras(usuarioActual));
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new FrmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }
        private void Logger_CierreSesionRegistrado(string usuario)
        {
            // Realiza cualquier acción adicional que desees cuando se registre el cierre de sesión.
            // Por ejemplo, puedes mostrar un mensaje en la interfaz de usuario.
            MessageBox.Show($"Cierre de sesión registrado: {usuario}");
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            logger.LogCierreSesion(usuarioActual.Nombre);
            //  FrmLogin loginForm = new FrmLogin();
            // loginForm.Show();
            this.Close();
        }

        private void FrmContenedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //logger.LogCierreSesion(usuarioActual.Nombre);

            // loginForm = new FrmLogin();
            //loginForm.Show();
        }
    }
}
