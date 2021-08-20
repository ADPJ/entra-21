using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03.aula04
{
    class Program
    {
        static void Main(string[] args)

        //3) Crie um vetor que armazena 3 valores vindo do usuario, depois, mostre apenas o maior dentre eles, se todos forem iguais, exiba uma mensagem dizendo “sao todos iguais”

        {
            //double[] notas = new double[3];
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine("Insira a " + (i+1) + "° nota");
            //    notas[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //// funciona perfeitamente
            ////double resultado = notas[0] + notas[1] + notas[2];
            ////resultado = resultado / 3;
            //double media = 0;
            //for(int i = 0; i < notas.Length; i++)
            //{
            //    media += notas[i];
            //}
            //media /= notas.Length;
            //Console.WriteLine("A média é -> " + media + " <-");

            //Console.WriteLine(___________________________________________________________);


            {
                int[] valor = new int[3];

                Console.WriteLine("digite primeiro valor: ");
                valor[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite Segundo valor: ");
                valor[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite terceiro valor: ");
                valor[2] = Convert.ToInt32(Console.ReadLine());

                if (valor[0] > valor[1] && valor[0] < valor[2])
                {
                    Console.WriteLine("o maior valor digitado foi: " + valor[0]);
                }

                else if (valor[1] > valor[0] && valor[1] < valor[2])

                {
                    Console.WriteLine("o maior valor digitado foi..." + valor[1]);
                }

                else if (valor[2] > valor[0] && valor[2] < valor[1])
                {
                    Console.WriteLine("o maior valor digitado foi: " + valor[2]);
                }

                else if (valor[0] == valor[1] && valor[0] == valor[2])
                {
                    Console.WriteLine("os numeros sao iguais: ");
                }

                Console.ReadLine();




            }

        }

    }

}