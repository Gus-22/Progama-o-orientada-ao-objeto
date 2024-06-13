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
            // criar os objetos triangulos
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            //recede do usuario as medidas do triangulos x e salva nos atributos A, B e C de x
            Console.WriteLine("Digite o primeiro valor x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o segundo valor x:");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o terceiro valor x:");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //recede do usuario as medidas do triangulos y e salva nos atributos A, B e C de y
            Console.WriteLine("Digite o primeiro valor y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o segundo valor y:");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o terceiro valor y:");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calcula a area do triangulo x
            double areaX = x.Area();

            //calcula a area do triangulo y
            double areaY = y.Area();

            //imprime a area do triangulo x
            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}