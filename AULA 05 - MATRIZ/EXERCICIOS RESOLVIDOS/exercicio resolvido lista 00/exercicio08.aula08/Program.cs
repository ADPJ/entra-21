using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08.aula08
{
    class Program
    {
        static void Main(string[] args)

/*8) Leia uma matriz de 3 x 3 elementos. Calcule a soma dos elementos que estão abaixo da
diagonal principal. */

        {

            int[][] matriz = new int[3][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[3];

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.WriteLine("Insira o valor de " + i + " " + j);
                    matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int soma = matriz[1][0] + matriz[2][0] + matriz[2][1];
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
