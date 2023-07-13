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

        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT p.IdProducto, p.Codigo, p.Nombre, p.Descripcion, c.IdCategoria, c.Descripcion AS DescripcionCategoria, p.stock, p.PrecioCompra, p.PrecioVenta, p.Estado");
            query.AppendLine("FROM PRODUCTO p");
            query.AppendLine("INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria");

            return query.ToString();
        }
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

/*
 *    public List<Producto> Listar()
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
                return listaProducto;
            }
        }
        private Producto ObtenerDataReader(SqlDataReader dr)
        {
            int idCategoria = Convert.ToInt32(dr["IdCategoria"]);
            string descripcionCategoria = dr["DescripcionCategoria"].ToString();
            int IdProducto = Convert.ToInt32(dr["IdProducto"]);
            string? codigo = dr["Codigo"].ToString();
            string? nombre = dr["Nombre"].ToString();
            string? descripcion = dr["Descripcion"].ToString();
            Categoria categoria = new Categoria(idCategoria, descripcionCategoria);
            int stock = Convert.ToInt32(dr["Stock"].ToString());
            decimal precioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString());
            decimal precioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString());
            bool estado = Convert.ToBoolean(dr["Estado"]);
            eEstado estadoEnum = estado ? eEstado.Activo : eEstado.NoActivo;
            return new Producto(IdProducto, codigo, nombre, descripcion, categoria, stock, precioCompra, precioVenta, estadoEnum);
        }
        public int Registrar(Producto obj, out string Mensaje)
        {
            int idProductogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", connection);
                    ConfigurarParametros(cmd, obj);
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    idProductogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProductogenerado = 0;
                Mensaje = ex.Message;
            }
            return idProductogenerado;
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProducto", connection);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    ConfigurarParametros(cmd, obj);
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", connection);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine(" select IdProducto, Codigo, Nombre, p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],stock,PrecioCompra,PrecioVenta,p.Estado from PRODUCTO p");
            query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");
            return query.ToString();
        }
       
 */