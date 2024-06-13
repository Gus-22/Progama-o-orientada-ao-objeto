using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Pessoa
    {
        // definir os atributos Nome e Idade
        public string Nome;
        public int Idade;
        public double Altura;

        // definir o construtor
        // adiciona o atributo Altura
        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }   



    }
}
