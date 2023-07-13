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
    public class CD_Proveedor : IMIInterfaz<Proveedor>
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> listaProveedor = new List<Proveedor>();

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
                            listaProveedor.Add(ObtenerDataReader(dr));
                        }
                    }
                }
                catch (Exception)
                {
                    listaProveedor = new List<Proveedor>();
                }
                return listaProveedor;
            }
        }
        private Proveedor ObtenerDataReader(SqlDataReader dr)
        {
            int idProveedor = Convert.ToInt32(dr["IdProveedor"]);
            string? documento = dr["Documento"].ToString();
            string? razonSocial = dr["RazonSocial"].ToString();
            string? correo = dr["Correo"].ToString();
            string? telefono = dr["Telefono"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);
            eEstado estadoEnum = estado ? eEstado.Activo : eEstado.NoActivo;
            return new Proveedor(idProveedor, documento, razonSocial, correo, telefono, estadoEnum);
        }
        public int Registrar(Proveedor obj, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PROVEEDOR (Documento, RazonSocial, Correo, Telefono, Estado) VALUES (@Documento, @RazonSocial, @Correo, @Telefono, @Estado); SELECT SCOPE_IDENTITY();", connection);
                    ConfigurarParametros(cmd, obj);

                    connection.Open();
                    idProveedorGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }

        public bool Editar(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE PROVEEDOR SET Documento = @Documento, RazonSocial = @RazonSocial, Correo = @Correo, Telefono = @Telefono, Estado = @Estado WHERE IdProveedor = @IdProveedor", connection);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);
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

        public bool Eliminar(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor", connection);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);
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
            query.AppendLine("SELECT IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado FROM PROVEEDOR");
            return query.ToString();
        }
        private void ConfigurarParametros(SqlCommand cmd, Proveedor obj)
        {
            cmd.Parameters.AddWithValue("@Documento", obj.Documento);
            cmd.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
            cmd.Parameters.AddWithValue("@Correo", obj.Correo);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
        }
    }
}

/*

      */

//
/*
   public List<Proveedor> Listar()
        {
            List<Proveedor> listaProveedor = new List<Proveedor>();

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
                            listaProveedor.Add(ObtenerDataReader(dr));
                        }
                    }
                }
                catch (Exception)
                {
                    listaProveedor = new List<Proveedor>();
                }
                return listaProveedor;
            }
        }
        private Proveedor ObtenerDataReader(SqlDataReader dr)
        {
            int idProveedor = Convert.ToInt32(dr["IdProveedor"]);
            string? documento = dr["Documento"].ToString();
            string? razonSocial = dr["RazonSocial"].ToString();
            string? correo = dr["Correo"].ToString();
            string? telefono = dr["Telefono"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);
            return new Proveedor(idProveedor, documento, razonSocial, correo, telefono, estado);
        }
        public int Registrar(Proveedor obj, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PROVEEDOR (Documento, RazonSocial, Correo, Telefono, Estado) VALUES (@Documento, @RazonSocial, @Correo, @Telefono, @Estado); SELECT SCOPE_IDENTITY();", connection);
                    ConfigurarParametros(cmd, obj);

                    connection.Open();
                    idProveedorGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }

        public bool Editar(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE PROVEEDOR SET Documento = @Documento, RazonSocial = @RazonSocial, Correo = @Correo, Telefono = @Telefono, Estado = @Estado WHERE IdProveedor = @IdProveedor", connection);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);
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

        public bool Eliminar(Proveedor obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM PROVEEDOR WHERE IdProveedor = @IdProveedor", connection);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);

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
            query.AppendLine("SELECT IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado FROM PROVEEDOR");
            return query.ToString();
        }

      
        private void ConfigurarParametros(SqlCommand cmd, Proveedor obj)
        {
            cmd.Parameters.AddWithValue("@Documento", obj.Documento);
            cmd.Parameters.AddWithValue("@RazonSocial", obj.RazonSocial);
            cmd.Parameters.AddWithValue("@Correo", obj.Correo);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
        }
 */