using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Utilidades
{
    public class OpcionesCombo
    {
        public string Texto { get; set; }
        public object Valor { get; set; }
        public OpcionesCombo()
        {
        }
        public OpcionesCombo(string texto, object valor)
        {
            Texto = texto;
            Valor = valor;
        }
    }
}
