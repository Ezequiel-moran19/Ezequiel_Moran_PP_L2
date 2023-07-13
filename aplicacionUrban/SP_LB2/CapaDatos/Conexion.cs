
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        static string connectionString;
        static SqlCommand conexionCommand;
        static SqlConnection conexionConnection;
        static Conexion()
        {
            connectionString = @"Data Source=DESKTOP-OVA03KE\SQLEXPRESS;Database=TIENDA_AMARILLA;Trusted_Connection=True;";
            conexionCommand = new SqlCommand();
            conexionConnection = new SqlConnection(connectionString);
            conexionCommand.CommandType = System.Data.CommandType.Text;
            conexionCommand.Connection = conexionConnection;
        }

        /// <summary>
        /// Obtiene una nueva instancia de SqlConnection para la conexión a la base de datos.
        /// </summary>
        /// <returns>Una instancia de SqlConnection.</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}