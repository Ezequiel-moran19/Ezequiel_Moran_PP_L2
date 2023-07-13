using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface IMIInterfaz<T>
    {
        List<T> Listar();
        int Registrar(T obj, out string Mensaje);
        bool Editar(T obj, out string Mensaje);
        bool Eliminar(T obj, out string Mensaje);
        string MostrarConsultas();
    }
}
