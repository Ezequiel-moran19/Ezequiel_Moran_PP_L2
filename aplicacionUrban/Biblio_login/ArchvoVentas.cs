using Biblio_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_login
{
    public static class ArchvoVentas
    {
        /// <summary>
        /// Lee todas las líneas de un archivo.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo a leer.</param>
        /// <returns>Un arreglo de cadenas que representa las líneas del archivo.</returns>
        public static string[] LeerLineasArchivo(string rutaArchivo)
        {
            return File.ReadAllLines(rutaArchivo);
        }
        /// <summary>
        /// Crea una instancia de la clase Venta a partir de una cadena que representa una línea de datos.
        /// </summary>
        /// <param name="linea">La cadena que representa la línea de datos.</param>
        /// <returns>Una instancia de la clase Venta si la línea es válida, de lo contrario, null.</returns>
        public static Venta CrearVentaDesdeLinea(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores.Length == 5)
            {
                string codigoCompra = valores[0];
                if (Enum.TryParse(valores[1], out Producto.TipoDeProducto tipo))
                {
                    int cantidad = int.Parse(valores[2]);
                    DateTime fecha = DateTime.Parse(valores[3]);
                    decimal monto = decimal.Parse(valores[4].Replace("$", ""));

                    return new Venta(codigoCompra, tipo, cantidad, fecha, monto);
                }
            }
            return null;
        }
        /// <summary>
        /// Carga las ventas desde un archivo.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo que contiene las ventas.</param>
        /// <returns>Una lista de instancias de la clase Venta.</returns>
        public static List<Venta> CargarVentas(string rutaArchivo)
        {
            List<Venta> ventas = new List<Venta>();
            string[] lineas = LeerLineasArchivo(rutaArchivo);

            foreach (string linea in lineas.Skip(1))
            {
                Venta venta = CrearVentaDesdeLinea(linea);
                if (venta != null)
                {
                    ventas.Add(venta);
                }
            }
            return ventas;
        }
        /// <summary>
        /// Genera ventas aleatorias y las guarda en un archivo.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo donde se guardarán las ventas generadas.</param>
        /// <param name="random">Una instancia de la clase Random para generar valores aleatorios.</param>
        /// <param name="cantidadVentas">La cantidad de ventas que se generarán.</param>
        public static void GenerarVentas(string rutaArchivo, Random random, int cantidadVentas)
        {
            using (StreamWriter writer = File.CreateText(rutaArchivo))
            {
                writer.WriteLine("CodigoCompra,Tipo,Cantidad,Fecha,Monto");

                int ventaCount = 0;
                for (int i = 0; i < cantidadVentas; i++)
                {
                    Producto producto = Producto.GenerarProductoAleatorio();
                    string codigoCompra = Venta.GenerarCodigoCompra(++ventaCount);
                    DateTime fechaVenta = Venta.GenerarFechaVenta(random);
                    decimal montoVenta = Venta.GenerarMontoVenta(random);

                    Venta venta = new Venta(codigoCompra, producto.Tipo, producto.Cantidad, fechaVenta, montoVenta);

                    writer.WriteLine($"{venta.CodigoCompra},{venta.Tipo},{venta.Cantidad},{venta.Fecha.ToShortDateString()},${venta.Monto}");
                }
            }
        }
    }
}
