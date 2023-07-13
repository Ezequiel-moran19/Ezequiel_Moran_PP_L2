using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor : ICapaNegocio<Proveedor>
    {
        private CD_Proveedor Obj_Proveedor = new CD_Proveedor();
        /// <summary>
        /// Obtiene una lista de proveedores desde la capa de datos.
        /// </summary>
        /// <returns>Lista de proveedores.</returns>
        public List<Proveedor> Listar()
        {
            return Obj_Proveedor.Listar();
        }
        /// <summary>
        /// Valida los datos de un proveedor.
        /// </summary>
        /// <param name="obj">Proveedor a validar.</param>
        /// <param name="Mensaje">Mensaje de error.</param>
        /// <returns>True si los datos son válidos, false en caso contrario.</returns>
        public bool Validar(Proveedor obj, ref string Mensaje)
        {
            if (string.IsNullOrEmpty(obj.Documento))
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }
            if (string.IsNullOrEmpty(obj.RazonSocial))
            {
                Mensaje += "Es necesario el RazonSocial del Proveedor\n";
            }
            if (string.IsNullOrEmpty(obj.Correo))
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        /// <summary>
        /// Registra un proveedor en la base de datos.
        /// </summary>
        /// <param name="obj">Proveedor a registrar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>Id del proveedor registrado.</returns>
        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            return Obj_Proveedor.Registrar(obj, out Mensaje);
        }
        /// <summary>
        /// Edita un proveedor en la base de datos.
        /// </summary>
        /// <param name="obj">Proveedor a editar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la edición fue exitosa, false en caso contrario.</returns>
        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            return Obj_Proveedor.Editar(obj, out Mensaje);
        }
        /// <summary>
        /// Elimina un proveedor de la base de datos.
        /// </summary>
        /// <param name="obj">Proveedor a eliminar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la eliminación fue exitosa, false en caso contrario.</returns>
        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return Obj_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
