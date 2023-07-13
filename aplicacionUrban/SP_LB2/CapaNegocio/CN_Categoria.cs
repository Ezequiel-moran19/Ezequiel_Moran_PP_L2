using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria Obj_Categoria = new CD_Categoria();
        public List<Categoria> Listar()
        {
            return Obj_Categoria.Listar();
        }
        public bool Validar(Categoria obj, ref string Mensaje)
        {
            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            else
            {
                return Obj_Categoria.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            else
            {
                return Obj_Categoria.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return Obj_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}

