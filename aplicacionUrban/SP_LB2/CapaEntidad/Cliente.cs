using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string FechaRegistro { get; set; }

        public Cliente()
        {
        }
        public Cliente(int idCliente) : this()
        {
            IdCliente = idCliente;
        }
        public Cliente(int idCliente, string documento, string nombreCompleto, string correo, string telefono, eEstado estado)
            : base(documento, correo, estado)
        {
            IdCliente = idCliente;
            NombreCompleto = nombreCompleto;
            Telefono = telefono;
        }
    }
}
