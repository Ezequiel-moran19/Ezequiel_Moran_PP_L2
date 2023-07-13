using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria Obj_Categoria = new CD_Categoria();
        /// <summary>
        /// Obtiene una lista de categorías.
        /// </summary>
        /// <returns>Lista de categorías.</returns>
        public List<Categoria> Listar()
        {
            return Obj_Categoria.Listar();
        }
        /// <summary>
        /// Valida los datos de un objeto Categoria.
        /// </summary>
        /// <param name="obj">Objeto Categoria a validar.</param>
        /// <param name="Mensaje">Mensaje de validación.</param>
        /// <returns>True si los datos son válidos, false en caso contrario.</returns>
        public bool Validar(Categoria obj, ref string Mensaje)
        {
            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }
            return string.IsNullOrEmpty(Mensaje);
        }
        /// <summary>
        /// Registra una categoría en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Categoria a registrar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>El id de la categoría registrada.</returns>
        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return 0;
            }
            else
            {
                return Obj_Categoria.Registrar(obj, out Mensaje);
            }
        }
        /// <summary>
        /// Edita los datos de una categoría en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Categoria a editar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la edición se realizó correctamente, false en caso contrario.</returns>
        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (!Validar(obj, ref Mensaje))
            {
                return false;
            }
            else
            {
                return Obj_Categoria.Editar(obj, out Mensaje);
            }
        }
        /// <summary>
        /// Elimina una categoría de la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Categoria a eliminar.</param>
        /// <param name="Mensaje">Mensaje de salida.</param>
        /// <returns>True si la eliminación se realizó correctamente, false en caso contrario.</returns>
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return Obj_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}

