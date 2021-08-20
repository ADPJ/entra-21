using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08.aula04
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;

            Console.WriteLine("digite o valor do seu produto");
            x = Convert.ToDouble(Console.ReadLine());

            double porcetagem01 = x- x * 0.28;
            double porcentagem02 = x- x * 0.21;



            if (x >= 254.50)
            {

                Console.WriteLine("desconto de 28% . seu valor atual é " + porcetagem01);
            } else if (x < 254.50)
            {
                Console.WriteLine("desconto de 21% . seu valor atual é " + porcentagem02);
            }




        }
    }
}
