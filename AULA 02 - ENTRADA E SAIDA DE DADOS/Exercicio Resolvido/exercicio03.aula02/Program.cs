using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03.aula02
{
    class Program
    {
        static void Main(string[] args)

 /* 3) Receba dois valores, apresente na tela apenas o maior deles*/
        
        {
            while (true) {
                int v1, v2;
                Console.WriteLine("digite primeiro valor: ");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite Segundo valor: ");
                v2 = Convert.ToInt32(Console.ReadLine());

                if (v1 > v2)
                {
                    Console.WriteLine("o maior valor digitado foi: " + v1);
                }

                else if (v1 == v2)
                {
                    Console.WriteLine("primeiro valor igual primeiro...");
                }

                else

                    Console.WriteLine("o maior valor digitado foi: " + v2);
                    Console.ReadLine();
            }
        }
    }
}
