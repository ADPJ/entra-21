using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05.aula04
{
    class Program
    {
        static void Main(string[] args)

        //5) Crie um vetor que armazena 5 valor INTEIROS, peça ao usuario para ele colocar valores nessas 5 posições, depois, some todos os valor e mostre pro usuario...

        {

            int[] v = new int[5];
            Console.WriteLine("Digite 5 numero inteiros e descubra a soma");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("A soma dos numero digitados é");
            Console.WriteLine(v[0] + v[1] + v[2] + v[3] + v[4]);



        }
    }
}
