using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Contribuintes
    {

        public string Nome { get; set; } 
        public double RendaAnual { get; set; } 
        public double saude { get; set; } 
        public double NumFuncionario { get; set; }
        public string tipo { get; set; }

        public double CalcularImposto()
        {
            if (tipo == "fisico")
            {
                if (RendaAnual < 20000)
                {
                    return RendaAnual * 0.15;
                }
                else
                {
                    return RendaAnual * 0.25 - (saude * 0.50);
                }
            }
            else if (tipo == "juridico")
            {

                if (NumFuncionario > 10)
                {
                    return RendaAnual * 0.14;
                }
                else
                {
                    return RendaAnual * 0.16;
                }
            }
            else
            {
                throw new InvalidOperationException("Tipo de contribuinte desconhecido.");
            }
        }
      

       

        




    }
}
