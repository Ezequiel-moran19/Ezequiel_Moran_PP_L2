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
        /// <summary>
        /// Obtiene el correlativo para el número de compra.
        /// </summary>
        /// <returns>Correlativo para el número de compra.</returns>
        public int ObtenerCorrelativo()
        {
            return Obj_Compra.ObtenerCorrelativo();
        }
        /// <summary>
        /// Registra una compra en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Compra a registrar.</param>
        /// <param name="DetalleCompra">Tabla de datos con el detalle de la compra.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la compra se registró correctamente, false en caso contrario.</returns>
        public bool Registrar(Compra obj, DataTable DetalleCompra,out string Mensaje)
        { 
            return Obj_Compra.Registrar(obj, DetalleCompra,out Mensaje);
        }
        /// <summary>
        /// Obtiene una compra y su detalle a partir de un número de compra.
        /// </summary>
        /// <param name="num">Número de compra.</param>
        /// <returns>Objeto Compra con su detalle correspondiente.</returns>
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
