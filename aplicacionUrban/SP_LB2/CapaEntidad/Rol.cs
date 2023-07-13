namespace CapaEntidad
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; }
        public Rol()
        {
        }
        public Rol(int idRol)
        {
            IdRol = idRol;
        }

        public Rol(int idRol, string descripcion) : this(idRol)
        {
            Descripcion = descripcion;
        }

    }
}