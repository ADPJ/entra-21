using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitando
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y  = 0;
            Console.WriteLine("qual tamanho da matriz deseja criar:" );
            Console.WriteLine("digite a quntidade linhas: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a quntidade colunas: ");
            y = Convert.ToInt32(Console.ReadLine());
            int[][] matriz = new int[x][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[y];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.WriteLine("digite os valores da matriz: " + i + " " + j);
                    matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j] + "  ");
                }
                Console.WriteLine();
            } 
            Console.ReadLine();
        }
    }
}
