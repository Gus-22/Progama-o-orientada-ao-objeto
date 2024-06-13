using Exe1;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            // criar os objetos pessoa
            Pessoa pessoa1 = new Pessoa(); 
            Pessoa pessoa2 = new Pessoa(); 


            // pegar os dados da primeira pessoa e salvar no pessoa1, e da mesmoa forma pra pessoa2

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            // Mostrar qual das pessoas é a mais velha
            Console.WriteLine("Pessoa mais velha: " + (pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome));

        }
    }
}