using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Cpf
    {

        public static bool Validar(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                return false;
            int Verificador = _CalculaVerificador(cpf, 1);

            if (Verificador != _GetDigito(cpf, 9))
                return false;
            Verificador = _CalculaVerificador(cpf, 2);

            if(Verificador != _GetDigito(cpf, 10))
                return false;
            return true;
        }

        private static int _GetDigito(string cpf, int INdex)
        {
            return int.Parse(cpf[INdex].ToString());
        }

        private static int _CalculaVerificador(string cpf, int verificador)
        {
            int Soma = 0;
            int Div = 0;
            int Resto = 0;

            for (int i = 0; i < (8 + verificador); i++)
            {
                Soma += _GetDigito(cpf, i) * (9 + verificador - i);
            }
            Div = Soma / 11;
            Resto = Soma % 11;

            if (Div < 2)
                return 0;
            else
                return 11 - Resto;
        }

    }
}

  