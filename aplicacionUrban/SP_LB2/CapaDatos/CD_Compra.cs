using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo() 
        {
            int idCorrelativo = 0; 

            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(MostrarConsultas(), connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception)
                {
                    idCorrelativo = 0;
                }
            }
            return idCorrelativo;
        }
        public bool Registrar(Compra obj, DataTable DetalleCompra,out string mensaje)
        {

            mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("", connection);
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "INSERT INTO COMPRA (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal) " +
                        "VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal); " +
                        "SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@IdUsuario", obj.Obj_Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.Obj_Proveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);

                    connection.Open();
                    int idCompra = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal) " +
                        "VALUES (@IdCompra, @IdProducto, @PrecioCompra, @PrecioVenta, @Cantidad, @MontoTotal)";

                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    cmd.Parameters.Add("@IdProducto", SqlDbType.Int);
                    cmd.Parameters.Add("@PrecioCompra", SqlDbType.Decimal);
                    cmd.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Int);
                    cmd.Parameters.Add("@MontoTotal", SqlDbType.Decimal);

                    foreach (DataRow row in DetalleCompra.Rows)
                    {
                        cmd.Parameters["@IdProducto"].Value = row["IdProducto"];
                        cmd.Parameters["@PrecioCompra"].Value = row["PrecioCompra"];
                        cmd.Parameters["@PrecioVenta"].Value = row["PrecioVenta"];
                        cmd.Parameters["@Cantidad"].Value = row["Cantidad"];
                        cmd.Parameters["@MontoTotal"].Value = row["MontoTotal"];

                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "UPDATE p " +
                        "SET p.stock = p.stock + dc.Cantidad, " +
                        "    p.PrecioCompra = dc.PrecioCompra, " +
                        "    p.PrecioVenta = dc.PrecioVenta " +
                        "FROM PRODUCTO p " +
                        "INNER JOIN DETALLE_COMPRA dc ON dc.IdProducto = p.IdProducto " +
                        "WHERE dc.IdCompra = @IdCompra";

                    cmd.ExecuteNonQuery();

                    respuesta = true;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }
            return respuesta;

        }

        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select count(*) + 1 from Compra");
            return query.ToString();
        }
        public string MostrarConsultasDetalle()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select c.IdCompra,");
            query.AppendLine("u.NombreCompleto,");
            query.AppendLine("pr.Documento,pr.RazonSocial,");
            query.AppendLine("c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,convert(char(10),c.FechaRegistro,103)[FechaRegistro]");
            query.AppendLine("from COMPRA c");
            query.AppendLine("inner join USUARIO u on u.IdUsuario = c.IdUsuario");
            query.AppendLine("Inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor");
            query.AppendLine("where c.NumeroDocumento = @num");
            return query.ToString();
        }
        public Compra ObtenerCompra(string num)
        {
            Compra obj = new Compra();

            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(MostrarConsultasDetalle(), connection);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int IdCompra = Convert.ToInt32(dr["IdCompra"]);
                            string Nombre = dr["Nombre"].ToString();
                            string documento = dr["Documento"].ToString();
                            string razonSocial = dr["RazonSocial"].ToString();
                            string nombre = dr["Nombre"].ToString();
                            Usuario  Obj_Usuario = new Usuario(nombre);
                            Proveedor Obj_Proveedor = new Proveedor(documento, razonSocial);
                            string tipoDocumento = dr["TipoDocumento"].ToString();
                            string numeroDocumento = dr["NumeroDocumento"].ToString();
                            decimal montoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString());
                            string FechaRegistro = dr["FechaRegistro"].ToString();

                            obj = new Compra(IdCompra, Obj_Usuario, Obj_Proveedor, tipoDocumento, numeroDocumento, montoTotal, FechaRegistro);
                        }
                    }
                }
            
                catch (Exception)
                {
                    obj = new Compra();
                }

                return obj;
            }
        }
       
        public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
        {
            List<Detalle_Compra> listaDetalle = new List<Detalle_Compra>();

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(MostrarDetalleCompra(), connection);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaDetalle.Add(new Detalle_Compra()
                            {
                                Obj_Producto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString())
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                listaDetalle = new List<Detalle_Compra>();
            }
            return listaDetalle;
            
        }
        public string MostrarDetalleCompra()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select p.Nombre,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal from DETALLE_COMPRA dc");
            query.AppendLine("inner join PRODUCTO p on p.IdProducto = dc.IdProducto");
            query.AppendLine("where dc.IdCompra = @idcompra");
            return query.ToString();
        }
    }
}

/*
           mensaje = string.Empty;
           bool respuesta = false;

           using (SqlConnection connection = Conexion.GetConnection())
           {
               try
               {
                   connection.Open();

                   using (SqlTransaction transaction = connection.BeginTransaction())
                   {
                       try
                       {
                           // Insertar la compra en la tabla COMPRA
                           SqlCommand cmdInsertCompra = new SqlCommand("INSERT INTO COMPRA (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal) VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal); SELECT SCOPE_IDENTITY();", connection, transaction);
                           cmdInsertCompra.Parameters.AddWithValue("@IdUsuario", obj.Obj_Usuario.IdUsuario);
                           cmdInsertCompra.Parameters.AddWithValue("@IdProveedor", obj.Obj_Proveedor.IdProveedor);
                           cmdInsertCompra.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                           cmdInsertCompra.Parameters.AddWithValue("@NumeroDocumento", obj.NumeroDocumento);
                           cmdInsertCompra.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);

                           int idCompra = Convert.ToInt32(cmdInsertCompra.ExecuteScalar());

                           // Insertar el detalle de la compra en la tabla DETALLE_COMPRA
                           SqlCommand cmdInsertDetalleCompra = new SqlCommand("INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal) VALUES (@IdCompra, @IdProducto, @PrecioCompra, @PrecioVenta, @Cantidad, @MontoTotal);", connection, transaction);
                           cmdInsertDetalleCompra.Parameters.AddWithValue("@IdCompra", idCompra);
                           cmdInsertDetalleCompra.Parameters.Add("@IdProducto", SqlDbType.Int);
                           cmdInsertDetalleCompra.Parameters.Add("@PrecioCompra", SqlDbType.Decimal);
                           cmdInsertDetalleCompra.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
                           cmdInsertDetalleCompra.Parameters.Add("@Cantidad", SqlDbType.Int);
                           cmdInsertDetalleCompra.Parameters.Add("@MontoTotal", SqlDbType.Decimal);

                           foreach (DataRow row in DetalleCompra.Rows)
                           {
                               cmdInsertDetalleCompra.Parameters["@IdProducto"].Value = row["IdProducto"];
                               cmdInsertDetalleCompra.Parameters["@PrecioCompra"].Value = row["PrecioCompra"];
                               cmdInsertDetalleCompra.Parameters["@PrecioVenta"].Value = row["PrecioVenta"];
                               cmdInsertDetalleCompra.Parameters["@Cantidad"].Value = row["Cantidad"];
                               cmdInsertDetalleCompra.Parameters["@MontoTotal"].Value = row["MontoTotal"];

                               cmdInsertDetalleCompra.ExecuteNonQuery();
                           }

                           // Actualizar el stock y precios de los productos
                           SqlCommand cmdUpdateProducto = new SqlCommand("UPDATE PRODUCTO SET Stock = Stock + @Cantidad, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta WHERE IdProducto = @IdProducto;", connection, transaction);
                           cmdUpdateProducto.Parameters.Add("@Cantidad", SqlDbType.Int);
                           cmdUpdateProducto.Parameters.Add("@PrecioCompra", SqlDbType.Decimal);
                           cmdUpdateProducto.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
                           cmdUpdateProducto.Parameters.Add("@IdProducto", SqlDbType.Int);

                           foreach (DataRow row in DetalleCompra.Rows)
                           {
                               cmdUpdateProducto.Parameters["@Cantidad"].Value = row["Cantidad"];
                               cmdUpdateProducto.Parameters["@PrecioCompra"].Value = row["PrecioCompra"];
                               cmdUpdateProducto.Parameters["@PrecioVenta"].Value = row["PrecioVenta"];
                               cmdUpdateProducto.Parameters["@IdProducto"].Value = row["IdProducto"];

                               cmdUpdateProducto.ExecuteNonQuery();
                           }

                           transaction.Commit();
                           respuesta = true;
                       }
                       catch (Exception ex)
                       {
                           transaction.Rollback();
                           respuesta = false;
                           mensaje = ex.Message;
                       }
                   }
               }
               catch (Exception ex)
               {
                   respuesta = false;
                   mensaje = ex.Message;
               }
           }

           return respuesta;
           */