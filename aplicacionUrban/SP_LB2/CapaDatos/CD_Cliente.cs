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
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select IdCliente,Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE");
            return query.ToString();
        }
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
