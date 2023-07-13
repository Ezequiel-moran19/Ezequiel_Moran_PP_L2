using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario : ICapaNegocio<Usuario>
    {
        public string Mensaje { get; set; }

        private CD_Usuario Obj_usuario = new CD_Usuario();
        /// <summary>
        /// Evento que se dispara cuando se registra un movimiento en la capa de datos.
        /// </summary>
        public event CD_Usuario.RegistroMovimientoDelegado MovimientoRegistrado
        {
            add { Obj_usuario.MovimientoRegistrado += value; }
            remove { Obj_usuario.MovimientoRegistrado -= value; }
        }
        /// <summary>
        /// Obtiene una lista de usuarios desde la capa de datos.
        /// </summary>
        /// <returns>Lista de usuarios.</returns>
        public List<Usuario> Listar()
        {
            string mensaje = "Se solicitó listar usuarios";
            return Obj_usuario.Listar();
        }
        /// <summary>
        /// Valida los datos de un usuario.
        /// </summary>
        /// <param name="obj">Usuario a validar.</param>
        /// <param name="Mensaje">Mensaje de error en caso de que la validación falle.</param>
        /// <returns>Indica si la validación es exitosa.</returns>
        public bool Validar(Usuario obj, ref string Mensaje)
        {
            if (string.IsNullOrEmpty(obj.Documento))
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }
            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }
            if (string.IsNullOrEmpty(obj.Clave))
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        /// <summary>
        /// Registra un nuevo usuario.
        /// </summary>
        /// <param name="obj">Usuario a registrar.</param>
        /// <param name="Mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Id del usuario generado.</returns>
        public int Registrar(Usuario obj, out string Mensaje) 
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            return Obj_usuario.Registrar(obj, out Mensaje);
           
        }
        /// <summary>
        /// Edita los datos de un usuario.
        /// </summary>
        /// <param name="obj">Usuario a editar.</param>
        /// <param name="Mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indica si la operación de edición fue exitosa.</returns>
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            return Obj_usuario.Editar(obj, out Mensaje);
        }
        /// <summary>
        /// Elimina un usuario.
        /// </summary>
        /// <param name="obj">Usuario a eliminar.</param>
        /// <param name="Mensaje">Mensaje de resultado de la operación.</param>
        /// <returns>Indica si la operación de eliminación fue exitosa.</returns>
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return Obj_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
