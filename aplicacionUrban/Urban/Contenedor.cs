using Biblio_Login;
using web_login;
namespace Urban
{
    public partial class Contenedor : Form
    {
        public Login loginForm;
        public PortalAdmin portalAdminForm;
        public PortalVendedor portalVendedorForm;
        public Contenedor()
        {
            InitializeComponent();
        }
        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new Login();
                loginForm.Show();
            }
            else if (!loginForm.Visible)
            {
                loginForm.Show();
            }
            else
            {
                loginForm.BringToFront();
            }
        }
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
