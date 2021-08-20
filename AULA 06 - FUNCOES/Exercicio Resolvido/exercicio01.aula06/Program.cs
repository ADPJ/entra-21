using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.aula06
{
    class Program
    {
        static void Main(string[] args)

//1) Escreva uma função que receba dois números inteiros retorne o menor número

        {
            Program prog = new Program();
            int entrada1, entrada2, resultado;
            Console.WriteLine("insira dois numeros");
            entrada1 = Convert.ToInt32(Console.ReadLine());
            entrada2 = Convert.ToInt32(Console.ReadLine());
            resultado = prog.compara(entrada1, entrada2);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        public int compara(int x, int y)
        {
            if (x > y)
            {
                return y;
            }

            else
            {
                return x;
            }
        }
    }
}