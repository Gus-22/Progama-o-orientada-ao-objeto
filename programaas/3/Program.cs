//exercicios dos slides passado em aula 
// slide 4
// exercicio 3 ,5 e 6


using System;
using System.Text;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // criar os objetos pessoa modo antigo ao qual não funciona mais
            //Pessoa pessoa1 = new Pessoa();
            //Pessoa pessoa2 = new Pessoa();

            // criar os objetos pessoa modo novo
            Pessoa pessoa1 = new Pessoa("Gustavo", 23, 1.75);
            Pessoa pessoa2 = new Pessoa("GOI", 19 , 1.10);


            //no novo metodo isso se torna inutil pois ja temos os parametros passados

            // pegar os dados da primeira pessoa e salvar no pessoa1, e da mesmoa forma pra pessoa2
            /*Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());*/

            // Mostrar qual das pessoas é a mais velha
            Console.WriteLine("Pessoa mais velha: " + (pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome));
            Console.WriteLine("Pessoa mais Alta: " + (pessoa1.Altura > pessoa2.Altura ? pessoa1.Nome : pessoa2.Nome));
            Console.WriteLine("Este individuo de indole duvidosa é um anão cachaceiro: " + (pessoa1.Altura < 1.30 ? pessoa1.Nome : pessoa2.Nome));
        }
    }
}