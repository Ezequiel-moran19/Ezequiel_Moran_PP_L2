using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Permiso
    {
        /// <summary>
        /// Obtiene una lista de permisos para un usuario específico desde la base de datos.
        /// </summary>
        /// <param name="IdUsuario">Id del usuario.</param>
        /// <returns>Lista de permisos.</returns>
        public List<Permiso> Listar(int IdUsuario)
        {
            List<Permiso> listaUsuario = new List<Permiso>();

            using (SqlConnection connection = Conexion.GetConnection())
            {
                try
                {

                    SqlCommand sqlCommand = new SqlCommand(MostrarPermisos(), connection);
                    sqlCommand.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    sqlCommand.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaUsuario.Add(new Permiso()
                            {
                                Obj_Rol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                             
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    listaUsuario = new List<Permiso>();
                }
                return listaUsuario;
            }
        }
        /// <summary>
        /// Genera la consulta SQL para obtener los permisos de un usuario.
        /// </summary>
        /// <returns>Consulta SQL.</returns>
        public static string MostrarPermisos() 
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("select p.IdRol, p.NombreMenu from PERMISO p");
            query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
            query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
            query.AppendLine("where u.IdUsuario = @IdUsuario");
            return query.ToString();
            
        }
    }
}
