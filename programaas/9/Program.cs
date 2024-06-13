using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: (somente numeros ");
            string Entrada = Console.ReadLine();

            Console.WriteLine(Cpf.Validar(Entrada) ? "CPF Valido" : "CPF Invalido");
        }
    }
}
