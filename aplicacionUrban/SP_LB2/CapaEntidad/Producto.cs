using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria? Obj_Categoria { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public eEstado Estado { get; set; }
        public string FechaRegistro { get; set; }
        public Producto()
        { 
        }
        public Producto(int idProducto, string codigo, string nombre, string descripcion, Categoria obj_Categoria, eEstado estado)
        {
            IdProducto = idProducto;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Obj_Categoria = obj_Categoria;
            Estado = estado;
        }
        public Producto(int idProducto, string codigo, string nombre, string descripcion, Categoria obj_Categoria, int stock, decimal precioCompra, decimal precioVenta, eEstado estado)
             : this(idProducto, codigo, nombre, descripcion, obj_Categoria, estado)
        {
            Stock = stock;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
        }

    }
}
