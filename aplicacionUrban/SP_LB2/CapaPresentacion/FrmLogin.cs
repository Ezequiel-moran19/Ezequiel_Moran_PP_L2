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
        public FrmLogin()
        {
            InitializeComponent();
            logger = new Logger();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bton_Ingresar_Click(object sender, EventArgs e)
        {
            Usuario? usuario = new CN_Usuario().Listar().Where(u => u.Documento == txt_Dni.Text && u.Clave == txt_Contraseña.Text).FirstOrDefault();

            if (usuario != null)
            {
                FrmContenedor contenedor = new FrmContenedor(usuario);

                logger.LogInicioSesion(usuario.Nombre); // Registrar el inicio de sesión antes de mostrar el formulario

                CN_Usuario cnUsuario = new CN_Usuario();
                cnUsuario.MovimientoRegistrado += LogMovimiento;

                List<Usuario> usuarios = cnUsuario.Listar();

                contenedor.Show();
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
    }
}
