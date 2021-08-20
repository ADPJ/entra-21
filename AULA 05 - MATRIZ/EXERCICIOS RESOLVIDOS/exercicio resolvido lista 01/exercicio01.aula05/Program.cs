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

/*1) Faça um programa que permita ao usuario entrar com uma matriz de 3 x 3 números
inteiros.Em seguida, gere um array unidimensional pela soma dos numeros de cada coluna
da matriz e mostrar na tela esse array.Por exemplo, a matriz:
5 -8 10
1 2 15
25 10 7
Vai gerar um vetor, onde cada posição e a soma das colunas da matriz. A primeira posição
será 5 + 1 + 25, e assim por diante(neste exemplo, este seria o vetor resultante 31 4 3)*/

        {
            int[][] matriz = new int[3][];

            int[] resultado = new int[3];

            for (int i = 0; i < matriz.Length; i++)

            {

             matriz[i] = new int[3];

             resultado[i] = 0;

            }

            //// preenche a matriz

            for (int i = 0; i < matriz.Length; i++)

            {

             for (int j = 0; j < matriz[i].Length; j++)

             {

             matriz[i][j] = Convert.ToInt32(Console.ReadLine());

             }

            }

            //// preenche o vetor

            for (int i = 0; i < matriz.Length; i++)// coluna

            {

             for (int j = 0; j < matriz[i].Length; j ++)// linha

             {

            // // NOTA: o indice na matriz esta "invertido"

             resultado[i] += matriz[j][i];

             }

            }

            ////mostra a matriz na tela

            for (int i = 0; i < matriz.Length; i++)

            {

             for (int j = 0; j < matriz[i].Length; j++)

             {

             Console.Write(matriz[i][j] + " ");

             }

             Console.WriteLine();

            }

            //// mostra o resultado do vetor

            for (int i = 0; i < resultado.Length; i++)

            {
             Console.WriteLine(resultado[i]);

            }


        }
    }
}
