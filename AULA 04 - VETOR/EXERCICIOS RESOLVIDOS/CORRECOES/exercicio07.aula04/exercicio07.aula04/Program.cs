using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07.aula04
{
    class Program
    {
        static void Main(string[] args)

        /* 7) Vamos criar um sistema simplificado de um estacionamento, para isso,
         * Crie 2 vetores de 10 posições(estes vetores representam o numero de vagar, 10 vagas),
         * um para a placa(possui letras e numeros) e outro para a hr de entrada, ao iniciar,
         * solicite ao usuario se o cliente esta entrando ou sainda para isso: 
         * Entrando: Primeiro confere se tem vagas disponíveis, se nao,
         * apenas avise que nao tem vagas e volte ao inicio, caso tenha, peça a placa e a hora de entrada,
         * então, armazene na primeira vaga livre Saindo: Peça a placa do carro,
         * se a placa nao for encontrada peça novamente,caso encontrou a placa,
         * calcule o valor a ser pago(custa R$ 3,50 a hora), após isso, zere a vaga que o cliente estava ocupando. */

        {
            string[] placa = new string[10];
            double[] hrE = new double[10];

            for (int i = 0; i < placa.Length; i++)
            {
                placa[i] = "";
            }

            while (true)
            {
                Console.WriteLine("O veículo esta entrando ou saindo?");
                Console.WriteLine("e - entrando | s - saindo");

                string escolha = Console.ReadLine();

                if (escolha == "e")
                {
                    bool cheio = true;
                    
                    for (int i = 0; i < placa.Length; i++)
                    {
                        if (placa[i] == "")
                        {
                            Console.WriteLine("Insira a placa do veiculo");
                            placa[i] = Console.ReadLine();
                            Console.WriteLine("Insira a hora de entrada");
                            hrE[i] = Convert.ToDouble(Console.ReadLine());
                            cheio = false;
                            break;
                        }
                    }
                    
                    if (cheio)
                    {
                        Console.WriteLine("esta cheio");
                    }
                }
                
                else if (escolha == "s")
                {
                    Console.WriteLine("Qual a placa?");
                    string saindo = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = 0; i < placa.Length; i++)
                    {
                        if (placa[i] == saindo)
                        {
                            placa[i] = "";
                            Console.WriteLine("Insira a hr de saida");
                            double hrSaida = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Valor Final: " + (hrSaida - hrE[i]) * 3.5);
                            encontrado = true;
                            break;
                        }
                    }
                
                    if (encontrado == false)
                    {
                        Console.WriteLine("Placa nao encontrada");
                    }
                }
                
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        }
    }
}
