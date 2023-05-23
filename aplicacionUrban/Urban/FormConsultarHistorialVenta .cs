
using Biblio_Login;

namespace Urban
{
    public partial class FormConsultarHistorialVenta : Form
    {
        private readonly string ruta;
        public Vendedor vendedor;
        public DataGridView IniciarSesionMenuItem => dgvHistorialVentas;
        public FormConsultarHistorialVenta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor de la clase FormConsultarHistorialVenta que recibe la ruta del archivo y un objeto Vendedor.
        /// </summary>
        /// <param name="ruta">Ruta del archivo.</param>
        /// <param name="vendedor">Objeto Vendedor.</param>
        public FormConsultarHistorialVenta(string ruta, Vendedor vendedor) : this()
        {
            this.ruta = ruta;
            this.vendedor = vendedor;
            lblVentas.Text = vendedor.Ventas.ToString();
            MostrarHistorialVentas();
        }
        /// <summary>
        /// Muestra el historial de ventas en el DataGridView.
        /// </summary>
        public void MostrarHistorialVentas()
        {
            if (File.Exists(ruta))
            {
                LimpiarColumnasHistorialVentas();
                string[] lineas = File.ReadAllLines(ruta);
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
        /// Limpia las columnas del DataGridView del historial de ventas.
        /// </summary>
        public void LimpiarColumnasHistorialVentas()
        {
            IniciarSesionMenuItem.Columns.Clear();
            IniciarSesionMenuItem.Columns.Add("CodigoCompra", "Código de Compra");
            IniciarSesionMenuItem.Columns.Add("Fecha", "Fecha");
            IniciarSesionMenuItem.Columns.Add("Monto", "Monto");
        }
        /// <summary>
        /// Agrega una fila al DataGridView del historial de ventas.
        /// </summary>
        /// <param name="linea">Línea de datos.</param>
        public void AgregarFilaHistorial(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores != null && valores.Length == 3)
            {
                IniciarSesionMenuItem.Rows.Add(valores[0], valores[1], valores[2]);
                IniciarSesionMenuItem.Refresh();
            }
        }
        /// <summary>
        /// Evento Click del elemento de menú "VolverToolStripMenuItem".
        /// </summary>
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

