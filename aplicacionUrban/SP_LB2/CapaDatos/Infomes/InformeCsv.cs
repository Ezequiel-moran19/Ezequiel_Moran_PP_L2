using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Infomes
{
    public class InformeCsv : IInforme
    {
        public string DirectorioInforme => "C:\\Users\\moran\\Documents\\Informes";
        /// <summary>
        /// Genera un informe en formato CSV a partir de un DataTable y lo guarda en el archivo especificado.
        /// </summary>
        /// <param name="dt">DataTable con los datos para el informe.</param>
        /// <param name="rutaArchivo">Ruta del archivo donde se guardará el informe.</param>
        public void GenerarInforme(DataTable dt, string rutaArchivo)
        {
            string rutaArchivoCompleta = Path.Combine(DirectorioInforme, rutaArchivo);

            using (StreamWriter sw = new StreamWriter(rutaArchivoCompleta))
            {
                EscribirEncabezados(dt, sw);
                EscribirFilas(dt, sw);
            }
        }

        public void EscribirEncabezados(DataTable dt, StreamWriter sw)
        {
            foreach (DataColumn columna in dt.Columns)
            {
                sw.Write($"\"{columna.ColumnName}\",");
            }
            sw.WriteLine();
        }

        public void EscribirFilas(DataTable dt, StreamWriter sw)
        {
            foreach (DataRow fila in dt.Rows)
            {
                foreach (var item in fila.ItemArray)
                {
                    sw.Write($"\"{item}\",");
                }
                sw.WriteLine();
            }
        }
    }
}
