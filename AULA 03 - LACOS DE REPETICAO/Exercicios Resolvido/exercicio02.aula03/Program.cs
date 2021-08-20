using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula03
{
    class Program
//2) Gostaria de saber todos os números pares entre 0 e 23, desenvolva um algoritmo que resolve meu problema
    {
        static void Main(string[] args)

        /*{
                for (int i = 0; i < 24; i++)
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                Console.ReadLine();
        }*/

      /*{
              for (int i = 0; i < 24; i++)
                  Console.WriteLine(i++);
                  Console.ReadLine();
        }*/

        {
            for (int i = 0; i < 24; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
