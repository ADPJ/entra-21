using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07.aula04
{
    class Program

    /*7) Vamos criar um sistema simplificado de um estacionamento, para isso, Crie 2 vetores de 10 posições(estes vetores representam o numero de vagar, 10 vagas),
     *um para a placa(possui letras e numeros) e outro para a hr de entrada, ao iniciar, solicite ao usuario se o cliente esta entrando ou sainda para isso:
     *Entrando: Primeiro confere se tem vagas disponíveis, se nao, apenas avise que nao tem vagas e volte ao inicio, caso tenha, peça a placa e a hora de entrada,
     *então, armazene na primeira vaga livre Saindo: Peça a placa do carro, se a placa nao for encontrada peça novamente,
     *caso encontrou a placa, calcule o valor a ser pago(custa R$ 3,50 a hora), após isso, zere a vaga que o cliente estava ocupando. */

    {
        static void Main(string[] args)

        {

            int[] vagas = new int[10];
            int[] placa = new int[10];
            int[] hora = new int[10];
            int escolha;

            while (true)

            {

                Console.WriteLine("entrando ou saindo do estacionamento: 1=entrada ou 2=saida");
                escolha = Convert.ToInt32(Console.ReadLine());


                if (escolha == 1)

                {
               
                }

                else if (escolha == 2)

                {


                }
            
                else 
                    vagas == 9











            }

        }
    }
}
