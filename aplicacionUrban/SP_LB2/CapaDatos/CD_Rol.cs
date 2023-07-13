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
        public static string MostrarDatosRol()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select IdRol,Descripcion from ROL");
            return query.ToString();

        }
    }
}


