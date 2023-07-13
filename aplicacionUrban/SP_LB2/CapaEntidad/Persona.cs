using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        public string Documento { get; set; }
        public string Correo { get; set; }
       // public bool Estado { get; set; }
        public eEstado Estado { get; set; }

        public Persona()
        {  }
        public Persona(string documento, string correo, eEstado estado)
        {
            Documento = documento;
            Correo = correo;
            Estado = estado;
        }

        public Persona(string documento)
        {
            Documento = documento;
        }
    }
}
