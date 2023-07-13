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
        /// <summary>
        /// Obtiene una lista de categorías desde la base de datos.
        /// </summary>
        /// <returns>Lista de categorías.</returns>
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
        /// <summary>
        /// Registra una nueva categoría en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Categoria a registrar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Id de la categoría generada.</returns>
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
        /// <summary>
        /// Edita una categoría existente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Categoria a editar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indicador de éxito de la operación.</returns>
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
        /// <summary>
        /// Elimina una categoría de la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Categoria a eliminar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indicador de éxito de la operación.</returns>
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
        /// <summary>
        /// Genera la consulta SQL para obtener los datos de las categorías.
        /// </summary>
        /// <returns>Consulta SQL.</returns>
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT IdCategoria, Descripcion, Estado FROM CATEGORIA");

            return query.ToString();
        }
        /// <summary>
        /// Obtiene un objeto Categoria a partir de los datos obtenidos desde el SqlDataReader.
        /// </summary>
        /// <param name="dr">SqlDataReader con los datos de la categoría.</param>
        /// <returns>Objeto Categoria.</returns>
        private Categoria ObtenerDesdeDataReader(SqlDataReader dr)
        {
            int idCategoria = Convert.ToInt32(dr["IdCategoria"]);
            string descripcion = dr["Descripcion"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);

            return new Categoria(idCategoria, descripcion, estado);
        }
    }
}
