using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03.aula06
{
    class Program
    {
        static void Main(string[] args)

/*3) Faça uma função que recebe um valor inteiro e verifica se o valor é positivo, negativo ou zero.
 * A função deve retornar 1 para valores positivos, -1 para negativos e 0 para o valor 0. */

        {
            Program prog = new Program();
            int entrada1;
            string resultado;

            Console.WriteLine("-----------\\--------------");
            Console.WriteLine("insira um valor ");
            entrada1 = Convert.ToInt32(Console.ReadLine());
            resultado = prog.positivoounegativo(entrada1);
            Console.WriteLine(resultado);
            Console.ReadLine();

        }

        public string positivoounegativo(int entrada)

        {
            if (entrada > 0)
            {
                return "é positivo";
            }

            else if (entrada < 0)
            {
                return "negativo";
            }

            else
            {
                return "é igual a zero ";
            }
        }
    }
}
