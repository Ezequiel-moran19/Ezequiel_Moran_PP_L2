using Biblio_Login;
using Urban;

namespace web_login
{
    public partial class PortalAdmin : Form
    {
        private readonly List<Usuario> usuarios = new();

        private Administrador usuariosService;
        private readonly ArchivoUsuarios archivoUsuarios;
        public Usuario UsuarioLogueado { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public PortalAdmin()
        {
            InitializeComponent();
            this.usuariosService = new Administrador(usuarios);
            Usuarios = usuariosService.ObtenerUsuarios();
            archivoUsuarios = new ArchivoUsuarios("datos.txt");
            ActualizarListaUsuarios();
        }
        /// <summary>
        /// Constructor de la clase PortalAdmin que recibe una lista de usuarios.
        /// </summary>
        /// <param name="usuarios">La lista de usuarios a agregar en el portal.</param>
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
        /// Guarda la lista de usuarios en un archivo.
        /// </summary>
        public void GuardarUsuariosEnArchivo()
        {
            archivoUsuarios.GuardarUsuariosEnArchivo(Usuarios);
        }
        /// <summary>
        /// Maneja el evento Click del botón "Agregar Usuario" en el menú.
        /// Abre el formulario para agregar un nuevo usuario y agrega el usuario a la lista de usuarios del portal.
        /// </summary>
        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new(this);
            formAgregarUsuario.Show();

            Usuario nuevoUsuario = new Vendedor(formAgregarUsuario.Nombre, formAgregarUsuario.Contraseña);

            Administrador usuariosService = new();
            usuariosService.AgregarUsuario(nuevoUsuario.Nombre, nuevoUsuario.Contraseña, nuevoUsuario.Rol);

            ActualizarListaUsuarios();
            GuardarUsuariosEnArchivo();
        }
        /// <summary>
        /// Maneja el evento Click del botón "Eliminar Usuario" en el menú.
        /// Elimina el usuario seleccionado de la lista de usuarios del portal y del archivo correspondiente.
        /// </summary>
        private void EliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem != null)
            {
                Usuario usuarioSeleccionado = (Usuario)lstUsuarios.SelectedItem;

                Usuarios.Remove(usuarioSeleccionado);
                ActualizarListaUsuarios();

                string archivoUsuario = $"{usuarioSeleccionado.Nombre}.txt";
                if (File.Exists(archivoUsuario))
                {
                    File.Delete(archivoUsuario);
                    MessageBox.Show("Usuario eliminado correctamente.");
                }

                GuardarUsuariosEnArchivo();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un usuario para eliminar.");
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón "Atrás" en el menú.
        /// Cierra el formulario actual.
        /// </summary>

        private void AtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
