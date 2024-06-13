using Exe10;
using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Invoice inv1 = new Invoice(1234, "Monitor", 2, 1000);

            
            Console.WriteLine(inv1.ToString());

            
            Invoice inv2 = new Invoice(4567, "Mouse", 2, 10);
            Console.WriteLine(inv2.ToString());

          
        }
    }
}