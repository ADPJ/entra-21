using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04.aula02
{
    class Program

   /*4) Receba três valores, apresente na tela apenas o maior deles*/

    {
        static void Main(string[] args)
        {
            while (true) {

            int v1, v2, v3;

            Console.WriteLine("digite o primeiro valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o terceiro valor: ");
            v3 = Convert.ToInt32(Console.ReadLine());

                if (v1 > v2 && v1 > v3)
                {
                    Console.WriteLine("o maior valor digitado foi: = " + v1);
                }

                else if (v2 > v1 && v2 > v3)
                {
                    Console.WriteLine("o maior valor digitado foi: = " + v2);
                }

                else if (v3 > v1 && v3 > v2)
                {
                    Console.WriteLine("o maior valor digitado foi: = " + v3);
                }

                else
                {
                    Console.ReadLine();
                }  

            }
        }
    }
}
