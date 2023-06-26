
using Biblio_login;
using Biblio_Login;

namespace Urban
{
    public partial class FormConsultarHistorialVenta : Form
    {
        public Vendedor vendedor;
        public FormConsultarHistorialVenta()
        {
            InitializeComponent();
        }
        public FormConsultarHistorialVenta(string ruta, Vendedor vendedor) : this()
        {
            this.vendedor = vendedor;
            lblVentas.Text = vendedor.Ventas.ToString();
            MostrarHistorialVentas();
        }
        private void MostrarHistorialVentas()
        {
            if (ArchivoUsuarios.ExisteArchivo(vendedor.Ruta))
            {
                LimpiarColumnasHistorialVentas();
                string[] lineas = ArchvoVentas.LeerLineasArchivo(vendedor.Ruta);
                if (lineas != null && lineas.Length > 0)
                {
                    foreach (string linea in lineas)
                    {
                        AgregarFilaHistorial(linea);
                    }
                }
            }
        }
        public void LimpiarColumnasHistorialVentas()
        {
            dgvHistorialVentas.Columns.Clear();
            dgvHistorialVentas.Columns.Add("CodigoCompra", "Código de Compra");
            dgvHistorialVentas.Columns.Add("Tipo", "Tipo de Producto"); // Agregar columna para el tipo de producto
            dgvHistorialVentas.Columns.Add("Cantidad", "Cantidad"); // Agregar columna para la cantidad
            dgvHistorialVentas.Columns.Add("Fecha", "Fecha");
            dgvHistorialVentas.Columns.Add("Monto", "Monto");
        }
        public void AgregarFilaHistorial(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores != null && valores.Length == 5) // Modificar la condición para 6 valores
            {
                dgvHistorialVentas.Rows.Add(valores[0], valores[1], valores[2], valores[3], valores[4]); // Agregar los valores a las columnas correspondientes
                dgvHistorialVentas.Refresh();
            }
        }
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnCredito_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.MostrarToltaVentas());
        }
    }
}

