using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06.aula04
{
    class Program
    {
        static void Main(string[] args)
        {

            int ganho = 0;
            int perco = 0;
            int valorGanho = 0;
            int valorPerco = 0;

            double resFinal = valorGanho - valorPerco;

            while (ganho + perco <= 30)
            {
                if (ganho + perco == 30)
                {
                    Console.WriteLine("Acabou as jogadas");
                    Console.WriteLine("O resultado final foi: ");
                    Console.WriteLine("Qtd de vitorias " + ganho + ", valor ganhado foi " + valorGanho);
                    Console.WriteLine("Qtd de percas " + perco + ", valor ganhado foi " + valorPerco);
                    if (valorGanho > valorPerco)
                    {
                        Console.WriteLine("Voce ganhou.." + (valorGanho - valorPerco));
                    }
                    else
                    {
                        Console.WriteLine("Voce perdeu.." + (valorGanho - valorPerco));
                    }
                    break;
                }

                Random ran = new Random();
                int resultado = ran.Next(1, 7);


                Console.WriteLine("caiu o numero...0" + resultado);



                if (resultado >= 3)
                {
                    ganho++;
                    valorGanho = ganho * 10;
                }
                else
                {
                    perco++;
                    valorPerco = perco * 15;

                }

            }

        }
    }
}
