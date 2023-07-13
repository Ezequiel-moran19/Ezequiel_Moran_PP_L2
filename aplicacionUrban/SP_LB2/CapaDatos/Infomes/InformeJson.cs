using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos.Infomes
{
    public class InformeJson : IInforme
    {
        public string DirectorioInforme => "C:\\Users\\moran\\Documents\\Informes";
        /// <summary>
        /// Genera un informe en formato JSON a partir de un DataTable y lo guarda en el archivo especificado.
        /// </summary>
        /// <param name="dt">DataTable con los datos para el informe.</param>
        /// <param name="rutaArchivo">Ruta del archivo donde se guardará el informe.</param>
        public void GenerarInforme(DataTable dt, string rutaArchivo)
        {
            List<Dictionary<string, object>> listaFilas = ConvertDataTableToList(dt);

            string json = SerializeToJson(listaFilas);

            string rutaArchivoCompleta = Path.Combine(DirectorioInforme, rutaArchivo);
            WriteJsonToFile(json, rutaArchivoCompleta);
        }

        private static List<Dictionary<string, object>> ConvertDataTableToList(DataTable dt)
        {
            List<Dictionary<string, object>> listaFilas = new List<Dictionary<string, object>>();

            foreach (DataRow fila in dt.Rows)
            {
                Dictionary<string, object> diccionario = new Dictionary<string, object>();

                foreach (DataColumn columna in dt.Columns)
                {
                    diccionario[columna.ColumnName] = Convert.ChangeType(fila[columna], columna.DataType);
                }

                listaFilas.Add(diccionario);
            }

            return listaFilas;
        }

        private static string SerializeToJson(List<Dictionary<string, object>> listaFilas)
        {
            return JsonConvert.SerializeObject(listaFilas, Newtonsoft.Json.Formatting.Indented);
        }
       
        private static void WriteJsonToFile(string json, string rutaArchivo)
        {
            File.WriteAllText(rutaArchivo, json);
        }
    }
}
