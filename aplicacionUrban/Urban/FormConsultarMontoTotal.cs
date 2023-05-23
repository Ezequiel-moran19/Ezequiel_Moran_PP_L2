using Biblio_Login;
using web_login;

namespace Urban
{
    public partial class FormConsultarMontoTotal : Form
    {
        private readonly Vendedor vendedor;
        public FormConsultarMontoTotal(Vendedor vendedor)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            MostrarHistorialVentas();
        }
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
        private void LimpiarColumnasHistorialVentas()
        {
            dgvHistorialVentas.Columns.Clear();
            dgvHistorialVentas.Columns.Add("CodigoCompra", "Código de Compra");
            dgvHistorialVentas.Columns.Add("Fecha", "Fecha");
            dgvHistorialVentas.Columns.Add("Monto", "Monto");
        }
        private void AgregarFilaHistorial(string linea)
        {
            string[] valores = linea.Split(',');
            if (valores != null && valores.Length == 3)
            {
                dgvHistorialVentas.Rows.Add(valores[0], valores[1], valores[2]);
                dgvHistorialVentas.Refresh();
            }
        }
        /// <summary>
        /// Calcula el monto total acumulado de ventas del vendedor.
        /// </summary>
        /// <returns>Monto total acumulado de ventas.</returns>
        private decimal CalcularMontoTotal()
        {
            return vendedor.CalcularCreditoAcumulado();
        }
        /// <summary>
        /// Evento Click del elemento de menú "VolverToolStripMenuItem".
        /// </summary>
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        /// <summary>
        /// Evento Click del botón "BtnCredito".
        /// Muestra el crédito acumulado del vendedor en un MessageBox.
        /// </summary>
        private void BtnCredito_Click(object sender, EventArgs e)
        {
            decimal creditoAcumulado = CalcularMontoTotal();
            MessageBox.Show($"Crédito acumulado: ${creditoAcumulado}");
        }
    }
}
