using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario : Persona
    {
        private Rol obj_Rol;

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }


        public string Clave { get; set; }
        public Rol Obj_Rol { get; set; }

        public Usuario()
        { }
        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public Usuario(int idUsuario): this()
        {
           IdUsuario = idUsuario;
        }
        public Usuario(int idUsuario, string documento, string nombre, string correo, string clave, eEstado estado, Rol obj_Rol)
            : base(documento, correo, estado)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Clave = clave;
            Obj_Rol = obj_Rol;
        }

        public static implicit operator int(Usuario usuario)
        {
            return usuario.IdUsuario;
        }
    }
}
