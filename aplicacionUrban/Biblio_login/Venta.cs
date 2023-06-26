using Biblio_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_login
{
    public class Venta
    {
        public string CodigoCompra { get; set; }
        public Producto.TipoDeProducto Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        /// <summary>
        /// Constructor de la clase Venta.
        /// </summary>
        /// <param name="codigoCompra">El código de compra.</param>
        /// <param name="tipo">El tipo de producto.</param>
        /// <param name="cantidad">La cantidad de productos vendidos.</param>
        /// <param name="fecha">La fecha de la venta.</param>
        /// <param name="monto">El monto de la venta.</param>
        public Venta(string codigoCompra, Producto.TipoDeProducto tipo, int cantidad, DateTime fecha, decimal monto)
        {
            CodigoCompra = codigoCompra;
            Tipo = tipo;
            Cantidad = cantidad;
            Fecha = fecha;
            Monto = monto;
        }
        /// <summary>
        /// Carga las ventas desde un archivo.
        /// </summary>
        /// <param name="ruta">La ruta del archivo.</param>
        /// <returns>La lista de ventas cargadas.</returns>
        public static List<Venta> CargarVentas(string ruta)
        {
            return ArchvoVentas.CargarVentas(ruta);
        }
        /// <summary>
        /// Genera ventas aleatorias y las guarda en un archivo.
        /// </summary>
        /// <param name="ruta">La ruta del archivo.</param>
        /// <param name="random">La instancia de la clase Random.</param>
        /// <param name="cantidadVentas">La cantidad de ventas a generar.</param>
        public static void GenerarVentas(string ruta, Random random, int cantidadVentas)
        {
            ArchvoVentas.GenerarVentas(ruta, random, cantidadVentas);
        }
        /// <summary>
        /// Obtiene el monto de venta a partir de una línea de datos.
        /// </summary>
        /// <param name="linea">La línea de datos.</param>
        /// <returns>El monto de venta.</returns>
        public static decimal ObtenerMontoVenta(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores.Length >= 5 && decimal.TryParse(valores[4].Replace("$", ""), out decimal montoVenta))
            {
                return montoVenta;
            }
            else
            {
                Console.WriteLine($"La línea \"{linea}\" no contiene un monto de venta válido.");
                return 0;
            }
        }
        /// <summary>
        /// Genera una fecha de venta aleatoria.
        /// </summary>
        /// <param name="random">La instancia de la clase Random.</param>
        /// <returns>La fecha de venta generada.</returns>
        public static DateTime GenerarFechaVenta(Random random)
        {
            return DateTime.Now.AddDays(-random.Next(1, 31));
        }
        /// <summary>
        /// Genera un monto de venta aleatorio.
        /// </summary>
        /// <param name="random">La instancia de la clase Random.</param>
        /// <returns>El monto de venta generado.</returns>
        public static int GenerarMontoVenta(Random random)
        {
            return random.Next(1000, 100000);
        }
        /// <summary>
        /// Genera un código de compra basado en el contador de ventas.
        /// </summary>
        /// <param name="ventaCount">El contador de ventas.</param>
        /// <returns>El código de compra generado.</returns>
        public static string GenerarCodigoCompra(int ventaCount)
        {
            return $"#{ventaCount}";
        }
    }
}
