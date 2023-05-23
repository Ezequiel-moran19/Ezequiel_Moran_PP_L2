using Biblio_Login;
using Urban;

namespace web_login
{
    public partial class PortalVendedor : Form
    {
        private readonly Vendedor vendedor;
        /// <summary>
        /// Vendedor actualmente logueado.
        /// </summary>
        public Vendedor Vendedor { get; set; }
        /// <summary>
        /// Ruta del archivo asociada al vendedor.
        /// </summary>
        public string Ruta { get { return $"{vendedor.Nombre}.txt"; } }

        private FormConsultarHistorialVenta historialForm;

        private FormVerDetalleVenta detalleForm;

        private FormConsultarMontoTotal montoTotalForm;
        /// <summary>
        /// Constructor de la clase PortalVendedor.
        /// </summary>
        public PortalVendedor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor de la clase PortalVendedor que recibe un objeto Vendedor.
        /// </summary>
        /// <param name="vendedor">Objeto Vendedor.</param>
        public PortalVendedor(Vendedor vendedor) : this()
        {
            this.vendedor = vendedor;
            lblNombreVendedor.Text = vendedor.Nombre;
        }
        /// <summary>
        /// Evento Click del botón "BtnConsultarHistorial".
        /// </summary>
        private void BtnConsultarHistorial_Click(object sender, EventArgs e)
        {
            if (historialForm == null || historialForm.IsDisposed)
            {
                historialForm = new FormConsultarHistorialVenta(Ruta, vendedor);
                historialForm.Show();
            }
            else
            {
                historialForm.BringToFront();
            }
        }
        /// <summary>
        /// Evento Click del botón "BtnConsultarMontoTotal".
        /// </summary>
        private void BtnConsultarMontoTotal_Click(object sender, EventArgs e)
        {
            if (montoTotalForm == null || montoTotalForm.IsDisposed)
            {
                montoTotalForm = new FormConsultarMontoTotal(vendedor);
                montoTotalForm.Show();
            }
            else
            {
                montoTotalForm.BringToFront();
            }
        }
        /// <summary>
        /// Evento Click del botón "BtnVerDetalleVenta".
        /// </summary>
        private void BtnVerDetalleVenta_Click(object sender, EventArgs e)
        {
            if (detalleForm == null || detalleForm.IsDisposed)
            {
                detalleForm = new FormVerDetalleVenta(vendedor);
                detalleForm.Show();
            }
            else
            {
                detalleForm.BringToFront();
            }
        }
        /// <summary>
        /// Evento Click del elemento de menú "CerrarSesionToolStripMenuItem".
        /// </summary>
        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.UsuarioLogueado = null; // Cerrar la sesión asignando null al usuario logueado
            this.Close();
        }
    }
}

