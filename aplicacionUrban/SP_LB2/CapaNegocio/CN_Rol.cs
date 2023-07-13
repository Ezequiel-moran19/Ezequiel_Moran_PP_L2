using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol Obj_Rol = new CD_Rol();
        public List<Rol> Listar()
        {
            return Obj_Rol.Listar();
        }
    }
}
