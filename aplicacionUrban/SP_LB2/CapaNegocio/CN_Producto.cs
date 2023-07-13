using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto : ICapaNegocio<Producto>
    {
        private CD_Producto Obj_Producto = new CD_Producto();
        /// <summary>
        /// Obtiene una lista de proveedores desde la capa de datos.
        /// </summary>
        /// <returns>Lista de proveedores.</returns>
        public List<Producto> Listar()
        {
            return Obj_Producto.Listar();
        }
        /// <summary>
        /// Valida los datos de un proveedor.
        /// </summary>
        /// <param name="obj">Proveedor a validar.</param>
        /// <param name="Mensaje">Mensaje de error.</param>
        /// <returns>True si los datos son válidos, false en caso contrario.</returns>
        public bool Validar(Producto obj, ref string Mensaje)
        {

            if (string.IsNullOrEmpty(obj.Codigo))
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }
            if (string.IsNullOrEmpty(obj.Nombre))
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }
            if (string.IsNullOrEmpty(obj.Descripcion))
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        /// <summary>
        /// Registra un proveedor en la base de datos.
        /// </summary>
        /// <param name="obj">Proveedor a registrar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>Id del proveedor registrado.</returns>
        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            else
            {
                return Obj_Producto.Registrar(obj, out Mensaje);
            }
        }
        /// <summary>
        /// Edita un proveedor en la base de datos.
        /// </summary>
        /// <param name="obj">Proveedor a editar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la edición fue exitosa, false en caso contrario.</returns>
        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            else
            {
                return Obj_Producto.Editar(obj, out Mensaje);
            }
        }
        /// <summary>
        /// Elimina un proveedor de la base de datos.
        /// </summary>
        /// <param name="obj">Proveedor a eliminar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la eliminación fue exitosa, false en caso contrario.</returns>
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return Obj_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
