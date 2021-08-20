using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    //double valorDaCompra;
    //string cartao, quinta;
    //Console.WriteLine("Insira o valor da compra");
    //valorDaCompra = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine("Cliente possui Cartao Fidelidade?");
    //Console.WriteLine("s = sim | n = não");
    //cartao = Console.ReadLine();
    ////cartao = cartao.ToLower();
    //Console.WriteLine("Esta é a quinta compra do Cliente?");
    //Console.WriteLine("s = sim | n = não");
    //quinta = Console.ReadLine();
    //if (valorDaCompra > 400)
    //{
    //	// 20% desconto
    //	valorDaCompra = valorDaCompra - valorDaCompra * 0.2;
    //}
    //else if (valorDaCompra > 200 /*&& valorDaCompra <= 400*/)
    //{
    //	// 10% desconto
    //	valorDaCompra = valorDaCompra * 0.9;
    //}
    //switch (cartao)
    //{
    //	case "s":
    //    	valorDaCompra = valorDaCompra - valorDaCompra * 0.15;
    //    	break;
    //}
    //if (quinta == "s") // 's'
    //{
    //	valorDaCompra = valorDaCompra - valorDaCompra * 0.1;
    //}
    //Console.WriteLine("Valor com desconto é");
    //Console.WriteLine("{0:c}",valorDaCompra);

    {
        static void Main(string[] args)
        {
            char c_fide = ' ';
            int xcompras;
            double vdesc, vprod_cheio, vprod_desc, desc1, desc2, desc_fide;
            Console.WriteLine("cartao fidelidade: s=sim | n=nao");
            c_fide = char.Parse(Console.ReadLine());
            Console.WriteLine("quantas compras ja fez?");
            xcompras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o valor do produto: ");
            vprod_cheio = Convert.ToDouble(Console.ReadLine());

            desc1 = 0.10;
            desc2 = 0.20;
            desc_fide = 0.15;

            if (vprod_cheio >= 400.00)
            {
                vdesc = desc2 * vprod_cheio;
                vprod_desc = vprod_cheio - vdesc;
                Console.WriteLine("cliente recebeu desconto: " + vdesc);
                Console.WriteLine("valor total da compra c/ desconto: " + vprod_desc);
                Console.ReadLine();
            }

            else if (vprod_cheio >= 200.01 && vprod_cheio <= 400.00)
            {
                vdesc = desc2 * vprod_cheio;
                vprod_desc = vprod_cheio - vdesc;
                Console.WriteLine("cliente recebeu desconto: " + vdesc);
                Console.WriteLine("valor total da compra c/ desconto: " + vprod_desc);
                Console.ReadLine();
            }

            switch (c_fide)
            {
                case 's':
                    vdesc = desc_fide * vprod_cheio;
                    vprod_desc = vprod_cheio - vdesc;
                    Console.WriteLine("cliente recebeu desconto: " + vdesc);
                    Console.WriteLine("valor total da compra c/ desconto: " + vprod_desc);
                    break;
            }
            if (xcompras == 5)
            {
                vdesc = desc1 * vprod_cheio;
                vprod_desc = vprod_cheio - vdesc;
                Console.WriteLine("desconto pela quinta compra: " + vdesc);
                Console.WriteLine("valor total da compra c/ desconto: " + vprod_desc);
                Console.ReadLine();
            }
        }
    }
}