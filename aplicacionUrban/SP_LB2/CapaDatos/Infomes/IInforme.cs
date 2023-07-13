using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Infomes
{
    public interface IInforme
    {
        string DirectorioInforme { get; }
        void GenerarInforme(DataTable data, string rutaArchivo);
    }
}
