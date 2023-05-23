

namespace Biblio_Login
{
    public class Usuario
    {
        protected string nombre;
        protected string contraseña;
        protected RolUsuario rol;

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        /// <summary>
        /// Contraseña del usuario.
        /// </summary>
        public string Contraseña { get => contraseña; set => contraseña = value; }
        /// <summary>
        /// Rol del usuario.
        /// </summary>
        public RolUsuario Rol { get => rol; set => rol = value; }
        /// <summary>
        /// Constructor de la clase Usuario.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="contraseña">Contraseña del usuario.</param>
        /// <param name="rol">Rol del usuario.</param>
        public Usuario(string nombre, string contraseña, RolUsuario rol)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.rol = rol;
        }
        /// <summary>
        /// Devuelve una representación en forma de cadena del usuario.
        /// </summary>
        /// <returns>Cadena que representa al usuario.</returns>
        public override string ToString()
        {
            return Nombre + " - " + Contraseña + " - " + Rol;
        }
    }
}
