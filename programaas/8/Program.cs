using Exe8;
using System;
using System.Collections;
using System.Globalization;

namespace Course {     
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();  

            Console.WriteLine(t.GetSide()); 

            Console.WriteLine("--------------------");

            Console.Write("Digite o valor do lado do triângulo: ");
            double side = double.Parse(Console.ReadLine());

            t.SetSide(side);
            Console.WriteLine(t.GetSide());

            Console.WriteLine("Area:" + t.Area());
            Console.WriteLine("Perimeter:" + t.Perimeter());

            Console.WriteLine("--------------------");


            Triangulo t2 = new Triangulo(side);
            Console.WriteLine(t2.GetSide());    
        }
    }
}