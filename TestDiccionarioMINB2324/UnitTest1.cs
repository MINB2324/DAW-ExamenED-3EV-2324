using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen3EV;

namespace TestDiccionarioMINB2324
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaCadenaIncorrecta()
        {
            string frase = "";
            string frase2 = "";
            Diccionario diccionario = new Diccionario();
            try
            {
                diccionario.Analizar(frase, frase2);
            }
            catch (Exception error)
            {
                StringAssert.Contains(error.Message, diccionario.ERROR_CADENA_NO_VALIDA);
                 return;
            }
            Assert.Fail("Se debería haber producido una excepción");
        }
    }
}
