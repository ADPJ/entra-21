using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08.aula03
{
    class Program
    {
        static void Main(string[] args)

//8)Um supermercado resolveu inserir desconto baseado em produto e quantidade no carrinho/sexta ,
//caso a compra tenha mais de 7 produtos tem 10% de desconto no valor final, além disso,
//caso tenho mais de 3 queijos na compra aplica-se 10% no valor total do queijo,
//o mesmo se aplica para o macarrão. Produtos a estarem na memória para poder fazer a compra depois,
//queijo(R$ 4,50), macarrão(R$ 5,00), feijão(R$ 4,00) , presunto(R$ 5,50), pão(R$ 3,75) após a compra,
//mostrar o valor final a ser pago.
                  
        {

            int queijo = 0, macarrao = 0, feijao = 0,
            presunto = 0, pao = 0, carrinho = 0;

            Console.WriteLine("Bem vindo ao supermercado Joeslei :");
            Console.WriteLine("onde os preços são os heróis");
            while (true)
            {
                Console.WriteLine("Escolha um dos produtos para colocar em seu carrinho");
                Console.WriteLine("1 - Queijo 200g Frimesa");
                Console.WriteLine("2 - Macarrao 500g KiMassa");
                Console.WriteLine("3 - Feijao 1Kg Tio João");
                Console.WriteLine("4 - Presunto 200g Presuntop");
                Console.WriteLine("5 - Pão Brasileiro Un.");
                Console.WriteLine("acabou ou fim para encerrar a compra");
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Quantos queijos você deseja?");
                        queijo = queijo + Convert.ToInt32(Console.ReadLine());
                        Console.Clear(); // limpar o console/tela
                        break;
                    case "2":
                        Console.WriteLine("Quantos macarrões você deseja?");
                        macarrao = macarrao + Convert.ToInt32(Console.ReadLine());
                        Console.Clear(); // limpar o console/tela
                        break;
                    case "3":
                        Console.WriteLine("Quantos Kg de feijão você deseja?");
                        feijao = feijao + Convert.ToInt32(Console.ReadLine());
                        Console.Clear(); // limpar o console/tela
                        break;
                    case "4":
                        Console.WriteLine("Quantos presuntos você deseja?");
                        presunto = presunto + Convert.ToInt32(Console.ReadLine());
                        Console.Clear(); // limpar o console/tela
                        break;
                    case "5":
                        Console.WriteLine("Quantos pães você deseja?");
                        pao = pao + Convert.ToInt32(Console.ReadLine());
                        Console.Clear(); // limpar o console/tela
                        break;
                    case "acabou":
                    case "fim":
                        Console.WriteLine("Obrigado por comprar na loja");
                        Console.WriteLine("mais heróica do Brasil");
                        break;
                    default:
                        Console.Clear(); // limpar o console/tela
                        Console.WriteLine("           !!!OPÇÃO INVÁLIDA!!!");
                        break;
                }
                if (escolha == "acabou" || escolha == "fim")
                {
                    break;
                }
            }
            double valorTotal = 0;
            if (queijo > 3)
            {
                valorTotal += (queijo * 4.5) * 0.9;
            }
            else
            {
                valorTotal += queijo * 4.5;
            }
            if (macarrao > 3)
            {
                valorTotal += (macarrao * 5) - (macarrao * 5) * 0.1;
            }
            else
            {
                valorTotal += (macarrao * 5);
            }
            valorTotal += feijao * 4;
            valorTotal += presunto * 5.5;
            valorTotal += pao * 3.75;
            carrinho = queijo + macarrao + feijao + presunto + pao;
            if (carrinho > 7)
            {
                valorTotal *= 0.9; //valorTotal = valorTotal * 0.9;
            }
            Console.WriteLine("O preco total é :");
            Console.WriteLine("{0:c}",valorTotal);



        }

    }

}
    

