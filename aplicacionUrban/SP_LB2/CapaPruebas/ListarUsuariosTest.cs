using CapaDatos;
using CapaDatos.Infomes;
using CapaEntidad;
using CapaNegocio;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace CapaPruebas
{
    [TestClass]
    public class ListarUsuariosTest
    {
        [TestMethod]
        public void TestListar()
        {
            CD_Usuario cdUsuario = new CD_Usuario();

            List<Usuario> resultado = cdUsuario.Listar();

            Assert.IsNotNull(resultado);
            Assert.AreEqual(4, resultado.Count);
        }
        [TestMethod]
        public void ConversionImplicitaAInt_DevuelveIdUsuario()
        {
            int idUsuarioEsperado = 123;
            Usuario usuario = new Usuario(idUsuarioEsperado);

            int idUsuarioActual = usuario; 

            Assert.AreEqual(idUsuarioEsperado, idUsuarioActual);
        }
    }
}
