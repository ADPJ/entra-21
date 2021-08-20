using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09.aula05_comentada
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            int[][] matriz = new int[4][];

            for (int i = 0; i < matriz.Length; i++)

            {

                matriz[i] = new int[4];

            }

            //// preenche a natriz com numeros entre 1 e 20

            for (int i = 0; i < matriz.Length; i++)

            {

                for (int j = 0; j < matriz[i].Length; j++)

                {

                    matriz[i][j] = ran.Next(1, 21/*20 + 1*/);

                }

            }

            //// mostra a matriz original na tela

            for (int i = 0; i < matriz.Length; i++)

            {

                for (int j = 0; j < matriz[i].Length; j++)

                {

                    if (matriz[i][j] < 10)

                    {

                        Console.Write("0" + matriz[i][j] + " ");

                    }

                    else

                    {

                        Console.Write(matriz[i][j] + " ");

                    }

                }

                Console.WriteLine();

            }

            //// transforma a matriz

            for (int i = 0; i < matriz.Length; i++)

            {

                for (int j = 0; j < matriz[i].Length; j++)

                {

                    if (i < j)

                    {

                        matriz[i][j] = 0;

                    }

                }

            }

            //Console.WriteLine("-------------//-----------");

            //// mostra a matriz transformada na tela

            for (int i = 0; i < matriz.Length; i++)

            {

                for (int j = 0; j < matriz[i].Length; j++)

                {

                    if (matriz[i][j] < 10)

                    {

                        Console.Write("0" + matriz[i][j] + " ");

                    }

                    else

                    {

                        Console.Write(matriz[i][j] + " ");

                    }

                }

                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
