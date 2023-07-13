using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra Obj_Compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return Obj_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra,out string Mensaje)
        { 
            return Obj_Compra.Registrar(obj, DetalleCompra,out Mensaje);
        }

        public Compra ObtenerCompra(string num) 
        {
            Compra obj = Obj_Compra.ObtenerCompra(num);

            if (obj.IdCompra != 0) 
            {
                List<Detalle_Compra> objDetalleCompra = Obj_Compra.ObtenerDetalleCompra(obj.IdCompra);
                obj.Obj_Detalle_Compra = objDetalleCompra;
            }

            return obj;
        }

    }
}
