using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario Obj_Usuario { get; set; }
        public Proveedor Obj_Proveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> Obj_Detalle_Compra { get; set; }
        public string FechaRegistro { get; set; }
        public Compra()
        {
        }

        public Compra(Usuario obj_Usuario, Proveedor obj_Proveedor, string tipoDocumento, string numeroDocumento, decimal montoTotal):this()
        {
            Obj_Usuario = obj_Usuario;
            Obj_Proveedor = obj_Proveedor;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            MontoTotal = montoTotal;
        }

        public Compra(int idCompra, Usuario obj_Usuario, Proveedor obj_Proveedor, string tipoDocumento, string numeroDocumento, decimal montoTotal, string fechaRegistro) 
            :this(obj_Usuario, obj_Proveedor, tipoDocumento, numeroDocumento, montoTotal)
        {
            IdCompra = idCompra;
            FechaRegistro = fechaRegistro;
        }
    }

}
