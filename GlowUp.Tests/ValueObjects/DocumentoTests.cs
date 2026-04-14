using GlowUp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlowUp.Tests.ValueObjetcs
{
    [TestClass]
    public class DocumentoTests
    {
        //Red, Green, Refactor

        [TestMethod]
        public void DeveRetornarErroQuandoCPFInvalido()
        {
            var documento = new Documento("123.456.789-12");
            
            Assert.IsTrue(!documento.IsValid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoCPFValido()
        {
            var documento = new Documento("806.611.700-04");
            Assert.IsTrue(documento.IsValid);
        }
    }
}
