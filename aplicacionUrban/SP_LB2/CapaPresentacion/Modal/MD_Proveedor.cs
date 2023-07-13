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

namespace CapaPresentacion.Modal
{
    public partial class MD_Proveedor : Form
    {
        public Proveedor Modal_Proveedor { get; set; }
        public MD_Proveedor()
        {
            InitializeComponent();
        }

        private void MD_Proveedor_Load(object sender, EventArgs e)
        {
            CargarColumnasBusqueda();
            MostrarProveedors();
        }
        private void CargarColumnasBusqueda()
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true)
                {
                    cmbBusqueda.Items.Add(new OpcionesCombo(columna.HeaderText, columna.Name));
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
                dgvData.Rows.Add(new object[] {
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                });
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                Modal_Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvData.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();

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
    }
}
