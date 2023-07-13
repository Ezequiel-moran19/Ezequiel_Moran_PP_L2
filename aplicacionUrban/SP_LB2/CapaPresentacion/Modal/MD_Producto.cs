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
    public partial class MD_Producto : Form
    {
        public Producto Modal_Producto { get; set; }
        public MD_Producto()
        {
            InitializeComponent();
        }

        private void MD_Producto_Load(object sender, EventArgs e)
        {
            CargarColumnasBusqueda();
            MostrarProductos();
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
        private void MostrarProductos()
        {
            List<Producto> listProductos = new CN_Producto().Listar();
            foreach (Producto item in listProductos)
            {
                dgvData.Rows.Add(new object[] {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Obj_Categoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta
                });
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                Modal_Producto = new Producto(
                    Convert.ToInt32(dgvData.Rows[iRow].Cells["Id"].Value.ToString()),
                    dgvData.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    dgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    "",
                    null,
                    Convert.ToInt32(dgvData.Rows[iRow].Cells["Stock"].Value.ToString()),
                    Convert.ToDecimal(dgvData.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    Convert.ToDecimal(dgvData.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                    eEstado.Activo
                );
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
