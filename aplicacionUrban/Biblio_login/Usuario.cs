

using System.Text;

namespace Biblio_Login
{
    public abstract class Usuario
    {
        protected string nombre;
        protected string contraseña;
        protected RolUsuario rol;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public RolUsuario Rol { get => rol; set => rol = value; }
        /// <summary>
        /// Inicializa una nueva instancia de la clase Usuario con el nombre, contraseña y rol especificados.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="contraseña">La contraseña del usuario.</param>
        /// <param name="rol">El rol del usuario.</param>
        public Usuario(string nombre, string contraseña, RolUsuario rol)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.rol = rol;
        }
        /// <summary>
        /// Devuelve una representación en forma de cadena del usuario.
        /// </summary>
        /// <returns>Una representación en forma de cadena del usuario.</returns>
        public override string ToString()
        {
            return Nombre + " - " + Contraseña + " - " + Rol;
        }
        /// <summary>
        /// Calcula el crédito acumulado para el usuario.
        /// </summary>
        /// <returns>El crédito acumulado para el usuario.</returns>
        public abstract decimal CalcularCreditoAcumulado();

        /// <summary>
        /// Determina si dos usuarios son iguales comparando sus nombres.
        /// </summary>
        /// <param name="listUsuarios">La lista de usuarios en la que buscar.</param>
        /// <param name="usuario">El usuario a comparar.</param>
        /// <returns>Verdadero si se encuentra el usuario en la lista; de lo contrario, falso.</returns>
        public static bool operator == (List<Usuario> listUsuarios, Usuario usuario)
        {
            foreach (Usuario usuario1 in listUsuarios)
            {
                if (usuario1.Nombre == usuario.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Determina si dos usuarios no son iguales comparando sus nombres.
        /// </summary>
        /// <param name="listUsuarios">La lista de usuarios en la que buscar.</param>
        /// <param name="usuario">El usuario a comparar.</param>
        /// <returns>Verdadero si no se encuentra el usuario en la lista; de lo contrario, falso.</returns>
        public static bool operator != (List<Usuario> listUsuarios, Usuario usuario)
        {
            return !(listUsuarios == usuario);
        }
        /// <summary>
        /// Agrega un usuario a la lista de usuarios si aún no existe.
        /// </summary>
        /// <param name="listUsuarios">La lista de usuarios.</param>
        /// <param name="usuario">El usuario a agregar.</param>
        /// <returns>La lista de usuarios actualizada.</returns>
        public static List<Usuario> operator + (List<Usuario> listUsuarios, Usuario usuario)
        {
            if (listUsuarios != usuario)
            {
                listUsuarios.Add(usuario);
            }
            return listUsuarios;
        }
        /// <summary>
        /// Elimina un usuario de la lista de usuarios si existe.
        /// </summary>
        /// <param name="listUsuarios">La lista de usuarios.</param>
        /// <param name="usuario">El usuario a eliminar.</param>
        /// <returns>La lista de usuarios actualizada.</returns>
        public static List<Usuario> operator - (List<Usuario> listUsuarios, Usuario usuario)
        {
            if (listUsuarios.Contains(usuario))
            {
                listUsuarios.Remove(usuario);
            }
            return listUsuarios;
        }
    }
}

