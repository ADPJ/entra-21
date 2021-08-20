using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05.aula05
{
    class Program
    
    {
        static void Main(string[] args)

        //5) Leia duas matrizes 4 x 4 e escreva uma terceira com os maiores valores de cada posição das matrizes lidas.

        {
            Random ran = new Random();
            int[][] matriz01 = new int[4][];
            int[][] matriz02 = new int[4][];
            int[][] resultado = new int[4][];
            for (int i = 0; i < matriz01.Length; i++)
            {
                matriz01[i] = new int[4];
                matriz02[i] = new int[4];
                resultado[i] = new int[4];
            }
            for (int i = 0; i < matriz01.Length; i++)
            {
                for (int j = 0; j < matriz01[i].Length; j++)
                {
                    matriz01[i][j] = ran.Next(0, 10);
                    Console.Write(matriz01[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------//------------");
            for (int i = 0; i < matriz02.Length; i++)
            {
                for (int j = 0; j < matriz02[i].Length; j++)
                {
                    matriz02[i][j] = ran.Next(0, 10);
                    Console.Write(matriz02[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------//------------");
            for (int i = 0; i < resultado.Length; i++)
            {
                for (int j = 0; j < resultado[i].Length; j++)
                {
                    if (matriz01[i][j] > matriz02[i][j])
                    {
                        resultado[i][j] = matriz01[i][j];
                    }
                    else
                    {
                        resultado[i][j] = matriz02[i][j];
                    }
                    Console.Write(resultado[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
