using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuario : IMIInterfaz<Usuario>
    {
        private string mensaje;

        /// <summary>
        /// Delegado para manejar el evento de registro de movimiento.
        /// </summary>
        /// <param name="mensaje">Mensaje del movimiento registrado.</param>
        public delegate void RegistroMovimientoDelegado(string mensaje);
        /// <summary>
        /// Evento que se dispara cuando se registra un movimiento.
        /// </summary>
        public event RegistroMovimientoDelegado MovimientoRegistrado;
        /// <summary>
        /// Obtiene una lista de usuarios desde la base de datos.
        /// </summary>
        /// <returns>Lista de usuarios.</returns>
        public List<Usuario> Listar()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

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
                            listaUsuario.Add(ObtenerUsuarioDesdeDataReader(dr));
                        }
                    }
                    mensaje = "Se realizó la consulta de usuarios";
                    MovimientoRegistrado?.Invoke(mensaje);
                }
                catch (Exception)
                {
                     listaUsuario = new List<Usuario>();
                     mensaje = $"Error al consultar usuarios";
                     MovimientoRegistrado?.Invoke(mensaje);
                }
                return listaUsuario;
            }
        }
        /// <summary>
        /// Genera la consulta SQL para obtener los usuarios desde la base de datos.
        /// </summary>
        /// <returns>Consulta SQL para obtener los usuarios.</returns>
        public string MostrarConsultas()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion FROM USUARIO u");
            query.AppendLine("INNER JOIN ROL r ON r.IdRol = u.IdRol");
            return query.ToString();
        }
        /// <summary>
        /// Convierte los datos de un SqlDataReader a un objeto Usuario.
        /// </summary>
        /// <param name="dr">SqlDataReader con los datos del usuario.</param>
        /// <returns>Objeto Usuario.</returns>
        private Usuario ObtenerUsuarioDesdeDataReader(SqlDataReader dr)
        {
            int idUsuario = Convert.ToInt32(dr["IdUsuario"]);
            string? documento = dr["Documento"].ToString();
            string? nombre = dr["NombreCompleto"].ToString();
            string? correo = dr["Correo"].ToString();
            string? clave = dr["Clave"].ToString();
            bool estado = Convert.ToBoolean(dr["Estado"]);
            eEstado estadoEnum = estado ? eEstado.Activo : eEstado.NoActivo;
            int idRol = Convert.ToInt32(dr["IdRol"]);
            string? descripcion = dr["Descripcion"].ToString();
            Rol rol = new Rol(idRol, descripcion);
            return new Usuario(idUsuario, documento, nombre, correo, clave, estadoEnum, rol);
        }
        /// <summary>
        /// Registra un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="obj">Usuario a registrar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Id del usuario generado.</returns>
        public int Registrar(Usuario obj, out string mensaje)
        {
            int idUsuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado); SELECT SCOPE_IDENTITY();", connection);
                    ConfigurarParametros(cmd, obj);

                    connection.Open();
                    idUsuarioGenerado = Convert.ToInt32(cmd.ExecuteScalar());

                    mensaje = idUsuarioGenerado > 0 ? "Se agregó un nuevo usuario" : "Error al agregar un usuario";
                    MovimientoRegistrado?.Invoke(mensaje);
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }
        /// <summary>
        /// Edita los datos de un usuario en la base de datos.
        /// </summary>
        /// <param name="obj">Usuario a editar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indica si la operación de edición fue exitosa.</returns>
        public bool Editar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE USUARIO SET Documento = @Documento, NombreCompleto = @NombreCompleto, Correo = @Correo, Clave = @Clave, IdRol = @IdRol, Estado = @Estado WHERE IdUsuario = @IdUsuario", connection);
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                    ConfigurarParametros(cmd, obj);
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    respuesta = (rowsAffected > 0);
                    mensaje = respuesta ? "Se editó el usuario" : "Error al editar el usuario";
                    MovimientoRegistrado?.Invoke(mensaje);
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
        /// Elimina un usuario de la base de datos.
        /// </summary>
        /// <param name="obj">Usuario a eliminar.</param>
        /// <param name="mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indica si la operación de eliminación fue exitosa.</returns>
        public bool Eliminar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = Conexion.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario", connection);
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    respuesta = (rowsAffected > 0);
                    mensaje = respuesta ? "Se eliminó el usuario" : "Error al eliminar el usuario";
                    MovimientoRegistrado?.Invoke(mensaje);
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
        /// Configura los parámetros del comando SQL con los valores del usuario.
        /// </summary>
        /// <param name="cmd">Comando SQL.</param>
        /// <param name="obj">Usuario.</param>
        private void ConfigurarParametros(SqlCommand cmd, Usuario obj)
        {
            cmd.Parameters.AddWithValue("@Documento", obj.Documento);
            cmd.Parameters.AddWithValue("@NombreCompleto", obj.Nombre);
            cmd.Parameters.AddWithValue("@Correo", obj.Correo);
            cmd.Parameters.AddWithValue("@Clave", obj.Clave);
            cmd.Parameters.AddWithValue("@IdRol", obj.Obj_Rol.IdRol);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
        }
    }
}
