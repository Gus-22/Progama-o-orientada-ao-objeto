using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class NumeroComplexo
    {

        public double Real { get; set; }
        public double Imaginario { get; set; }

        public NumeroComplexo(double real)
        {
            Real = real;
            Imaginario = 0.0;
        }

        public NumeroComplexo(double imaginario, Double real)  : this(real)
        {
            Imaginario = imaginario;
        }

        public void Soma(NumeroComplexo numero)
        {
            Real += numero.Real;
            Imaginario += numero.Imaginario;
        }

        public void Subtracao(NumeroComplexo numero)
        {
            Real -= numero.Real;
            Imaginario -= numero.Imaginario;
        }

        public override bool Equals(object? obj)
        {
            return obj is NumeroComplexo complexo &&
                   Real == complexo.Real &&
                   Imaginario == complexo.Imaginario;
        }

        public override string ToString()
        {
            return "(" + Real + " , " + Imaginario + "i";
        }



    }







}
