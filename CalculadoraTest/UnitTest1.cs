

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Testes_Unitarios;

namespace CalculadoraTest
{
    [TestClass]
    public class UnitTest1
    {
        private const int A = 10;
        private const int B = 10;
        private const int C = 9;
        private const double D1 = 3;
        private const double D2 = 2;


        [TestMethod]
        // Nesta função o resultado esperado é uma exceção com uma mensagem de erro "ERRO"
        [ExpectedException(typeof(Exception), "Erro porque resultado é igual a zero!")] 
        public void TestMetodoSoma_IgualZero_ResultadoException()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.Soma(0, 0);
        }

        [TestMethod]
        [Timeout(50)] //Milliseconds - To set a timeout on an individual test method

        public void TestMetodoSoma()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.Soma(A, B);
            Assert.AreEqual(resultado, 20);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)] // Milliseconds - To set the timeout to the maximum allowed
        public void TestMetodoSubtrai()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.Subtrai(A, B);
            Assert.AreEqual(resultado, 0);
        }

        [TestMethod]
        public void TestMetodoDivide()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.Divide(A, B);
            Assert.AreEqual(resultado, 1);
        }

        [TestMethod]
        public void TestMetodoMultiplica()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.Multiplica(A, B);
            Assert.AreEqual(resultado, 100);
        }

        [TestMethod]
        public void RecebeInteiro_DevolveDouble_ResultadoCorreto()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.RaizQuadrada(C);
            Assert.AreEqual(resultado, 3);
        }

        [TestMethod]
        // Nesta função o resultado esperado é uma exceção com uma mensagem de erro "ERRO"
        [ExpectedException(typeof(Exception), "Erro porque resultado é igual a zero!")]
        public void TestMetodoSRaizQuadrada_IgualZero_ResultadoException()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.RaizQuadrada(0);
        }

        [TestMethod]
        public void InDouble_GiveTheResult_CrrectResult()
        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double resultado = calculadora.PowMethod(D1, D2);
            Assert.AreEqual(resultado, 27);
        }
    }
}
