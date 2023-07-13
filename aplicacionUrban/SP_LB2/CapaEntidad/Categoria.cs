using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

        public Categoria() { }
        public Categoria(int idCategoria)
        {
            IdCategoria = idCategoria;
        }
        public Categoria(int idCategoria, string descripcion):this(idCategoria)
        {
            Descripcion = descripcion;
        }
        public Categoria(int idCategoria, string descripcion, bool estado) : this(idCategoria, descripcion)
        {
            Estado = estado;
        }

    }
}
