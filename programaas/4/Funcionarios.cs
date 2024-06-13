using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couser
{
    internal class Funcionarios
    {

        public string Nome;
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

               

        public double SalarioLiquido()
        {
            return SalarioBruto - SalarioBruto * (Imposto / 100.0);

        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto *(porcentagem / 100.0);
            
        }

        public double SalarioFinal(double porcentagem)

        {

            return  (SalarioBruto - SalarioBruto * (Imposto / 100.0)) - (SalarioBruto + SalarioBruto * (porcentagem / 100.0));

        }
    }
}
