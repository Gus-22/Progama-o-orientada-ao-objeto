using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exe8
{
    internal class Triangulo
    {

        
        private double _side = 1.0;

        public Triangulo()
        {
        
        }

        public Triangulo(double side)
        {
            SetSide(side);

        }

        public void SetSide(double side)
        {
            if (side >= 0 && side <= 20)
            {
                _side = side;
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public double GetSide()
        {
            return _side;
        }

        public double Area()
        {
            return (Math.Sqrt(3)/4.0) * Math.Pow(_side, 2);
        }
        public double Perimeter()
        {
            return 3 * _side;
        }
    }
}
