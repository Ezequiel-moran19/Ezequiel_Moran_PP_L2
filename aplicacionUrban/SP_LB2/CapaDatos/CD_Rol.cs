using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public class CD_Rol 
    {
        /// <summary>
        /// Obtiene una lista de roles desde la base de datos.
        /// </summary>
        /// <returns>Lista de roles.</returns>
        public List<Rol> Listar()
        {
            List<Rol> listaUsuario = new List<Rol>();

            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {

                    SqlCommand sqlCommand = new SqlCommand(MostrarDatosRol(), connection);

                    sqlCommand.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idRol = Convert.ToInt32(dr["IdRol"]);
                            string descripcion = dr["Descripcion"].ToString();
                            listaUsuario.Add(new Rol(idRol, descripcion));
                        }
                    }
                }
                catch (Exception)
                {
                    listaUsuario = new List<Rol>();
                }
                return listaUsuario;
            }
        }
        /// <summary>
        /// Genera la consulta SQL para obtener los datos de los roles.
        /// </summary>
        /// <returns>Consulta SQL.</returns>
        public static string MostrarDatosRol()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select IdRol,Descripcion from ROL");
            return query.ToString();

        }
    }
}


