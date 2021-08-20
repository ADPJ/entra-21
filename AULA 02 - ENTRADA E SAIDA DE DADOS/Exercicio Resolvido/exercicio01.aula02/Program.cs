using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIO01.AULA02
{
    class Program
    {
        static void Main(string[] args)

        
        {
            while (true) { 

            int n_certo;

            Console.WriteLine("digite um numero maior que o valor 10: ");
            n_certo = Convert.ToInt32(Console.ReadLine());

                if (n_certo > 10)

                {
                    Console.WriteLine(n_certo + " e maior que 10...");
                }

                else if (n_certo == 10)

                {
                    Console.WriteLine(n_certo + " e igual a 10...");
                }

                else if (n_certo <= 10)

                {
                    Console.WriteLine(n_certo + " esse valor nao e maior que 10...");
                }
                
                else
                    
                    n_certo = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
