using Biblio_Login;
using Urban;

namespace web_login
{
    public partial class PortalAdmin : Form
    {
        private readonly List<Usuario> usuarios = new();

        private Administrador usuariosService;
        public Usuario UsuarioLogueado { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public PortalAdmin()
        {
            InitializeComponent();
            this.usuariosService = new Administrador(usuarios);
            Usuarios = usuariosService.ObtenerUsuarios();
            ActualizarListaUsuarios();
        }
        /// <summary>
        /// Constructor sobrecargado de la clase PortalAdmin.
        /// </summary>
        /// <param name="usuarios">La lista de usuarios a agregar.</param>
        public PortalAdmin(List<Usuario> usuarios) : this()
        {
            foreach (Usuario usuario in usuarios)
            {
                if (!Usuarios.Contains(usuario)) // evitar duplicados
                {
                    Usuarios.Add(usuario);
                }
            }
            ActualizarListaUsuarios();
        }
        /// <summary>
        /// Actualiza la lista de usuarios en el formulario.
        /// </summary>
        public void ActualizarListaUsuarios()
        {
            lstUsuarios.Items.Clear();
            foreach (Usuario usuario in Usuarios)
            {
                lstUsuarios.Items.Add(usuario);
            }
        }
        /// <summary>
        /// Guarda los usuarios en el archivo.
        /// </summary>
        public void GuardarUsuariosEnArchivo()
        {
            ArchivoUsuarios.GuardarUsuariosEnArchivo(Usuarios);
        }
        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new(this);
            formAgregarUsuario.Show();

            Usuario nuevoUsuario = new Vendedor(formAgregarUsuario.Nombre, formAgregarUsuario.Contraseña, formAgregarUsuario.Rol);

            Administrador usuariosService = new();
            usuariosService.AgregarUsuario(nuevoUsuario.Nombre, nuevoUsuario.Contraseña, nuevoUsuario.Rol);

            ActualizarListaUsuarios();
            GuardarUsuariosEnArchivo();
        }
        private void EliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem != null)
            {
                Usuario usuarioSeleccionado = (Usuario)lstUsuarios.SelectedItem;
                usuariosService.EliminarUsuario(usuarioSeleccionado);

                ActualizarListaUsuarios();

                string nombre= ArchivoUsuarios.ObtenerNombreArchivoUsuario(usuarioSeleccionado);
                ArchivoUsuarios.EliminarArchivo(nombre);
                MessageBox.Show("Usuario eliminado correctamente.");

                GuardarUsuariosEnArchivo();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un usuario para eliminar.");
            }
        }
        private void AtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
