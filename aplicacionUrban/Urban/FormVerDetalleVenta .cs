using Biblio_Login;
using web_login;
using static Biblio_Login.Producto;

namespace Urban
{
    public partial class FormVerDetalleVenta : Form
    {
        public Vendedor vendedor;
        public ArchivoUsuarios nuevoArchivo;
        public FormVerDetalleVenta(Vendedor vendedor)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            MostrarHistorialVentas();
        }
        /// <summary>
        /// Guarda los datos de un producto asociado a una venta en un archivo.
        /// </summary>
        /// <param name="codigo">El código de la venta.</param>
        /// <param name="producto">El producto asociado a la venta.</param>
        private void GuardarDatosProducto(string codigo, Producto producto)
        {
            string rutaArchivo = ObtenerRutaArchivo();
            string datosProducto = ObtenerDatosProducto(codigo, producto);
            string codigoCompra = txtCodigoCompra.Text;
            nuevoArchivo = new ArchivoUsuarios(rutaArchivo);
            nuevoArchivo.CrearArchivoSiNoExiste(rutaArchivo); 

            string[] lineas = nuevoArchivo.LeerLineasArchivo();
   
            string[] valoresVenta = BuscarVentaPorCodigo(lineas, codigo);
            if (valoresVenta != null)
            {
                MostrarValorCargado(valoresVenta);
                return;
            }
            else
            {
                MostrarValorCargado(new string[] { codigoCompra, producto.Codigo, producto.Tipo.ToString(), producto.Cantidad.ToString() });
            }
            EscribirLineaArchivo(rutaArchivo, datosProducto);
        }
        /// <summary>
        /// Obtiene la ruta del archivo donde se guardarán los datos de la venta.
        /// </summary>
        /// <returns>La ruta del archivo.</returns>
        private string ObtenerRutaArchivo()
        {
            string nombreArchivo = $"{vendedor.Nombre}DetalleVenta.txt";
            string directorio = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(directorio, nombreArchivo);
        }
        /// <summary>
        /// Obtiene los datos del producto formateados como una cadena.
        /// </summary>
        /// <param name="codigo">El código de la venta.</param>
        /// <param name="producto">El producto asociado a la venta.</param>
        /// <returns>Los datos del producto formateados.</returns>
        private string ObtenerDatosProducto(string codigo, Producto producto)
        {
            return $"{codigo},{producto.Codigo},{producto.Tipo},{producto.Cantidad}";
        }
        /// <summary>
        /// Escribe una línea de datos en el archivo.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo.</param>
        /// <param name="datosProducto">Los datos del producto a escribir.</param>
        private void EscribirLineaArchivo(string rutaArchivo, string datosProducto)
        {
            using StreamWriter writer = new StreamWriter(rutaArchivo, true);
            writer.WriteLine(datosProducto);
        }
        /// <summary>
        /// Muestra un mensaje con los valores de una venta cargada previamente.
        /// </summary>
        /// <param name="valoresVenta">Los valores de la venta cargada previamente.</param>
        private static void MostrarValorCargado(string[] valoresVenta)
        {

            if (valoresVenta.Length >= 4)
            {
                string codigoCompra = valoresVenta[0];
                string codigoProducto = valoresVenta[1];
                string tipoProducto = valoresVenta[2];
                string cantidad = valoresVenta[3];

                MessageBox.Show($"Detalle de venta cargado previamente\n\nCódigo Compra: {codigoCompra}\nCódigo Producto: {codigoProducto}\nTipo: {tipoProducto}\nCantidad: {cantidad}");
            }
        }

        /// <summary>
        /// Muestra el historial de ventas en la tabla del formulario.
        /// </summary>
        private void MostrarHistorialVentas()
        {
            if (File.Exists(vendedor.Ruta))
            {
                LimpiarColumnasHistorialVentas();
                string[] lineas = File.ReadAllLines(vendedor.Ruta);
                if (lineas != null && lineas.Length > 0)
                {
                    foreach (string linea in lineas)
                    {
                        AgregarFilaHistorial(linea);
                    }
                }
            }
        }
        /// <summary>
        /// Limpia las columnas de la tabla del historial de ventas.
        /// </summary>
        private void LimpiarColumnasHistorialVentas()
        {
            dgvHistorialVentas.Columns.Clear();
            dgvHistorialVentas.Columns.Add("CodigoCompra", "Código de Compra");
            dgvHistorialVentas.Columns.Add("Fecha", "Fecha");
            dgvHistorialVentas.Columns.Add("Monto", "Monto");
        }
        /// <summary>
        /// Maneja el evento Click del botón de detalle de venta.
        /// </summary>
        private void AgregarFilaHistorial(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores != null && valores.Length == 3)
            {
                dgvHistorialVentas.Rows.Add(valores[0], valores[1], valores[2]);
                dgvHistorialVentas.Refresh();
            }
        }
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnDetalleVenta_Click_1(object sender, EventArgs e)
        {
            string codigoCompra = txtCodigoCompra.Text;
            GuardarDatosProducto(codigoCompra, GenerarProductoAleatorio());
        }
    }
}
