using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
            int n1, n2;

            Console.WriteLine("digite um numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 > n2)
                {
                    Console.WriteLine("esse valor e maior que o primeiro...");
                }

                else if (n1 < n2)
                {
                    Console.WriteLine("esse valor e menor que o primeiro...");
                }

                else if (n1 == n2)
                {
                    Console.WriteLine("esse valor e igual ao primeiro...");
                }

                else
                    Console.ReadLine();
            }
        }
    }
}
