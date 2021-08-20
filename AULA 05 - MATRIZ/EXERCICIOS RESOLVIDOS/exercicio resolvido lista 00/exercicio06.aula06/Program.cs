using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06.aula06
{
    class Program
    {
        static void Main(string[] args)

        /*6)Gerar e imprimir uma matriz de tamanho 10 x 10, onde seus elementos sao da forma:
        A[i][j] = 2*i + 7*j − 2 se i<j;
        A[i][j] = 3 * i − 1 se i = j;
        A[i][j] = 4*i − 5*j + 1 se i > j; */

        {
            int[][] matriz = new int[10][];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[10];
            }

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {


                    if (i < j)
                    {
                        matriz[i][j] = 2 * i + 7 * j - 2;
                    }

                    if (i == j)
                    {

                        matriz[i][j] = 3 * i - 1;
                    }
                    if (i > j)
                    {

                        matriz[i][j] = 4 * i - 5 * j;
                    }


                    Console.WriteLine("resultado é " + matriz[i][j]);
                }

            }
            Console.ReadLine();
        }
    }
}