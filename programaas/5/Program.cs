using System;
using System.Text;
using System.Drawing;
using System.Globalization;
using Course;


namespace Course
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            produto produto1 = new produto();
            produto produto2 = new produto();


            Console.WriteLine("Digite os dados do produto 1: ");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();

            Console.Write("Código: ");
            produto1.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Valor: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto1.Quantidade = uint.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite os dados do produto 2: ");
            Console.Write("Nome: ");
            produto2.Nome = Console.ReadLine();

            Console.Write("Código: ");
            produto2.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Valor: ");
            produto2.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto2.Quantidade = uint.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine(produto1.ToString());
            Console.WriteLine(produto2.ToString());

            // Mostra se são iguais ou não
            Console.WriteLine(produto1.Equals(produto2) ? "Produtos são iguais" : "Produtos não são iguais");
        }
    }
}