
namespace Biblio_Login
{
    public class Vendedor : Usuario
    {
        /// <summary>
        /// Generador de números aleatorios para el monto de venta.
        /// </summary>
        public Random MontoVentaRandon { get; set; }
        /// <summary>
        /// Número de ventas realizadas.
        /// </summary>
        public int Ventas { get; set; }
        /// <summary>
        /// Último código de compra generado.
        /// </summary>
        public int UltimoCodigo { get; set; }

        /// <summary>
        /// Constructor de la clase Vendedor.
        /// </summary>
        /// <param name="nombre">Nombre del vendedor.</param>
        /// <param name="contraseña">Contraseña del vendedor.</param>
        public Vendedor(string nombre, string contraseña) : base(nombre, contraseña, RolUsuario.Vendedor)
        {
            MontoVentaRandon = new Random();
            UltimoCodigo = 0; // Inicializar el último código en cero
      
            if (!File.Exists(Ruta)) // Verificar si el archivo de ventas ya existe
            {
                Ventas = MontoVentaRandon.Next(1, 20); // Generar un número aleatorio entre 1 y 20
                GenerarVentas(MontoVentaRandon); // Generar ventas solo si el archivo no existe
            }
            else
            {
                CargarVentas(); // Cargar las ventas existentes si el archivo ya existe
            }
        }
        /// <summary>
        /// Carga las ventas existentes desde el archivo.
        /// </summary>
        private void CargarVentas() 
        {
            string[] lineas = File.ReadAllLines(Ruta);
            Ventas = lineas.Length - 1;
        }
        /// <summary>
        /// Ruta del archivo de ventas del vendedor.
        /// </summary>
        public string Ruta { get { return $"{Nombre}.txt"; } }

        /// <summary>
        /// Genera las ventas y las guarda en el archivo.
        /// </summary>
        /// <param name="random">Generador de números aleatorios.</param>
        private void GenerarVentas(Random random)
        {
            using (StreamWriter writer = File.CreateText(Ruta))
            {
                writer.WriteLine("CodigoCompra,Fecha,Monto");

                int ventaCount = 0;
                for (int i = 0; i < Ventas; i++)
                {
                    writer.WriteLine($"{GenerarCodigoCompra(++ventaCount)},{GenerarFechaVenta(random).ToShortDateString()},${GenerarMontoVenta(random)}");
                }
            }
        }
        /// <summary>
        /// Genera una fecha de venta aleatoria.
        /// </summary>
        /// <param name="random">Generador de números aleatorios.</param>
        /// <returns>Fecha de venta generada.</returns>
        public static DateTime GenerarFechaVenta(Random random)
        {
            return DateTime.Now.AddDays(-random.Next(1, 31));
        }
        /// <summary>
        /// Genera un monto de venta aleatorio.
        /// </summary>
        /// <param name="random">Generador de números aleatorios.</param>
        /// <returns>Monto de venta generado.</returns>
        public static int GenerarMontoVenta(Random random)
        {
            return random.Next(1000, 100000);
        }
        /// <summary>
        /// Genera un código de compra basado en un contador.
        /// </summary>
        /// <param name="ventaCount">Contador de ventas.</param>
        /// <returns>Código de compra generado.</returns>
        public static string GenerarCodigoCompra(int ventaCount)
        {
            return $"#{ventaCount}";
        }
        /// <summary>
        /// Calcula el crédito acumulado del vendedor.
        /// </summary>
        /// <returns>Crédito acumulado del vendedor.</returns>
        public decimal CalcularCreditoAcumulado()
        {
            decimal creditoAcumulado = 0;
            string[] lineas = File.ReadAllLines(Ruta);
            foreach (string linea in lineas)
            {
                if (ObtenerMontoVenta(linea) > 0)
                {
                    creditoAcumulado += ObtenerMontoVenta(linea);
                }
            }
            return creditoAcumulado;
        }
        /// <summary>
        /// Obtiene el monto de venta de una línea de venta.
        /// </summary>
        /// <param name="linea">Línea de venta.</param>
        /// <returns>Monto de venta obtenido.</returns>
        public static decimal ObtenerMontoVenta(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores.Length >= 3 && decimal.TryParse(valores[2].Replace("$", ""), out decimal montoVenta))
            {
                return montoVenta;
            }
            else
            {
                Console.WriteLine($"La línea \"{linea}\" no contiene un monto de venta válido.");
                return 0;
            }
        }
    }
}



