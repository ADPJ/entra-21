using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 5;
            int[,] diagonal = new int[x,y];

            for (int i = 0; i < x; i++)
            {
            	for (int j = 0; j < y; j++)
            	{
                	if (i == j)
                	{
                    	diagonal[i, j] = 1;
                	}

                	else
                	{
                    	diagonal[i, j] = 0;
                	}
            	}
            }

            for (int i = 0; i < x; i++)
            {
            	for (int j = 0; j < y; j++)
            	{
                	Console.Write(diagonal[i, j] + " ");
            	}
            	Console.WriteLine();
            }


        }
    }
}
