using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto : ICapaNegocio<Producto>
    {
        private CD_Producto Obj_Producto = new CD_Producto();
        public List<Producto> Listar()
        {
            return Obj_Producto.Listar();
        }
        public bool Validar(Producto obj, ref string Mensaje)
        {

            if (string.IsNullOrEmpty(obj.Codigo))
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }
            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }
            if (string.IsNullOrEmpty(obj.Descripcion))
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            else
            {
                return Obj_Producto.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            else
            {
                return Obj_Producto.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return Obj_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
