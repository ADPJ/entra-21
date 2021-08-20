using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03.aula05
{
    class Program
    {
        static void Main(string[] args)

/*3) Faça um programa que preenche uma matriz 4 x 4 com o produto do valor da linha e da
coluna de cada elemento.Em seguida, imprima na tela a matriz.*/

        {
            int[][] matriz = new int[4][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[4];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i * j;
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }

            ////extra , copiando matriz
            //int[][] matriz = new int[4][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //	matriz[i] = new int[4];
            //}
            //int[][] matrizCopia = matriz;
            //int[][] matrizCopia2 = new int[1][];
            // ...
            //matrizCopia2 = matriz;

        }
    }
}
