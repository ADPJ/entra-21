using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06.aula03
{
    class Program
    {
        static void Main(string[] args)

        //7) Faça um programa que testa o lançamento de um dado de 6 faces 30 vezes,
        //para cada vez que o valor for maior ou igual a 3 eu ganho R$ 10,00 ,
        //se nao, eu perco R$ 15,00, no final, se o valor for positivo apresente na tela “você ganhou”
        //+ quanto ganhei, caso contrário, mostre “você perdeu” + quanto devo.        

        {
            while (true)

            {

                Random rnd = new Random();
                int numero = rnd.Next(1, 6);
                int jogadas, lucro, perda;
                jogadas = 0;
                perda = 0;
                lucro = 0;

                Console.WriteLine(numero);

                for (jogadas = Convert.ToInt32(Console.()); jogadas >= 30; jogadas++) ;

                switch (numero)

                {
                    case 1:
                        numero = 1;
                        perda = perda + 15;
                        Console.WriteLine("voce perdeu!" + perda);

                        break;

                    case 2:
                        numero = 2;
                        perda = perda + 15;
                        Console.WriteLine("voce perdeu!" + perda);
                        break;

                    case 3:
                        numero = 3;
                        Console.WriteLine("voce GANHOU!" + lucro);
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