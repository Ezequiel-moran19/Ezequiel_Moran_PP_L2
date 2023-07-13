using CapaEntidad;
using CapaNegocio;
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
    public partial class FrmDetalleCompra : Form
    {
        public FrmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra objCompra = new CN_Compra().ObtenerCompra(txtBusqueda.Text);

            if (objCompra.IdCompra != 0)
            {
                txtNumDocumento.Text = objCompra.NumeroDocumento;

                txtFecha.Text = objCompra.FechaRegistro;
                txtTipoDocumento.Text = objCompra.TipoDocumento;
                txtUsuario.Text = objCompra.Obj_Usuario.Nombre;
                txtDocProveedor.Text = objCompra.Obj_Proveedor.Documento;
                txtRazonSocial.Text = objCompra.Obj_Proveedor.RazonSocial;

                dgvdata.Rows.Clear();
                foreach (Detalle_Compra dc in objCompra.Obj_Detalle_Compra)
                {
                    dgvdata.Rows.Add(new object[] { dc.Obj_Producto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }
                txtMontoTotal.Text = objCompra.MontoTotal.ToString("0.00");
            }
        }
    }
}
