using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula04
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] notas = new double[3];
            for (int i = 0; i < notas.Length; i++)
            {
            	Console.WriteLine("Insira a " + (i+1) + "° nota");
            	notas[i] = Convert.ToDouble(Console.ReadLine());
            }
             
            double resultado = notas[0] + notas[1] + notas[2];
            resultado = resultado / 3;
            double media = 0;
            for(int i = 0; i < notas.Length; i++)
            {
            	media += notas[i];
            }
            media /= notas.Length;
            Console.WriteLine("A média é -> " + media + " <-");

            Console.ReadLine();



        }
    }
}
