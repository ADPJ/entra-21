using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorDeInteirosParaReceberDoUsuario = new int[2];
            Console.WriteLine("Insira 2 numeros que te digo qual o maior");
                vetorDeInteirosParaReceberDoUsuario[0] = int.Parse(Console.ReadLine());
                vetorDeInteirosParaReceberDoUsuario[1] = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < vetorDeInteirosParaReceberDoUsuario.Length; i++)
            
            {
                vetorDeInteirosParaReceberDoUsuario[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (vetorDeInteirosParaReceberDoUsuario[0] > vetorDeInteirosParaReceberDoUsuario[1])
            {
                Console.WriteLine(vetorDeInteirosParaReceberDoUsuario[0]);
            }
            else
            {
            	Console.WriteLine(vetorDeInteirosParaReceberDoUsuario[1]); 
            }

                Console.ReadLine();

        }
    }
}
