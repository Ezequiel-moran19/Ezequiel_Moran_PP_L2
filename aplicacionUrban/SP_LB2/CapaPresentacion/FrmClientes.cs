using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarEstado();
            CargarColumnasBusqueda();
            MostrarClientes();
        }
        private void CargarEstado()
        {
            cmbEstado.Items.Add(new OpcionesCombo("Activo", eEstado.Activo));
            cmbEstado.Items.Add(new OpcionesCombo("No Activo", eEstado.NoActivo));
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
        }
        private void CargarColumnasBusqueda()
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cmbBusqueda.Items.Add(new OpcionesCombo(columna.HeaderText, columna.Name));
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }
        private void MostrarClientes()
        {
            List<Cliente> listClientes = new CN_Cliente().Listar();
            foreach (Cliente item in listClientes)
            {
                bool estado = item.Estado.Equals(eEstado.Activo);
                dgvData.Rows.Add(new object[] {
                    "",
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    estado,
                    estado ? "Activo" : "No Activo"
                });
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = ObtenerClienteDesdeFormulario();

            if (objCliente != null)
            {
                string mensaje = string.Empty;

                if (objCliente.IdCliente == 0)
                {
                    int idClienteIngresado = RegistrarCliente(objCliente, out mensaje);

                    if (idClienteIngresado != 0)
                    {
                        AgregarClienteAlDataGridView(idClienteIngresado, objCliente);
                        LimpiarCamposTextos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    bool resultado = EditarCliente(objCliente, out mensaje);
                    if (resultado)
                    {
                        ActualizarDataGridView(objCliente);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }
        private Cliente ObtenerClienteDesdeFormulario()
        {
            int idCliente = Convert.ToInt32(txtId.Text);
            string documento = txtDocumento.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            eEstado estado = Convert.ToInt32(((OpcionesCombo)cmbEstado.SelectedItem).Valor) == 1 ? eEstado.Activo : eEstado.NoActivo;

            Cliente objCliente = new Cliente(idCliente, documento, nombre, correo, telefono, estado);

            return objCliente;
        }
        private int RegistrarCliente(Cliente Cliente, out string mensaje)
        {
            return new CN_Cliente().Registrar(Cliente, out mensaje);
        }
        private void AgregarClienteAlDataGridView(int idCliente, Cliente Cliente)
        {
            dgvData.Rows.Add(new object[] {"", idCliente, Cliente.Documento, Cliente.NombreCompleto, Cliente.Correo, Cliente.Telefono,
              ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString(),
              ((OpcionesCombo)cmbEstado.SelectedItem).Texto.ToString(),
            });
        }
        private bool EditarCliente(Cliente Cliente, out string mensaje)
        {
            return new CN_Cliente().Editar(Cliente, out mensaje);
        }

        private void ActualizarDataGridView(Cliente Cliente)
        {
            int indice = Convert.ToInt32(txtIndice.Text);
            if (indice >= 0)
            {
                DataGridViewRow row = dgvData.Rows[indice];
                AsignarValoresCeldas(row, Cliente);
            }
        }
        private void AsignarValoresCeldas(DataGridViewRow row, Cliente Cliente)
        {
            row.Cells["Id"].Value = Cliente.IdCliente.ToString();
            row.Cells["Documento"].Value = Cliente.Documento;
            row.Cells["Nombre"].Value = Cliente.NombreCompleto;
            row.Cells["Correo"].Value = Cliente.Correo;
            row.Cells["Telefono"].Value = Cliente.Telefono;
            row.Cells["EstadoValor"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
            row.Cells["Estado"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
        }
        private void LimpiarCamposTextos()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTextos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objCliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtId.Text)
                    };
                    bool respuesta = new CN_Cliente().Eliminar(objCliente, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        LimpiarCamposTextos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    DataGridViewRow row = dgvData.Rows[indice];
                    AsignarValoresFormulario(row);
                }
            }
        }
        private void AsignarValoresFormulario(DataGridViewRow row)
        {
            txtId.Text = row.Cells["id"].Value.ToString();
            txtDocumento.Text = row.Cells["Documento"].Value.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtCorreo.Text = row.Cells["Correo"].Value.ToString();
            txtTelefono.Text = row.Cells["Telefono"].Value.ToString();

            foreach (OpcionesCombo opcion_Combo in cmbEstado.Items)
            {
                if (Convert.ToInt32(opcion_Combo.Valor) == Convert.ToInt32(row.Cells["EstadoValor"].Value))
                {
                    int indice_combo = cmbEstado.Items.IndexOf(opcion_Combo);
                    cmbEstado.SelectedIndex = indice_combo;
                    break;
                }
            }
        }
        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvData.Columns[0] is DataGridViewButtonColumn)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);

                using (Brush backColorBrush = new SolidBrush(Color.Green))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                e.Paint(e.CellBounds, DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground);
                e.Handled = true;
            }
        }
    }
}
