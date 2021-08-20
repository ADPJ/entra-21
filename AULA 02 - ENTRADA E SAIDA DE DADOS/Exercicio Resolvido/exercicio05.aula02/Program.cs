using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05.aula02

{
    class Program
    {
        static void Main(string[] args)
  /* 5) Receba um número qualquer de entrada,
   * se for 1 apresente na tela “1”, se 2 apresente “2”,
   * se for 3 apresente “3” e 
   * se não for nenhuma das anteriores apresente 
   * “não computável” (use a função Switch)*/

        {
            while (true) {

            int escolha = 0;
            string resultado;

            Console.WriteLine("escolha os numeros: 1 | 2 | 3 a ser verificado: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    resultado = "numero escolhido foi: 1";
                    break;
                case 2:
                    resultado = "numero escolhido foi: 2";
                    break;
                case 3:
                    resultado = "numero escolhido foi: 3";
                    break;
                default:
                    resultado = "numero digitado nao esta disponivel";
                    break;
            }

            Console.WriteLine(resultado);
                        
            }
        }
    }
}
