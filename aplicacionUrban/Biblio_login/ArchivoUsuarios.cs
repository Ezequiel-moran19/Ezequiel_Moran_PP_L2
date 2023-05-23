

namespace Biblio_Login
{
    public class ArchivoUsuarios
    {

        private readonly string rutaArchivo;
        /// <summary>
        /// Constructor de la clase ArchivoUsuarios.
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo de usuarios.</param>
        public ArchivoUsuarios(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }
        /// <summary>
        /// Ruta del archivo de usuarios.
        /// </summary>
        public string RutaArchivo => rutaArchivo;
        /// <summary>
        /// Obtiene la lista de usuarios desde el archivo.
        /// </summary>
        /// <returns>Lista de usuarios.</returns>
        public List<Usuario> ObtenerUsuarios()
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
        public string[] LeerLineasArchivo()
        {
            return File.ReadAllLines(RutaArchivo);
        }

        private static Usuario CrearUsuarioDesdeCampos(string[] campos)
        {
            var rol = (RolUsuario)Enum.Parse(typeof(RolUsuario), campos[2], true);
            return new Usuario(campos[0], campos[1], rol);
        }
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
        /// <param name="usuarios">Lista de usuarios.</param>
        public void GuardarUsuariosEnArchivo(List<Usuario> usuarios)
        {
            using StreamWriter writer = new(RutaArchivo);
            foreach (Usuario usuario in usuarios)
            {
                writer.WriteLine($"{usuario.Nombre},{usuario.Contraseña},{usuario.Rol}");
            }
        }
        public void CrearArchivoSiNoExiste(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                using StreamWriter file = File.CreateText(rutaArchivo);
                file.WriteLine("CodigoCompra,Codigo Producto,Tipo,Cantidad");
            }
        }
    }
}

