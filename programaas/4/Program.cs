/*
 Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
Em  seguida, mostrar os dados do funcionário (nome e salário líquido). 
Em seguida, aumentar o  salário do funcionário com base em uma porcentagem
dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente
os dados do funcionário.
 */
using System;
using System.Text;
using System.Drawing;
using System.Globalization;
using Couser;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario = new Funcionarios();

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("O salario do funcionairo : " + funcionario.Nome + " é, R$ " + funcionario.SalarioLiquido().ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + funcionario.Nome + ", R$ " + funcionario.SalarioLiquido().ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("O salario final do funcionario pos aumento é: R$ " + funcionario.SalarioFinal(porcentagem).ToString("F1", CultureInfo.InvariantCulture));
            

            
                
        }
    }
}
