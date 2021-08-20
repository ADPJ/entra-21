using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula06
{
    class Program
    {
        static void Main(string[] args)

/*2) Faça uma função que recebe um valor inteiro e verifica se o valor é par.
 * A função deve retornar 1 se o número for par e 0 se for ímpar. */
        {
            {
                Program prog = new Program();

                Console.WriteLine("Insira um numero");

                int x = prog.CRI();

                x = prog.ParOuImpar(x);

                Console.WriteLine(x);
                prog.CR();
            }
        }
        public string CR()
        {
            return Console.ReadLine();
        }
        public int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public int ParOuImpar(int entrada)

        {

         if (entrada % 2 == 0)
         {
         return 1;
         }

         else

         {
         return 0;
         }
         
        
         
        }
    }
}

