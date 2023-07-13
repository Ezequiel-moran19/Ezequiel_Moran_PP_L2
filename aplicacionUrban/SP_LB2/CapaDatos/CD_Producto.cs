using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Producto : IMIInterfaz<Producto>
    {
        /// <summary>
        /// Obtiene una lista de productos desde la base de datos.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        public List<Producto> Listar()
        {
            List<Producto> listaProducto = new List<Producto>();

            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(MostrarConsultas(), connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaProducto.Add(ObtenerDataReader(dr));
                        }
                    }
                }
                catch (Exception)
                {
                    listaProducto = new List<Producto>();
                }
            }

            return listaProducto;
        }
        /// <summary>
        /// Obtiene un objeto Producto a partir de los datos obtenidos desde el SqlDataReader.
        /// </summary>
        /// <param name="dr">SqlDataReader con los datos del producto.</param>
        /// <returns>Objeto Producto.</returns>
        private Producto ObtenerDataReader(SqlDataReader dr)
        {
            int idCategoria = Convert.ToInt32(dr["IdCategoria"]);
            string descripcionCategoria = dr["DescripcionCategoria"].ToString();
            int idProducto = Convert.ToInt32(dr["IdProducto"]);
            string codigo = dr["Codigo"].ToString();
            string nombre = dr["Nombre"].ToString();
            string descripcion = dr["Descripcion"].ToString();
            Categoria categoria = new Categoria(idCategoria, descripcionCategoria);
            int stock = Convert.ToInt32(dr["stock"]);
            decimal precioCompra = Convert.ToDecimal(dr["PrecioCompra"]);
            decimal precioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
            bool estado = Convert.ToBoolean(dr["Estado"]);
            eEstado estadoEnum = estado ? eEstado.Activo : eEstado.NoActivo;

            return new Producto(idProducto, codigo, nombre, descripcion, categoria, stock, precioCompra, precioVenta, estadoEnum);
        }
        /// <summary>
        /// Registra un nuevo producto en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Producto a registrar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Id del producto generado.</returns>
        public int Registrar(Producto obj, out string mensaje)
        {
            int idProductoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Estado) VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado); SELECT SCOPE_IDENTITY();", connection);
                    ConfigurarParametros(cmd, obj);

                    connection.Open();
                    idProductoGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                mensaje = ex.Message;
            }

            return idProductoGenerado;
        }
        /// <summary>
        /// Edita un producto existente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Producto a editar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indicador de éxito de la operación.</returns>
        public bool Editar(Producto obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE PRODUCTO SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdCategoria = @IdCategoria, Estado = @Estado WHERE IdProducto = @IdProducto", connection);
                    cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);
                    ConfigurarParametros(cmd, obj);
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    respuesta = (rowsAffected > 0);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }
        /// <summary>
        /// Elimina un producto de la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Producto a eliminar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indicador de éxito de la operación.</returns>
        public bool Eliminar(Producto obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTO WHERE IdProducto = @IdProducto", connection);
                    cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    respuesta = (rowsAffected > 0);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }
        /// <summary>
        /// Genera la consulta SQL para obtener los datos de los productos.
        /// </summary>
        /// <returns>Consulta SQL.</returns>
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT p.IdProducto, p.Codigo, p.Nombre, p.Descripcion, c.IdCategoria, c.Descripcion AS DescripcionCategoria, p.stock, p.PrecioCompra, p.PrecioVenta, p.Estado");
            query.AppendLine("FROM PRODUCTO p");
            query.AppendLine("INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria");

            return query.ToString();
        }
        /// <summary>
        /// Configura los parámetros de un SqlCommand con los datos del objeto Producto.
        /// </summary>
        /// <param name="cmd">SqlCommand a configurar.</param>
        /// <param name="obj">Objeto Producto.</param>
        private void ConfigurarParametros(SqlCommand cmd, Producto obj)
        {
            cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
            cmd.Parameters.AddWithValue("@IdCategoria", obj.Obj_Categoria.IdCategoria);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
        }
    }
}

