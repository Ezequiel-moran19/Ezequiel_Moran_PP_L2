using Biblio_Login;
using System.Runtime.Intrinsics.Arm;
using Urban;

namespace web_login
{
    public partial class PortalVendedor : Form
    {
        private readonly Vendedor vendedor;
        public Vendedor Vendedor { get; set; }

        private FormConsultarHistorialVenta historialForm;
        public PortalVendedor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que recibe una instancia de la clase Vendedor y configura el formulario con los datos correspondientes.
        /// </summary>
        /// <param name="vendedor">El objeto Vendedor asociado al portal.</param>
        public PortalVendedor(Vendedor vendedor) : this()
        {
            this.vendedor = vendedor;
            lblNombreVendedor.Text = vendedor.Nombre;
        }
        private void BtnConsultarHistorial_Click(object sender, EventArgs e)
        {
           
            if (historialForm == null || historialForm.IsDisposed)
            {
                historialForm = new FormConsultarHistorialVenta(vendedor.Ruta, vendedor);
                historialForm.Show();
            }
            else
            {
                historialForm.BringToFront();
            }
        }
        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.UsuarioLogueado = null; // Cerrar la sesión asignando null al usuario logueado
            this.Close();
        }
    }
}

