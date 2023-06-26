using System.Text;

namespace Biblio_Login
{
    public class Producto
    {
        public enum TipoDeProducto
        {
            Zapatos,
            Pantalones,
            Camisetas,
            Camperas,
        }
        public int Cantidad { get; set;  } // Nueva propiedad Cantidad
        public TipoDeProducto Tipo { get; set; }
        public Producto(TipoDeProducto tipo, int cantidad)
        {
            Tipo = tipo;
            Cantidad = cantidad; 
        }
        public static Producto GenerarProductoAleatorio()
        {
            Random random = new Random();
            TipoDeProducto tipo = (TipoDeProducto)random.Next(0, 4);
            int cantidad = random.Next(1, 10);
            return new Producto(tipo, cantidad);
        }
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
