using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula08
{
    class Program
    {
        static void Main(string[] args)
        /*2) Crie um programa que recebe um numero(int) qualquer,
         * se por acaso o numero for grande de mais avise “Numero gigantesco”
         * caso tiver letras e afins, avise “Apenas nu-meros”
         * e então, peça novamente até dar certo, quando der certo, avise “Deu certo”*/
        {

            int a = 0;
            //// apenas para ficar repetindo
            while (true)
            {
                Console.WriteLine("Insira um numero");
                // testa para uma possivel exceção, caso aconteça,
                // arremesa para frente
                try
                {
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Deu Certo!!!");
                    break;
                }
                // testa para numeros grandes
                catch (OverflowException)
                {
                    Console.WriteLine("Numero gigantesco");
                }
                // testa para qualquer coisa diferente de numero
                catch (FormatException)
                {
                    Console.WriteLine("Apenas numeros");
                }
                // Qualquer Exceção
                catch (Exception)
                {
                    Console.WriteLine("*ERRO*");
                }
            }


        }
    }
}
