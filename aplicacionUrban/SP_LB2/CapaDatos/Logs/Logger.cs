using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Logs
{
    public class Logger
    {

        private string logFilePath = "C:\\Users\\moran\\Documents\\Logs\\Logs.txt";

        /// <summary>
        /// Registra un mensaje en el archivo de registro.
        /// </summary>
        /// <param name="message">Mensaje a registrar.</param>
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - {message}");
            }
        }
        /// <summary>
        /// Registra un mensaje de inicio de sesión en el archivo de registro.
        /// </summary>
        /// <param name="usuario">Usuario que inició sesión.</param>
        public void LogInicioSesion(string usuario)
        {
            string message = $"Inicio de sesión: {usuario}";
            Log(message);
        }
        /// <summary>
        /// Registra un mensaje de cierre de sesión en el archivo de registro.
        /// </summary>
        /// <param name="usuario">Usuario que cerró sesión.</param>
        public void LogCierreSesion(string usuario)
        {
            string message = $"Cierre de sesión: {usuario}";
            Log(message);
        }
    }
}
