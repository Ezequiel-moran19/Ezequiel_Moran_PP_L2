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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarEstado();
            CargarColumnasBusqueda();
            MostrarCategoria();
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
        private void MostrarCategoria()
        {
            List<Categoria> listCategorias = new CN_Categoria().Listar();

            foreach (Categoria item in listCategorias)
            {
                bool estado = item.Estado.Equals(eEstado.Activo);
                dgvData.Rows.Add(new object[] {"",item.IdCategoria,
                    item.Descripcion,
                    estado,
                    estado ? "Activo" : "No Activo"
                    });
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categoria objCategoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OpcionesCombo)cmbEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            if (objCategoria.IdCategoria == 0)
            {
                int idUsusarioIngresado = new CN_Categoria().Registrar(objCategoria, out mensaje);

                if (idUsusarioIngresado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",idUsusarioIngresado,txtDescripcion.Text,
                        ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString(),
                        ((OpcionesCombo)cmbEstado.SelectedItem).Texto.ToString(),
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Categoria().Editar(objCategoria, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Categoria", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria objCategoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtId.Text)
                    };
                    bool respuesta = new CN_Categoria().Eliminar(objCategoria, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDescripcion.Text = "";
            cmbEstado.SelectedIndex = 0;
            txtDescripcion.Select();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtDescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionesCombo opcion_Combo in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(opcion_Combo.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(opcion_Combo);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
