using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03.aula03
{
    class Program
    {
        static void Main(string[] args)
        //3) Após receber um número do usuario, apresntar em ordem decrescente até 0:

        /*int valor;
               Console.WriteLine("insira um numero");
               valor = Convert.ToInt32(Console.ReadLine());
               while (valor > 0)
               {
                   valor--; //valor = valor - 1;
                   Console.WriteLine(valor);
                   Console.ReadLine(); 
               }*/

        /*----------------------------------------------------*/

        { 
                   Console.WriteLine("insira um numero: ");
                   for (int i = Convert.ToInt32(Console.ReadLine()); i >= 0; i--)
                   Console.WriteLine(i);
                   Console.ReadLine();
        }
    }
}
