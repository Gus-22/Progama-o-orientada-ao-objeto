using ex_prova;
using System;
using System.Collections.Generic;

public class program
{
    public static void Main()
    {

        List<Contribuintes> contribuintes = new List<Contribuintes>();

        Console.Write("Digite o número de contribuintes: ");
        int numeroDeContribuintes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroDeContribuintes; i++)
        {
            Contribuintes contribuinte = new Contribuintes();

            Console.Write("Digite o tipo de contribuinte (fisico/juridic0): ");
            contribuinte.tipo = Console.ReadLine().ToLower();

            Console.Write("Digite o nome: ");
            contribuinte.Nome = Console.ReadLine();

            Console.Write("Digite a renda anual: ");
            contribuinte.RendaAnual = double.Parse(Console.ReadLine());

            if (contribuinte.tipo == "fisico")
            {
                Console.Write("Digite os gastos com saúde: ");
                contribuinte.saude = double.Parse(Console.ReadLine());
            }
            else if (contribuinte.tipo == "juridico")
            {
                Console.Write("Digite o número de funcionários: ");
                contribuinte.NumFuncionario = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Tipo inválido. Por favor, digite 'fisico' ou 'juridico'.");
                i--; // para repetir esta iteração
                continue;
            }

            contribuintes.Add(contribuinte);
        }

        double totalImposto = 0;

        foreach (var contribuinte in contribuintes)
        {
            double imposto = contribuinte.CalcularImposto();
            Console.WriteLine($"{(contribuinte.tipo == "fisica" ? "Pessoa Física" : "Pessoa Jurídica")}: {contribuinte.Nome}, Imposto: {imposto:F2}");
            totalImposto += imposto;
        }

        Console.WriteLine($"Total de imposto arrecadado: {totalImposto:F2}");




    }
}