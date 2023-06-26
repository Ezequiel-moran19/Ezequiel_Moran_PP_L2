
using Biblio_login;
using System.Text;

namespace Biblio_Login
{
    public class Vendedor : Usuario
    {
        public Random MontoVentaRandon { get; set; }
        public int Ventas { get; set; }
        public string Ruta => $"{Nombre}.txt";
        public int UltimoCodigo { get; set; }
        public List<Venta> HistorialVentas { get; set; }
        /// <summary>
        /// Inicializa una nueva instancia de la clase Vendedor con el nombre, contraseña y rol especificados.
        /// </summary>
        /// <param name="nombre">El nombre del vendedor.</param>
        /// <param name="contraseña">La contraseña del vendedor.</param>
        /// <param name="rol">El rol del vendedor.</param>
        public Vendedor(string nombre, string contraseña, RolUsuario rol) : base(nombre, contraseña, rol)
        {
            MontoVentaRandon = new Random();
            UltimoCodigo = 0; 

            InicializarVendedor();
        }
        /// <summary>
        /// Inicializa el vendedor.
        /// </summary>
        public void InicializarVendedor()
        {
            if (!ArchivoUsuarios.ExisteArchivo(Ruta))
            {
                Ventas = MontoVentaRandon.Next(1, 20);
                Venta.GenerarVentas(Ruta, MontoVentaRandon, Ventas);
            }
            else
            {
                HistorialVentas = Venta.CargarVentas(Ruta);
                Ventas = HistorialVentas.Count;
            }
        }
        /// <summary>
        /// Calcula el crédito acumulado del vendedor.
        /// </summary>
        /// <returns>El crédito acumulado del vendedor.</returns>
        public override decimal CalcularCreditoAcumulado()
        {
            decimal creditoAcumulado = 0;
            if (ArchivoUsuarios.ExisteArchivo(Ruta))
            {
                string[] lineas = ArchvoVentas.LeerLineasArchivo(Ruta);
                foreach (string linea in lineas.Skip(1)) 
                {
                    decimal montoVenta = Venta.ObtenerMontoVenta(linea);
                    if (montoVenta > 0)
                    {
                        creditoAcumulado += montoVenta;
                    }
                }
            }
            return creditoAcumulado;
        }
        /// <summary>
        /// Muestra el total de ventas y el crédito acumulado del vendedor.
        /// </summary>
        /// <returns>Una cadena que representa el total de ventas y el crédito acumulado del vendedor.</returns>
        public string MostrarToltaVentas() 
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Crédito acumulado: ${CalcularCreditoAcumulado()}");
            return stringBuilder.ToString();
        }
    }
}


