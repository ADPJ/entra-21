using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04.aula05
{
    class Program
    {
        static void Main(string[] args)

//4 )Leia uma matriz 5 x 5. Leia também um valor X.O programa devera fazer uma busca ´ desse valor na matriz e,
//ao final, escrever a localizac¸ao(linha e coluna) ou uma mensagem de “nao encontrado”.

            
        {
            int[][] matriz = new int[2][];
            int a;
            bool procura = false;

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[2];
            }

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.WriteLine("insira um valor" + i + " " + j);
                    matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            while (true)
            {
                Console.WriteLine("insira o valor a ser procurado.");
                a = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < matriz.Length; i++)
                {
                    for (int j = 0; j < matriz[i].Length; j++)
                    {
                        if (matriz[i][j] == a)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("Parabens...");
                            Console.WriteLine("o valor a ser procurado foi encontrado: ");
                            Console.WriteLine("sua posição é" + i + " " + j);
                            procura = true;
                            break;
                        }
                    }
                }

                if (procura == false)
                {
                    Console.WriteLine(" o valor nao foi encontrado");
                }

            }





        }
    }
}
