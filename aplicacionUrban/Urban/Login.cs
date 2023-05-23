
using Biblio_Login;
using System.Windows.Forms;
using Urban;
using web_login;

namespace web_login
{
    public partial class Login : Form
    {
        private string user_verificar;

        private string contra_verificar;

        public List<Usuario> usuarios;
        /// <summary>
        /// Usuario actualmente logueado.
        /// </summary>
        public static Usuario UsuarioLogueado { get; set; }
        /// <summary>
        /// Nombre de usuario a verificar.
        /// </summary>
        public string User_verificar { get => user_verificar; set => user_verificar = value; }
        /// <summary>
        /// Contraseña a verificar.
        /// </summary>
        public string Contra_verificar { get => contra_verificar; set => contra_verificar = value; }
        /// <summary>
        /// Constructor de la clase Login.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            ArchivoUsuarios archivo = new("datos.txt");
            usuarios = archivo.ObtenerUsuarios();
            listBoxUsuarios.DisplayMember = "NombreUsuario";
            listBoxUsuarios.DataSource = usuarios;
        }
        /// <summary>
        /// Verifica las credenciales de inicio de sesión.
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario.</param>
        /// <param name="contrasena">Contraseña.</param>
        /// <returns>El objeto Usuario correspondiente si las credenciales son válidas, o null si no lo son.</returns>
        public Usuario? VerificarCredenciales(string nombreUsuario, string contrasena)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombreUsuario && usuario.Contraseña == contrasena)
                {
                    return usuario;
                }
            }
            return null;
        }
        /// <summary>
        /// Abre el formulario PortalAdmin.
        /// </summary>
        private void AbrirPortalAdmin()
        {
            PortalAdmin portalAdmin = new(usuarios);
            portalAdmin.Show();
            portalAdmin.BringToFront();
            UsuarioLogueado = portalAdmin.UsuarioLogueado;
            Close();
        }
        /// <summary>
        /// Abre el formulario PortalVendedor.
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario.</param>
        private void AbrirPortalVendedor(string nombreUsuario)
        {
            Vendedor vendedor = new(nombreUsuario, Contra_verificar);
            PortalVendedor portalVendedor = new(vendedor);
            portalVendedor.Show();
            portalVendedor.BringToFront();
            UsuarioLogueado = portalVendedor.Vendedor;
            Close();
        }
        /// <summary>
        /// Evento KeyPress del campo de texto "Txt_Usuario".
        /// </summary>
        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese el carácter no válido
            }
        }
        /// <summary>
        /// Evento Click del botón "Btn_Salir".
        /// </summary>
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        /// <summary>
        /// Evento SelectedIndexChanged del control "listBoxUsuarios".
        /// </summary>
        private void ListBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem is Usuario usuarioSeleccionado)
            {
                Txt_Usuario.Text = usuarioSeleccionado.Nombre;
                txt_Contraseña.Text = usuarioSeleccionado.Contraseña;
            }
        }
        /// <summary>
        /// Evento Click del botón "Bton_Ingresar".
        /// </summary>
        private void Bton_Ingresar_Click(object sender, EventArgs e)
        {
            User_verificar = Txt_Usuario.Text;
            Contra_verificar = txt_Contraseña.Text;

            Usuario usuario = VerificarCredenciales(User_verificar, Contra_verificar);
            if (usuario == null)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
            else
            {
                if (usuario.Rol == RolUsuario.Administrador)
                {
                    IngresarComoAdministrador();
                }
                else if (usuario.Rol == RolUsuario.Vendedor)
                {
                    IngresarComoVendedor(usuario.Nombre);
                }
            }
        }
        /// <summary>
        /// Verifica y abre el formulario PortalAdmin.
        /// </summary>
        private void IngresarComoAdministrador()
        {
            if (Application.OpenForms.OfType<PortalAdmin>().Any())
            {
                MessageBox.Show("Ya hay una instancia del formulario PortalAdmin abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Application.OpenForms.OfType<PortalVendedor>().Any())
            {
                MessageBox.Show("Ya hay un usuario vendedor logueado. Cierre sesión primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AbrirPortalAdmin();
        }

        /// <summary>
        /// Verifica y abre el formulario PortalVendedor.
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario.</param>
        private void IngresarComoVendedor(string nombreUsuario)
        {
            if (Application.OpenForms.OfType<PortalVendedor>().Any())
            {
                MessageBox.Show("Ya hay una instancia del formulario PortalVendedor abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Application.OpenForms.OfType<PortalAdmin>().Any())
            {
                MessageBox.Show("Ya hay un usuario administrador logueado. Cierre sesión primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AbrirPortalVendedor(nombreUsuario);
        }
    }
}
