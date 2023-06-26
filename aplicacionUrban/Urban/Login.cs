
using Biblio_Login;
using System.Windows.Forms;
using Urban;
using web_login;

namespace web_login
{
    public partial class Login : Form
    {

        public List<Usuario> usuarios;
        public static Usuario UsuarioLogueado { get; set; }
        public string User_verificar { get; set; }
        public string Contra_verificar { get; set; }
        public Login()
        {
            InitializeComponent();
            usuarios = ArchivoUsuarios.ObtenerUsuarios();
            listBoxUsuarios.DisplayMember = "NombreUsuario";
            listBoxUsuarios.DataSource = usuarios;
        }
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
        private void AbrirPortalAdmin()
        {
            PortalAdmin portalAdmin = new(usuarios);
            portalAdmin.Show();
            portalAdmin.BringToFront();
            UsuarioLogueado = portalAdmin.UsuarioLogueado;
            Close();
        }
        private void AbrirPortalVendedor(string nombreUsuario)
        {
            Vendedor vendedor = new(nombreUsuario, Contra_verificar, RolUsuario.Vendedor);
            PortalVendedor portalVendedor = new(vendedor);
            portalVendedor.Show();
            portalVendedor.BringToFront();
            UsuarioLogueado = portalVendedor.Vendedor;
            Close();
        }
        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void ListBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem is Usuario usuarioSeleccionado)
            {
                Txt_Usuario.Text = usuarioSeleccionado.Nombre;
                txt_Contraseña.Text = usuarioSeleccionado.Contraseña;
            }
        }
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
