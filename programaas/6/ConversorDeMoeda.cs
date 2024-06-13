using System;
using System.Collections;
using System.Globalization;

namespace course
{
    internal class ConversorDeMoeda
    {

        public double Dolar;
        public double Cotacao;
        public static double IOF = 0.06;

        public static double ValorEmReais(double quantidade , double cotacao)
        {
            return (quantidade *cotacao)*(1.0 + IOF);
        }
    }
}
