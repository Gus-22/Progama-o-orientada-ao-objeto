using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NumeroComplexo n1 = new NumeroComplexo(1);
            NumeroComplexo n2 = new NumeroComplexo(2, 3);
            NumeroComplexo n3 = new NumeroComplexo(2, 3);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.WriteLine("n1 e n2 " + (n1.Equals(n3) ? " são iguai s" : " diferentes"));
            Console.WriteLine("n2 e n3 " + (n2.Equals(n3) ? " são iguais " : " diferentes"));

            n1.Soma(n2);
            n2.Subtracao(n3);
            Console.WriteLine(n1);
            Console.WriteLine(n2);


            n1.Real = 20;
            Console.WriteLine(n1.Real);
            
            n2.Imaginario = 30;
            Console.WriteLine(n2.Imaginario);



        }
    }
}