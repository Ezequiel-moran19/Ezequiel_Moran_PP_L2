using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor : ICapaNegocio<Proveedor>
    {
        private CD_Proveedor Obj_Proveedor = new CD_Proveedor();
        public List<Proveedor> Listar()
        {
            return Obj_Proveedor.Listar();
        }
        public bool Validar(Proveedor obj, ref string Mensaje)
        {
            if (string.IsNullOrEmpty(obj.Documento))
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }
            if (string.IsNullOrEmpty(obj.RazonSocial))
            {
                Mensaje += "Es necesario el RazonSocial del Proveedor\n";
            }
            if (string.IsNullOrEmpty(obj.Correo))
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            return Obj_Proveedor.Registrar(obj, out Mensaje);
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            return Obj_Proveedor.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return Obj_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
