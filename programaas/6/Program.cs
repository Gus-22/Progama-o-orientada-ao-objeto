using System;
using System.Text;
using System.Drawing;
using System.Globalization;
using course;



namespace course
{

    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dólar: ");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade de dólares que você vai comprar: ");
            double Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Reais = ConversorDeMoeda.ValorEmReais(Quantidade, Cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + Reais.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}