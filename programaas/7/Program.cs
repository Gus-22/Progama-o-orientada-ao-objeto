using course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("gus", 10);

            conta.Deposito(10000);

            Console.WriteLine("Saldo: " + conta.Saldo.ToString("F2"));

        }
    }
}