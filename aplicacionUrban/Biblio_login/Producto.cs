using System.Text;

namespace Biblio_Login
{
    public class Producto
    {

        /// <summary>
        /// Enumeración que define los tipos de producto.
        /// </summary>
        public enum TipoDeProducto
        {
            Zapatos,
            Pantalones,
            Camisetas,
            Camperas,
        }
        /// <summary>
        /// Código del producto.
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Cantidad disponible del producto.
        /// </summary>
        public int Cantidad { get; set;  } // Nueva propiedad Cantidad
        /// <summary>
        /// Tipo del producto.
        /// </summary>
        public TipoDeProducto Tipo { get; set; }
        /// <summary>
        /// Constructor de la clase Producto.
        /// </summary>
        /// <param name="codigo">Código del producto.</param>
        /// <param name="tipo">Tipo del producto.</param>
        /// <param name="cantidad">Cantidad disponible del producto.</param>
        public Producto(string codigo, TipoDeProducto tipo, int cantidad)
        {
            Codigo = codigo;
            Tipo = tipo;
            Cantidad = cantidad; 
        }
        /// <summary>
        /// Genera un producto aleatorio.
        /// </summary>
        /// <returns>Producto aleatorio generado.</returns>
        public static Producto GenerarProductoAleatorio()
        {
            Random random = new Random();
            TipoDeProducto tipo = (TipoDeProducto)random.Next(0, 4);
            string codigo = $"{tipo.ToString()[0]}{random.Next(1000, 9999)}";
            int cantidad = random.Next(1, 10);
            return new Producto(codigo, tipo, cantidad);
        }
        /// <summary>
        /// Busca una venta por código en un array de líneas de venta.
        /// </summary>
        /// <param name="lineas">Array de líneas de venta.</param>
        /// <param name="codigoCompra">Código de compra a buscar.</param>
        /// <returns>Array de valores de la venta encontrada o null si no se encuentra.</returns>
        public static string[]? BuscarVentaPorCodigo(string[] lineas, string codigoCompra)
        {
            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(',');
                if (valores[0] == codigoCompra)
                {
                    return valores;
                }
            }
            return null;
        }
    }
}
