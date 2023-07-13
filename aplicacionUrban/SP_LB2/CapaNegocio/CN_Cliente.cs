using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente : ICapaNegocio<Cliente>
    {
        private CD_Cliente Obj_Cliente = new CD_Cliente();
        /// <summary>
        /// Obtiene una lista de clientes.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public List<Cliente> Listar()
        {
            return Obj_Cliente.Listar();
        }
        /// <summary>
        /// Valida los datos de un objeto Cliente.
        /// </summary>
        /// <param name="obj">Objeto Cliente a validar.</param>
        /// <param name="Mensaje">Mensaje de validación.</param>
        /// <returns>True si los datos son válidos, false en caso contrario.</returns>
        public bool Validar(Cliente obj, ref string Mensaje)
        {
            if (string.IsNullOrEmpty(obj.Documento))
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }
            if (string.IsNullOrEmpty(obj.NombreCompleto))
            {
                Mensaje += "Es necesario el nombre del Cliente\n";
            }
            if (string.IsNullOrEmpty(obj.Correo))
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }

        /// <summary>
        /// Registra un cliente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Cliente a registrar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>El id del cliente registrado.</returns>
        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            return Obj_Cliente.Registrar(obj, out Mensaje);
        }
        /// <summary>
        /// Edita los datos de un cliente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Cliente a editar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la edición se realizó correctamente, false en caso contrario.</returns>
        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            return Obj_Cliente.Editar(obj, out Mensaje);
        }
        /// <summary>
        /// Elimina un cliente de la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Cliente a eliminar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la eliminación se realizó correctamente, false en caso contrario.</returns>
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return Obj_Cliente.Eliminar(obj, out Mensaje);
        }
    }
}
