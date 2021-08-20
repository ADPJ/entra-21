using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercico03.aula08
{
    class Program
    {
        static void Main(string[] args)
/*3) Crie um programa que recebe três numeros (double) entre 0 e 10,
 * se por acaso o numero for grande de mais avise “Numero gigantesco”
 * caso tiver letras e afins, avise “Apenas numeros” e então, peça 
 * novamente até dar certo.
 * 
Após receber os tres numeros, mostre a média deles no console*/
        {
            double[] num = new double[10];
            double x, y = 0;
            Program prog = new Program();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("insira tres numeros");
                x = prog.CRD();
                
                try
                {
                    prog.CRD();
                    Console.WriteLine("Deu Certo!!!");
                    break;
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Numero gigantesco");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Apenas numeros");
                }

                catch (Exception)
                {
                    Console.WriteLine("*ERRO*");
                }
            }
                
        }
        public int Compara(int x, int y)
        {
            if (x > 0 && x < 10)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
