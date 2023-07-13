using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPruebas
{
    [TestClass]
    public class CalidarClienteTest
    {
        [TestMethod]
        public void Validar_ClienteValorInvalido()
        {

            CN_Cliente cnCliente = new CN_Cliente();
            Cliente cliente = new Cliente
            {
                Documento = "",
                NombreCompleto = "",
                Correo = ""
            };
            string mensaje = "";

            bool resultado = cnCliente.Validar(cliente, ref mensaje);

            Assert.IsFalse(resultado);
            Assert.AreEqual("Es necesario el documento del Cliente\nEs necesario el nombre del Cliente\nEs necesario el correo del Cliente\n", mensaje);
        }
        [TestMethod]
        public void Validar_ClienteCorrecto()
        {
            CN_Cliente cnCliente = new CN_Cliente();
            Cliente cliente = new Cliente
            {
                Documento = "123456789",
                NombreCompleto = "John Snow",
                Correo = "johnSnow@example.com"
            };
            string mensaje = "";

            bool resultado = cnCliente.Validar(cliente, ref mensaje);

            Assert.IsTrue(resultado);
            Assert.AreEqual("", mensaje);
        }

    }
}
