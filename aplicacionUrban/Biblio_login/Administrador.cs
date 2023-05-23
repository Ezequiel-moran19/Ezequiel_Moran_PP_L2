

namespace Biblio_Login
{
    public class Administrador
    {
        private List<Usuario> usuarios;

        /// <summary>
        /// Constructor por defecto de la clase Administrador.
        /// Crea una nueva instancia de Administrador sin usuarios.
        /// </summary>
        public Administrador()
        {
            usuarios = new List<Usuario>();
        }
        /// <summary>
        /// Constructor de la clase Administrador que permite inicializar la lista de usuarios.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios a agregar al administrador.</param>
        public Administrador(List<Usuario> usuarios) : this()
        {
            this.usuarios.AddRange(usuarios);
        }
        /// <summary>
        /// Agrega un nuevo usuario al administrador.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="contraseña">Contraseña del usuario.</param>
        /// <param name="rol">Rol del usuario.</param>
        public void AgregarUsuario(string nombre, string contraseña, RolUsuario rol)
        {
            Usuario nuevoUsuario = new Usuario(nombre, contraseña, rol);
            usuarios.Add(nuevoUsuario);
        }
        /// <summary>
        /// Obtiene la lista de usuarios del administrador.
        /// </summary>
        /// <returns>Lista de usuarios.</returns>
        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }     
    }
}

