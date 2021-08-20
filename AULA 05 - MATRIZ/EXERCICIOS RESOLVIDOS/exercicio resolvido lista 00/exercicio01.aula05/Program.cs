using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.aula05
{
    class Program
    {
        static void Main(string[] args)

/*1) Leia uma matriz 4 x 4, conte e escreva quantos valores maiores que 10 ela possui. */

        {
            int[][] matriz = new int[4][]; // gera uma matriz com 4 linhas
            for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            {
                matriz[i] = new int[4]; // gera minhas colunas
            }
            for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            {
                for (int j = 0; j < matriz[i].Length; j++) // percorre todas as colunas da linha i
                {
                    Console.WriteLine("insira o elemento -> " + i + " " + j);
                    matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int contador = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] > 10)
                    {
                        contador++;
                    }
                    Console.Write(matriz[i][j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(contador);

        }
    }
}
