using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06.aula02
{
    class Program

    {
        static void Main(string[] args)
/*6) Simule o lançamento de um dado de seis faces (use a função Random)
* se o resultado for maior ou igual a 3 , mostre na tela “você venceu”,
* caso contrário, você perdeu*/
        {
            while (true)
            {
                Random rnd = new Random();
                int numero = rnd.Next(1, 6);
                Console.WriteLine(numero);

                switch (numero)

                {
                    case 1:
                        numero = 1;
                        Console.WriteLine("voce perdeu!");
                        break;

                    case 2:
                        numero = 2;
                        Console.WriteLine("voce perdeu!");
                        break;

                    case 3:
                        numero = 3;
                        Console.WriteLine("voce perdeu!");
                        break;

                    default:
                        Console.WriteLine("voce Ganhou!");
                        break;
                }

                Console.ReadLine();

            }
        }
    }
}
