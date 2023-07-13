using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modal;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Urban
{
    public partial class FrmCompras : Form
    {
        private Usuario _Ususario;
        public FrmCompras(Usuario? Obj_suario = null)
        {
            _Ususario = Obj_suario;
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarEstado();
        }
        private void CargarEstado()
        {
            cmbTipoDocumento.Items.Add(new OpcionesCombo() { Valor = "Boleta", Texto = "Boleta" });
            cmbTipoDocumento.Items.Add(new OpcionesCombo() { Valor = "Factura", Texto = "Factura" });
            cmbTipoDocumento.DisplayMember = "Texto";
            cmbTipoDocumento.ValueMember = "Valor";
            cmbTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtIdProveedor.Text = "0";
            txtIdProducto.Text = "0";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Proveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal.Modal_Proveedor.IdProveedor.ToString();
                    txtDocProveedor.Text = modal.Modal_Proveedor.Documento;
                    txtRazonSocial.Text = modal.Modal_Proveedor.RazonSocial;
                }
                else
                {
                    txtDocProveedor.Select();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Producto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal.Modal_Producto.IdProducto.ToString();
                    txtCodProducto.Text = modal.Modal_Producto.Codigo;
                    txtProducto.Text = modal.Modal_Producto.Nombre;
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodProducto.Select();
                }
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodProducto.Text && p.Estado == eEstado.Activo).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProducto.BackColor = Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodProducto.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool producto_existente = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    producto_existente = true;
                    break;
                }
            }
            if (!producto_existente)
            {
                dgvdata.Rows.Add(new object[] {
                   txtIdProducto.Text,
                   txtProducto.Text,
                   precioCompra.ToString("0.00"),
                   precioVenta.ToString("0.00"),
                   txtCantidad.Value.ToString(),
                   (txtCantidad.Value * precioCompra).ToString("0.00")
                });
                CalcularTotal();
                LimpiarCampos();
                txtCodProducto.Select();
            }
        }
        private void LimpiarCampos()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = Color.White;
            txtProducto.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Value = 1;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }
            txtTotalAPagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvdata.Columns[0] is DataGridViewButtonColumn)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);

                using (Brush backColorBrush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                e.Paint(e.CellBounds, DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground);
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(
                  new object[] {
                    Convert.ToInt32(row.Cells["IdProducto"].Value ?? 0),
                    Convert.ToDecimal(row.Cells["PrecioCompra"].Value ?? 0),
                    Convert.ToDecimal(row.Cells["PrecioVenta"].Value ?? 0),
                    Convert.ToInt32(row.Cells["Cantidad"].Value ?? 0),
                    Convert.ToDecimal(row.Cells["SubTotal"].Value ?? 0)
               });
            }
            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Usuario idUsuario = new Usuario(_Ususario.IdUsuario);
            int auxPro = Convert.ToInt32(txtIdProveedor.Text);
            Proveedor idProveedor = new Proveedor(auxPro);
            string tipoDocumento = ((OpcionesCombo)cmbTipoDocumento.SelectedItem).Texto;
            string numeroDocumento = numerodocumento;
            decimal montoTotal = Convert.ToDecimal(txtTotalAPagar.Text);

            Compra compra = new Compra(idUsuario, idProveedor, tipoDocumento, numeroDocumento, montoTotal);

            string mensaje = "";
            bool respuesta = new CN_Compra().Registrar(compra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n Desea copiar al portapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtIdProducto.Text = "0";
                txtDocProveedor.Text = "";
                dgvdata.Rows.Clear();
                CalcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }


    }
}
