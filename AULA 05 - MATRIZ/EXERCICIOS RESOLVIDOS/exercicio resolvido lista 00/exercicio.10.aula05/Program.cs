using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio._10.aula05
{
    class Program
    {
        static void Main(string[] args)

        /*   DESAFIO:
        10) Faça um programa para gerar automaticamente numeros entre 0 e 99 de uma cartela de
        bingo. Sabendo que cada cartela devera conter 5 linhas de 5 números, gere estes dados de
        modo a nao ter números repetidos dentro das cartelas. O programa deve exibir na tela a
        cartela gerada. */

        {
            Random ran = new Random();
            int[,] matriz = new int[5, 5];

            //// preenche a matriz

            //// 0 = linhas | 1 = colunas

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = ran.Next(0, 25);

                    // // faz a busca por elementos repetidos

                    for (int k = 0; k < matriz.GetLength(0); k++)
                    {
                        for (int l = 0; l < matriz.GetLength(1); l++)
                        {
                            if (matriz[i, j] == matriz[k, l] && (i != k || j != l))
                            {
                                Console.WriteLine("Achou " + k + l);
                                k = matriz.GetLength(0);
                                j--;
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < 10)
                    {
                        Console.Write("0" + matriz[i, j] + " ");
                    }

                    else
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
