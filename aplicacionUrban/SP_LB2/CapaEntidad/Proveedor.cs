using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor : Persona
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string FechaRegistro { get; set; }
        public Proveedor()
        {}
        public Proveedor(int idProveedor)
        {
            IdProveedor = idProveedor;
        }
        public Proveedor(string razonSocial, string documento): base(documento)
        {
            RazonSocial = razonSocial;
        }
        public Proveedor(int idProveedor, string documento, string razonSocial, string correo,string telefono, eEstado estado)
            : base(documento, correo, estado)
        {
            IdProveedor = idProveedor;
            RazonSocial = razonSocial;
            Telefono = telefono;
        }

    }
}
