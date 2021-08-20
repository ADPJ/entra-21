using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04.alula04
{
    class Program
    {
        static void Main(string[] args)
    
     //4) Crie um vetor que armazena 3 nomes vindo do usuario, o usuario pode, a qualquer momento, solicitar quais nomes estao armazenados.

        {
            while (true)
            {
                string[] nome = new string[3];
                int opcao;

                Console.WriteLine("digite tres nomes");
                Console.WriteLine("digite o primeiro nmome");
                nome[0] = Console.ReadLine();
                Console.WriteLine("digite o segundo nmome");
                nome[1] = Console.ReadLine();
                Console.WriteLine("digite o terceiro nmome");
                nome[2] = Console.ReadLine();

                Console.WriteLine("digite 1=mostrar na tela ou p/ 2=continuar digitando: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)

                {
                    case 1:

                        Console.WriteLine(nome[0] + nome[1] + nome[0]);
                        Console.ReadLine();
                        break;
                }
                
            }
                
        }
    }
}
