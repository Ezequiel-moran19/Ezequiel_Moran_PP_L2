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
    public class CD_Categoria : IMIInterfaz<Categoria>
    {
        public List<Categoria> Listar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();

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
                            listaCategoria.Add(ObtenerDesdeDataReader(dr));
                        }
                    }
                }
                catch (Exception)
                {
                    listaCategoria = new List<Categoria>();
                }
            }

            return listaCategoria;
        }

        public int Registrar(Categoria obj, out string mensaje)
        {
            int idCategoriaGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO CATEGORIA (Descripcion, Estado) VALUES (@Descripcion, @Estado); SELECT SCOPE_IDENTITY();", connection);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                    connection.Open();
                    idCategoriaGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                idCategoriaGenerado = 0;
                mensaje = ex.Message;
            }

            return idCategoriaGenerado;
        }

        public bool Editar(Categoria obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE CATEGORIA SET Descripcion = @Descripcion, Estado = @Estado WHERE IdCategoria = @IdCategoria", connection);
                    cmd.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);

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

        public bool Eliminar(Categoria obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM CATEGORIA WHERE IdCategoria = @IdCategoria", connection);
                    cmd.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);

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
            query.AppendLine("SELECT IdCategoria, Descripcion, Estado FROM CATEGORIA");

            return query.ToString();
        }

        private Categoria ObtenerDesdeDataReader(SqlDataReader dr)
        {
            int idCategoria = Convert.ToInt32(dr["IdCategoria"]);
            string descripcion = dr["Descripcion"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);

            return new Categoria(idCategoria, descripcion, estado);
        }
    }
}
/*
public List<Categoria> Listar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();

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
                            listaCategoria.Add(ObtenerDesdeDataReader(dr));
                        }
                    }
                }
                catch (Exception)
                {
                    listaCategoria = new List<Categoria>();
                }
                return listaCategoria;
            }
        }
        private Categoria ObtenerDesdeDataReader(SqlDataReader dr)
        {
            int idCategoria = Convert.ToInt32(dr["IdCategoria"]);
            string? descripcion = dr["Descripcion"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);
            return new Categoria(idCategoria, descripcion, estado);
        }
        public int Registrar(Categoria obj, out string Mensaje)
        {
            int idCategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", connection);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    idCategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCategoriagenerado = 0;
                Mensaje = ex.Message;
            }
            return idCategoriagenerado;
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarCatgoeria", connection);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
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
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", connection);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
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
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select IdCategoria,Descripcion,Estado From CATEGORIA");
           
            return query.ToString();
        }
        private void ConfigurarParametros(SqlCommand cmd, Categoria obj)
        {
            cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
            cmd.Parameters.AddWithValue("Estado", obj.Estado);
            cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
        }
 */