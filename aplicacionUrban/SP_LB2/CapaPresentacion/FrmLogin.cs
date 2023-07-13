using Urban;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaDatos.Logs;

namespace web_login
{
    public partial class FrmLogin : Form
    {
        private Logger logger;
        //
        private CN_Usuario cnUsuario;
        private List<Usuario> usuarios;
        public FrmLogin()
        {
            InitializeComponent();
            logger = new Logger();
            //
            cnUsuario = new CN_Usuario();
            usuarios = cnUsuario.Listar();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bton_Ingresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)cboUsuarios.SelectedItem;

            if (usuario != null && usuario.Clave == txt_Contraseña.Text)
            {
                FrmContenedor contenedor = new FrmContenedor(usuario);

                logger.LogInicioSesion(usuario.Nombre);

                contenedor.Show();
            }
            else
            {
                MessageBox.Show("No se encontró el usuario o la contraseña es incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*
            Usuario? usuario = new CN_Usuario().Listar().Where(u => u.Documento == txt_Dni.Text && u.Clave == txt_Contraseña.Text).FirstOrDefault();

            if (usuario != null)
            {
                FrmContenedor contenedor = new FrmContenedor(usuario);

                logger.LogInicioSesion(usuario.Nombre);

                CN_Usuario cnUsuario = new CN_Usuario();
                cnUsuario.MovimientoRegistrado += LogMovimiento;

                List<Usuario> usuarios = cnUsuario.Listar();

                contenedor.Show();
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            txt_Dni.Text = string.Empty;
            txt_Contraseña.Text = string.Empty;

            this.Show();
        }
        private void LogMovimiento(string mensaje)
        {
            logger.Log(mensaje);
        }
        private void CargarUsuariosComboBox()
        {
            cboUsuarios.DataSource = usuarios;
            cboUsuarios.DisplayMember = "Nombre"; // Ajusta el nombre de la propiedad que representa el nombre del usuario en la clase Usuario
        }
        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuarioSeleccionado = (Usuario)cboUsuarios.SelectedItem;
            txt_Dni.Text = usuarioSeleccionado.Documento;
            txt_Contraseña.Text = usuarioSeleccionado.Clave;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CargarUsuariosComboBox();
        }
    }
}
