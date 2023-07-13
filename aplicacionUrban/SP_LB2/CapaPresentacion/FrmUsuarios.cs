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

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarEstado();
            CargarRoles();
            CargarColumnasBusqueda();
            MostrarUsuarios();
        }
        private void CargarEstado()
        {
            cmbEstado.Items.Add(new OpcionesCombo("Activo", eEstado.Activo));
            cmbEstado.Items.Add(new OpcionesCombo("No Activo", eEstado.NoActivo));
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;
        }
        private void CargarRoles()
        {
            List<Rol> listRol = new CN_Rol().Listar();

            foreach (Rol item in listRol)
            {
                cmbrol.Items.Add(new OpcionesCombo(item.Descripcion, item.IdRol));
            }
            cmbrol.DisplayMember = "Texto";
            cmbrol.ValueMember = "Valor";
            cmbrol.SelectedIndex = 0;
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
        private void MostrarUsuarios()
        {
            List<Usuario> listUsuarios = new CN_Usuario().Listar();
            foreach (Usuario item in listUsuarios)
            {
                bool estado = item.Estado.Equals(eEstado.Activo);
                dgvData.Rows.Add(new object[] {
                "", item.IdUsuario, item.Documento, item.Nombre, item.Correo, item.Clave,
                item.Obj_Rol.IdRol, item.Obj_Rol.Descripcion,
                estado,
                estado ? "Activo" : "No Activo"
                 });
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = ObtenerUsuarioDesdeFormulario();

            if (objUsuario != null)
            {
                string mensaje = string.Empty;

                if (objUsuario.IdUsuario == 0)
                {
                    int idUsuarioIngresado = RegistrarUsuario(objUsuario, out mensaje);

                    if (idUsuarioIngresado != 0)
                    {
                        AgregarUsuarioAlDataGridView(idUsuarioIngresado, objUsuario);
                        LimpiarCamposTextos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    bool resultado = EditarUsuario(objUsuario, out mensaje);
                    if (resultado)
                    {
                        ActualizarUsuarioEnDataGridView(objUsuario);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }
        private Usuario ObtenerUsuarioDesdeFormulario()
        {
            int idUsuario = Convert.ToInt32(txtId.Text);
            string documento = txtDocumento.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            int idRol = Convert.ToInt32(((OpcionesCombo)cmbrol.SelectedItem).Valor);
            Rol rol = new Rol(idRol);
            eEstado estado = Convert.ToInt32(((OpcionesCombo)cmbEstado.SelectedItem).Valor) == 1 ? eEstado.Activo : eEstado.NoActivo;

            Usuario objUsuario = new Usuario(idUsuario, documento, nombre, correo, clave, estado, rol);

            return objUsuario;
        }
        private int RegistrarUsuario(Usuario usuario, out string mensaje)
        {
            return new CN_Usuario().Registrar(usuario, out mensaje);
        }
        private void AgregarUsuarioAlDataGridView(int idUsuario, Usuario usuario)
        {
            dgvData.Rows.Add(new object[] {"", idUsuario, usuario.Documento, usuario.Nombre, usuario.Correo, usuario.Clave,
            ((OpcionesCombo)cmbrol.SelectedItem).Valor.ToString(),
            ((OpcionesCombo)cmbrol.SelectedItem).Texto.ToString(),
            ((OpcionesCombo)cmbEstado.SelectedItem).Valor.ToString(),
            ((OpcionesCombo)cmbEstado.SelectedItem).Texto.ToString(),
            });
        }
        private bool EditarUsuario(Usuario usuario, out string mensaje)
        {
            return new CN_Usuario().Editar(usuario, out mensaje);
        }

        private void ActualizarUsuarioEnDataGridView(Usuario usuario)
        {
            int indice = Convert.ToInt32(txtIndice.Text);
            if (indice >= 0)
            {
                DataGridViewRow row = dgvData.Rows[indice];
                AsignarValoresCeldas(row, usuario);
            }
        }
        private void AsignarValoresCeldas(DataGridViewRow row, Usuario usuario)
        {
            row.Cells["IdUsuario"].Value = usuario.IdUsuario.ToString();
            row.Cells["Documento"].Value = usuario.Documento;
            row.Cells["Nombre"].Value = usuario.Nombre;
            row.Cells["Correo"].Value = usuario.Correo;
            row.Cells["Clave"].Value = usuario.Clave;
            row.Cells["IdRol"].Value = ((OpcionesCombo)cmbrol.SelectedItem).Valor.ToString();
            row.Cells["Rol"].Value = ((OpcionesCombo)cmbrol.SelectedItem).Valor.ToString();
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
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cmbrol.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            txtDocumento.Select();
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
            txtId.Text = row.Cells["IdUsuario"].Value.ToString();
            txtDocumento.Text = row.Cells["Documento"].Value.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtCorreo.Text = row.Cells["Correo"].Value.ToString();
            txtClave.Text = row.Cells["Clave"].Value.ToString();
            txtConfirmarClave.Text = row.Cells["Clave"].Value.ToString();

            foreach (OpcionesCombo opcion_Combo in cmbrol.Items)
            {
                int idRolCombo;
                if (int.TryParse(opcion_Combo.Valor.ToString(), out idRolCombo))
                {
                    int idRol;
                    if (int.TryParse(row.Cells["IdRol"].Value.ToString(), out idRol))
                    {
                        if (idRolCombo == idRol)
                        {
                            int indice_combo = cmbrol.Items.IndexOf(opcion_Combo);
                            cmbrol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
            foreach (OpcionesCombo opcion_Combo in cmbEstado.Items)
            {
                int estadoCombo;
                if (int.TryParse(opcion_Combo.Valor.ToString(), out estadoCombo))
                {
                    int estado;
                    if (int.TryParse(row.Cells["EstadoValor"].Value.ToString(), out estado))
                    {
                        if (estadoCombo == estado)
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(opcion_Combo);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objUsuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)
                    };
                    bool respuesta = new CN_Usuario().Eliminar(objUsuario, out mensaje);

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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTextos();
        }
    }
}
