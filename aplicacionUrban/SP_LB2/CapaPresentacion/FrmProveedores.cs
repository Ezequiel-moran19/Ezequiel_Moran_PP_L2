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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarEstado();
            CargarColumnasBusqueda();
            MostrarProveedors();
        }
        private void CargarEstado()
        {
            cmbEstado.Items.Add(new OpcionesCombo() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionesCombo() { Valor = 0, Texto = "No Activo" });
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
                    cmbBusqueda.Items.Add(new OpcionesCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }
        private void MostrarProveedors()
        {
            List<Proveedor> listProveedors = new CN_Proveedor().Listar();
            foreach (Proveedor item in listProveedors)
            {
                bool estado = item.Estado.Equals(eEstado.Activo);
                dgvData.Rows.Add(new object[] {
                    "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    estado,
                    estado ? "Activo" : "No Activo"
                });
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = ObtenerProveedorDesdeFormulario();

            if (objProveedor != null)
            {
                string mensaje = string.Empty;

                if (objProveedor.IdProveedor == 0)
                {
                    int idProveedorIngresado = RegistrarProveedor(objProveedor, out mensaje);

                    if (idProveedorIngresado != 0)
                    {
                        AgregarProveedorAlDataGridView(idProveedorIngresado, objProveedor);
                        LimpiarCamposTextos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    bool resultado = EditarProveedor(objProveedor, out mensaje);
                    if (resultado)
                    {
                        ActualizarDataGridView(objProveedor);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }
        private Proveedor ObtenerProveedorDesdeFormulario()
        {
            int idProveedor = Convert.ToInt32(txtId.Text);
            string documento = txtDocumento.Text;
            string RazonSocial = txtRazonSocial.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            eEstado estado = Convert.ToInt32(((OpcionesCombo)cmbEstado.SelectedItem).Valor) == 1 ? eEstado.Activo : eEstado.NoActivo;

            Proveedor objProveedor = new Proveedor(idProveedor, documento, RazonSocial, correo, telefono, estado);

            return objProveedor;
        }
        private int RegistrarProveedor(Proveedor Proveedor, out string mensaje)
        {
            return new CN_Proveedor().Registrar(Proveedor, out mensaje);
        }
        private void AgregarProveedorAlDataGridView(int idProveedor, Proveedor Proveedor)
        {
            dgvData.Rows.Add(new object[] {"", idProveedor, Proveedor.Documento, Proveedor.RazonSocial, Proveedor.Correo, Proveedor.Telefono,
              ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString(),
              ((OpcionesCombo)cmbEstado.SelectedItem).Texto.ToString(),
            });
        }
        private bool EditarProveedor(Proveedor Proveedor, out string mensaje)
        {
            return new CN_Proveedor().Editar(Proveedor, out mensaje);
        }

        private void ActualizarDataGridView(Proveedor Proveedor)
        {
            int indice = Convert.ToInt32(txtIndice.Text);
            if (indice >= 0)
            {
                DataGridViewRow row = dgvData.Rows[indice];
                AsignarValoresCeldas(row, Proveedor);
            }
        }
        private void AsignarValoresCeldas(DataGridViewRow row, Proveedor Proveedor)
        {
            row.Cells["Id"].Value = Proveedor.IdProveedor.ToString();
            row.Cells["Documento"].Value = Proveedor.Documento;
            row.Cells["RazonSocial"].Value = Proveedor.RazonSocial;
            row.Cells["Correo"].Value = Proveedor.Correo;
            row.Cells["Telefono"].Value = Proveedor.Telefono;
            row.Cells["EstadoValor"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
            row.Cells["Estado"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
        }
        private void LimpiarCamposTextos()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
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
                if (MessageBox.Show("¿Desea eliminar el Proveedor", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    int Id = Convert.ToInt32(txtId.Text);
                    Proveedor obj = new Proveedor(Id);
                    bool respuesta = new CN_Proveedor().Eliminar(obj, out mensaje);

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
            txtRazonSocial.Text = row.Cells["RazonSocial"].Value.ToString();
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
