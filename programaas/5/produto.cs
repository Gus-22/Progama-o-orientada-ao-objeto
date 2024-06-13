using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class produto
    {
        public string Nome;
        public double Preco;
        public uint Quantidade;
        public int Codigo;

        public produto()
        {

        }

        public produto(string nome, double preco, uint quantidade, int codigo)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Codigo = codigo;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            String myString = "Nome: " + Nome +
                ", Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + 
                ", Quantidade: " + Quantidade + ", Código: " + Codigo + 
                ", Valor total em estoque: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            return myString;
            
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (obj is produto Prod2)
            {
                return Nome == Prod2.Nome && Codigo == Prod2.Codigo;

            }
            else
            {
                return false;
            }
        }



    }
}
