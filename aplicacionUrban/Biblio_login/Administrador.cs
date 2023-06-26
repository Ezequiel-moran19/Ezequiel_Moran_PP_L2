

namespace Biblio_Login
{
    public class Administrador
    {
        private List<Usuario> usuarios;
        /// <summary>
        /// Inicializa una nueva instancia de la clase Administrador.
        /// </summary>
        public Administrador()
        {
            usuarios = new List<Usuario>();
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase Administrador con la lista de usuarios especificada.
        /// </summary>
        /// <param name="usuarios">La lista de usuarios.</param>
        public Administrador(List<Usuario> usuarios) : this()
        {
            this.usuarios.AddRange(usuarios);
        }
        /// <summary>
        /// Agrega un nuevo usuario con el nombre, contraseña y rol especificados.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="contraseña">La contraseña del usuario.</param>
        /// <param name="rol">El rol del usuario.</param>
        public void AgregarUsuario(string nombre, string contraseña, RolUsuario rol)
        {
            Usuario nuevoUsuario = new Vendedor(nombre, contraseña, rol);
            usuarios += nuevoUsuario;
        }
        /// <summary>
        /// Obtiene la lista de usuarios.
        /// </summary>
        /// <returns>La lista de usuarios.</returns>
        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }
        /// <summary>
        /// Elimina un usuario.
        /// </summary>
        /// <param name="usuario">El usuario a eliminar.</param>
        public void EliminarUsuario(Usuario usuario)
        {
            usuarios -=  usuario;
        }
    }
}

