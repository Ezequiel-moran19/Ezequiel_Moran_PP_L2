

namespace Biblio_Login
{
    public static class ArchivoUsuarios
    {

        public static string RutaArchivo => $"datos.txt";
        /// <summary>
        /// Obtiene la lista de usuarios almacenados en el archivo.
        /// </summary>
        /// <returns>La lista de usuarios.</returns>
        public static List<Usuario> ObtenerUsuarios()
        {
            try
            {
                string[] lineas = LeerLineasArchivo();
                List<Usuario> usuarios = CrearUsuariosDesdeLineas(lineas);
                return usuarios;
            }
            catch (Exception error)
            {
                 throw new Exception("Error al leer el archivo de usuarios: " + error.Message);
            }
        }
        /// <summary>
        /// Lee las líneas del archivo y las retorna como un arreglo de cadenas.
        /// </summary>
        /// <returns>Un arreglo de cadenas que representa las líneas del archivo.</returns>
        public static string[] LeerLineasArchivo()
        {
            return File.ReadAllLines(RutaArchivo);
        }
        /// <summary>
        /// Verifica si existe un archivo en la ruta especificada.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo.</param>
        /// <returns>true si el archivo existe, de lo contrario false.</returns>
        public static bool ExisteArchivo(string rutaArchivo)
        {
            return File.Exists(rutaArchivo);
        }
        /// <summary>
        /// Crea un objeto Usuario a partir de los campos obtenidos de una línea.
        /// </summary>
        /// <param name="campos">Los campos obtenidos de una línea del archivo.</param>
        /// <returns>Un objeto Usuario.</returns>
        private static Usuario CrearUsuarioDesdeCampos(string[] campos)
        {
            var rol = (RolUsuario)Enum.Parse(typeof(RolUsuario), campos[2], true);
            return new Vendedor(campos[0], campos[1], rol);
        }
        /// <summary>
        /// Crea una lista de usuarios a partir de las líneas del archivo.
        /// </summary>
        /// <param name="lineas">Las líneas del archivo.</param>
        /// <returns>Una lista de usuarios.</returns>
        private static List<Usuario> CrearUsuariosDesdeLineas(string[] lineas)
        {
            List<Usuario> usuarios = new();
         
            foreach (string linea in lineas)
            {   
                string[] campos = linea.Split(',');
                
                if (campos.Length == 3)
                {
                    Usuario usuario = CrearUsuarioDesdeCampos(campos);
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }
        /// <summary>
        /// Guarda la lista de usuarios en el archivo.
        /// </summary>
        /// <param name="usuarios">La lista de usuarios a guardar.</param>
        public static void GuardarUsuariosEnArchivo(List<Usuario> usuarios)
        {
            using StreamWriter writer = new(RutaArchivo);
            foreach (Usuario usuario in usuarios)
            {
                writer.WriteLine($"{usuario.Nombre},{usuario.Contraseña},{usuario.Rol}");
            }
        }
        /// <summary>
        /// Elimina el archivo en la ruta especificada.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo a eliminar.</param>
        public static void EliminarArchivo(string rutaArchivo)
        {
            if (ExisteArchivo(rutaArchivo))
            {
                File.Delete(rutaArchivo);
            }
        }
        /// <summary>
        /// Obtiene el nombre del archivo asociado a un usuario.
        /// </summary>
        /// <param name="usuario">El usuario del cual se desea obtener el nombre del archivo.</param>
        /// <returns>El nombre del archivo asociado al usuario.</returns>
        public static string ObtenerNombreArchivoUsuario(Usuario usuario)
        {
            return $"{usuario.Nombre}.txt";
        }
    }
}

