﻿
using Biblio_Login;

namespace web_login
{
    public partial class FormAgregarUsuario : Form
    {
        private readonly PortalAdmin portalAdmin;
        public string Nombre => txtNombre.Text;
        public string Contraseña => txtContraseña.Text;
        public RolUsuario Rol => (RolUsuario)cmbRol.SelectedIndex;

        public FormAgregarUsuario(PortalAdmin portalAdmin)
        {
            InitializeComponent();

            cmbRol.Items.Add(RolUsuario.Administrador.ToString());
            cmbRol.Items.Add(RolUsuario.Vendedor.ToString());
            this.portalAdmin = portalAdmin;
        }
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese el carácter no válido
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(cmbRol.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario nuevoUsuario = new Vendedor(Nombre, Contraseña, Rol);

            portalAdmin.Usuarios.Add(nuevoUsuario);
            portalAdmin.ActualizarListaUsuarios();
            portalAdmin.GuardarUsuariosEnArchivo();

            PortalVendedor portalVendedor = new PortalVendedor();
            if (portalVendedor != null)
            {
                if (nuevoUsuario is Vendedor vendedor)
                {
                    portalVendedor.Vendedor = vendedor;
                }
            }
            this.Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

