using CapaDatos;
using CapaDatos.Infomes;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarEstado();

            CargarCategoria();

            CargarColumnasBusqueda();

            MostrarProductos();
        }
        private void CargarEstado()
        {
            cmbEstado.Items.Add(new OpcionesCombo() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionesCombo() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
        }

        private void CargarCategoria()
        {
            List<Categoria> lisCategial = new CN_Categoria().Listar();

            foreach (Categoria item in lisCategial)
            {
                cmbCategoria.Items.Add(new OpcionesCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cmbCategoria.DisplayMember = "Texto";
            cmbCategoria.ValueMember = "Valor";
            cmbCategoria.SelectedIndex = 0;
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
        private void MostrarProductos()
        {
            List<Producto> listProductos = new CN_Producto().Listar();
            foreach (Producto item in listProductos)
            {
                bool estado = item.Estado.Equals(eEstado.Activo);
                dgvData.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.Obj_Categoria.IdCategoria,
                    item.Obj_Categoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    estado,
                    estado ? "Activo" : "No Activo"
                    });
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtId.Text);
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int IdCategoria = Convert.ToInt32(((OpcionesCombo)cmbCategoria.SelectedItem).Valor);
            Categoria categoria = new Categoria(IdCategoria);
            eEstado estado = Convert.ToInt32(((OpcionesCombo)cmbEstado.SelectedItem).Valor) == 1 ? eEstado.Activo : eEstado.NoActivo;
            Producto objProducto = new Producto(idProducto, codigo, nombre, descripcion, categoria, estado);

            string mensaje = string.Empty;

            if (objProducto.IdProducto == 0)
            {
                AgregarProducto(objProducto, out mensaje);
            }
            else
            {
                EditarProducto(objProducto, out mensaje);
            }
        }
        private void AgregarProducto(Producto producto, out string mensaje)
        {
            mensaje = string.Empty;
            int idProductoIngresado = new CN_Producto().Registrar(producto, out mensaje);

            if (idProductoIngresado != 0)
            {
                AgregarFilaDgv(producto, idProductoIngresado);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        private void EditarProducto(Producto producto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = new CN_Producto().Editar(producto, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                row.Cells["Id"].Value = txtId.Text;
                row.Cells["Codigo"].Value = txtCodigo.Text;
                row.Cells["Nombre"].Value = txtNombre.Text;
                row.Cells["Descripcion"].Value = txtDescripcion.Text;
                row.Cells["IdCategoria"].Value = ((OpcionesCombo)cmbCategoria.SelectedItem).Valor.ToString();
                row.Cells["Categoria"].Value = ((OpcionesCombo)cmbCategoria.SelectedItem).Valor.ToString();
                row.Cells["EstadoValor"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
                row.Cells["Estado"].Value = ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        private void AgregarFilaDgv(Producto producto, int idProducto)
        {
            dgvData.Rows.Add(new object[] {
                "",
                idProducto,
                txtCodigo.Text,
                txtNombre.Text,
                txtDescripcion.Text,
                ((OpcionesCombo)cmbCategoria.SelectedItem).Valor.ToString(),
                ((OpcionesCombo)cmbCategoria.SelectedItem).Texto.ToString(),
                "0",
                "0,00",
                "0.00",
                ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString(),
                ((OpcionesCombo)cmbEstado.SelectedItem).Texto.ToString(),
            });
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objProducto = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtId.Text)
                    };
                    bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
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
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionesCombo opcion_Combo in cmbCategoria.Items)
                    {
                        if (Convert.ToInt32(opcion_Combo.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["Id"].Value))
                        {
                            int indice_combo = cmbCategoria.Items.IndexOf(opcion_Combo);
                            cmbCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }
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
        private void LimpiarCampos()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            txtCodigo.Select();
        }
        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvData.Columns[0] is DataGridViewButtonColumn)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);

                using (Brush backColorBrush = new SolidBrush(System.Drawing.Color.Green))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                e.Paint(e.CellBounds, DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground);
                e.Handled = true;
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
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dt = CrearDataTableDesdeDataGridView();

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string rutaArchivo = ObtenerRutaArchivo();

            if (rutaArchivo == null)
            {
                MessageBox.Show("No se seleccionó una ruta de archivo válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string extension = Path.GetExtension(rutaArchivo);

            try
            {
                IInforme informe = ObtenerInstanciaInforme(extension);

                if (informe == null)
                {
                    MessageBox.Show("Formato de archivo no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string rutaCompleta = Path.Combine(informe.DirectorioInforme, rutaArchivo);
                informe.GenerarInforme(dt, rutaCompleta);

                MessageBox.Show("Informes generados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar informes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CrearDataTableDesdeDataGridView()
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.HeaderText != "btnSeleccionar")
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
            }

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Visible)
                {
                    DataRow dtRow = dt.NewRow();

                    for (int i = 1; i < dt.Columns.Count + 1; i++)
                    {
                        dtRow[i - 1] = row.Cells[i].Value.ToString();
                    }

                    dt.Rows.Add(dtRow);
                }
            }

            return dt;
        }

        private string ObtenerRutaArchivo()
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.FileName = string.Format("InformeProducto_{0}", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "CSV File | *.csv| JSON File | *.json";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    return saveFile.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
        private IInforme ObtenerInstanciaInforme(string extension)
        {
            IInforme informe = null;

            if (extension == ".csv")
            {
                informe = new InformeCsv();
            }
            else if (extension == ".json")
            {
                informe = new InformeJson();
            }

            return informe;
        }
    }
}
