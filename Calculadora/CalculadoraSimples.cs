//Calculadora Simples

using System;

namespace Testes_Unitarios
{

    public class CalculadoraSimples
    {
        public double Soma(double num1, double num2)
        {
            double res = num1 + num2;
            if (res == 0)
            {
                throw new Exception("ERRO");
            }
            else
            {
                return num1 + num2;
            }
        }
        public double Subtrai(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiplica(double num1, double num2)
        {
            return num1 * num2;
        }

        public double RaizQuadrada(int number)
        {
            if (number == 0 )
            {
                throw new Exception("ERRO");
            }
            else
            {
                return Math.Sqrt(number);
            }
        }
    }
}
