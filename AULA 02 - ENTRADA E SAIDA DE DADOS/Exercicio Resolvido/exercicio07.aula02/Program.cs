using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07.aula02
{

/*7) Receba um número, e informe se ele é par ou ímpar*/
    class Program

    {
        static void Main(string[] args)
        {
            while (true) {
            Console.WriteLine("informe o numero a ser consultado: ");
            int par;
            par = Convert.ToInt32(Console.ReadLine());

        if (par % 2 == 0)
            {
                Console.WriteLine( "o numeroinformado e PAR...");
            }

        else
            {
                Console.WriteLine( "o numeroinformado e IMPAR...");
            }

            }
        }
    }
}
