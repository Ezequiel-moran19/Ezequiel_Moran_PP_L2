using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente : ICapaNegocio<Cliente>
    {
        private CD_Cliente Obj_Cliente = new CD_Cliente();
        public List<Cliente> Listar()
        {
            return Obj_Cliente.Listar();
        }
        public bool Validar(Cliente obj, ref string Mensaje)
        {
            if (string.IsNullOrEmpty(obj.Documento))
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }
            if (string.IsNullOrEmpty(obj.NombreCompleto))
            {
                Mensaje += "Es necesario el nombre del Cliente\n";
            }
            if (string.IsNullOrEmpty(obj.Correo))
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            return Obj_Cliente.Registrar(obj, out Mensaje);
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            return Obj_Cliente.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return Obj_Cliente.Eliminar(obj, out Mensaje);
        }
    }
}
