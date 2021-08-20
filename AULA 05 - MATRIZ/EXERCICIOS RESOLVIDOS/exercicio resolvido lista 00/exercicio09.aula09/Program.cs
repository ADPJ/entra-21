using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09.aula09
{
    class Program
    {
        static void Main(string[] args)

/*9) Gere matriz 4 x 4 com valores no intervalo [1, 20]. Escreva um programa que
transforme a matriz gerada numa matriz triangular inferior, ou seja, atribuindo zero a todos
os elementos acima da diagonal principal. Imprima a matriz original e a matriz
transformada. */
        
        {
            int[][] matriz1 = new int[3][];
            int[][] matriz2 = new int[3][];

            for (int i = 0; i < matriz1.Length; i++)
            {
             matriz1[i] = new int[3];
             matriz2[i] = new int[3];
            }

            for (int i = 0; i < matriz1.Length; i++)
            {
             for (int j = 0; j < matriz1[i].Length; j++)
             {
             matriz1[i][j] = i + j + 3;
             }
            }

            for (int i = 0; i < matriz1.Length; i++)
            {
             for (int j = 0; j < matriz1[i].Length; j++)
             {
             matriz2[i][j] = matriz1[i][j];
             }
            }

            for (int i = 0; i < matriz1.Length; i++)
            {
             for (int j = 0; j < matriz1[i].Length; j++)
             {
             matriz1[i][j] = 0;
             }
            }

            for (int i = 0; i < matriz2.Length; i++)
            {
             for (int j = 0; j < matriz2[i].Length; j++)
             {
             Console.Write(matriz2[i][j]);
             }
             Console.WriteLine();
            }
        }
    }
}
