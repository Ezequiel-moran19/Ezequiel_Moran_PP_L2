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
    public class CD_Cliente : IMIInterfaz<Cliente>
    {
        /// <summary>
        /// Obtiene una lista de clientes desde la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public List<Cliente> Listar()
        {
            List<Cliente> listaCliente = new List<Cliente>();

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
                            listaCliente.Add(ObtenerClienteDesdeDataReader(dr));
                        }
                    }

                }
                catch (Exception)
                {
                    listaCliente = new List<Cliente>();
                }
                return listaCliente;
            }
        }
        /// <summary>
        /// Crea un objeto Cliente a partir de un DataReader.
        /// </summary>
        /// <param name="dr">DataReader con los datos del cliente.</param>
        /// <returns>Objeto Cliente.</returns>
        private Cliente ObtenerClienteDesdeDataReader(SqlDataReader dr)
        {
            int idCliente = Convert.ToInt32(dr["IdCliente"]);
            string? documento = dr["Documento"].ToString();
            string? NombreCompleto = dr["NombreCompleto"].ToString();
            string? correo = dr["Correo"].ToString();
            string? telefono = dr["Telefono"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);
            eEstado estadoEnum = estado ? eEstado.Activo : eEstado.NoActivo;
            return new Cliente(idCliente, documento, NombreCompleto, correo, telefono, estadoEnum);
        }
        /// <summary>
        /// Registra un nuevo cliente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Cliente a registrar.</param>
        /// <param name="Mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Id del cliente generado.</returns>
        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idClientegenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCliente", connection);
                    ConfigurarParametros(cmd, obj);
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    idClientegenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClientegenerado = 0;
                Mensaje = ex.Message;
            }
            return idClientegenerado;
        }
        /// <summary>
        /// Edita los datos de un cliente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Cliente a editar.</param>
        /// <param name="Mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indica si la operación de edición fue exitosa.</returns>
        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarCliente", connection);
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
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
        /// <summary>
        /// Elimina un cliente de la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Cliente a eliminar.</param>
        /// <param name="Mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indica si la operación de eliminación fue exitosa.</returns>
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("delete from cliente where IdCliente = @id", connection);
                    cmd.Parameters.AddWithValue("@id", obj.IdCliente);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                   respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
        /// <summary>
        /// Genera la consulta SQL para obtener la lista de clientes.
        /// </summary>
        /// <returns>Consulta SQL.</returns>
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select IdCliente,Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE");
            return query.ToString();
        }
        /// <summary>
        /// Configura los parámetros del comando SQL con los datos del cliente.
        /// </summary>
        /// <param name="cmd">Comando SQL.</param>
        /// <param name="obj">Objeto Cliente.</param>
        private void ConfigurarParametros(SqlCommand cmd, Cliente obj)
        {
            cmd.Parameters.AddWithValue("Documento", obj.Documento);
            cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
            cmd.Parameters.AddWithValue("Correo", obj.Correo);
            cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
            cmd.Parameters.AddWithValue("Estado", obj.Estado);
            cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
        }
    }
}
