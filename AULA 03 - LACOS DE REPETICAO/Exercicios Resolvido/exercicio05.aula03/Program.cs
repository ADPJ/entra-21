using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05.aula03
{
    class Program
    {
        static void Main(string[] args)
/*5) Gostaria de saber se o número que coloquei no sistema é maior que 24,
 *se for verdade, multiplique esse número por 2 e mostre na tela,
 *se for maior que 0 apenas apresente na tela, 
 *se for menor ou igual a 0 peça para inserir o número novamente,
 *use a palavra “exit” para parar o programa.*/
        {
            double numero;
            string entrada;
            while (true)
            {
            Console.WriteLine("insira um numero");
            Console.WriteLine("insira exit para sair");
            numero = Convert.ToDouble(Console.ReadLine());
            entrada = Console.ReadLine();
            if (entrada == "exit")
            {
            break;
            }
            numero = Convert.ToDouble(entrada);
            if (numero > 24)
            {
            Console.WriteLine(numero * 2);
            }
            else if (numero > 0)
            {
            Console.WriteLine(numero);
            }
            else
            {
            Console.WriteLine("insira novamente");
            }
            }

        }
    }
}
