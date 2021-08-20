using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08.aula02
{
/*8) Receba um valor de produto, se o produto custar mais que R$254,50 deve-se aplicar um desconto de 28%
 * e mostrar na tela o valor original e com desconto, caso contrário, o desconto deve ser de apenas 21% e
 * mostrar na tela o valor original e com desconto*/
    class Program
    {
        static void Main(string[] args)
        {   
            while (true) {
            double desc_1, desc_2, vdesc, vprod_cheio, vprod_desc;
            Console.WriteLine("digite valor do produto: ");
            desc_1 = 0.28;
            desc_2 = 0.21;
            vprod_cheio = Convert.ToDouble(Console.ReadLine());
            
            if (vprod_cheio >= 254.50)
            {
                vdesc = vprod_cheio * desc_1; 
                vprod_desc = vprod_cheio - vdesc;
                Console.WriteLine("produto recebeu desconto R$"+vdesc);
                Console.WriteLine("valor do produto c/ desconto R$" + vprod_desc);
            }

            else
            {
                vdesc = vprod_cheio * desc_2;
                vprod_desc = vprod_cheio - vdesc;
                Console.WriteLine("produto recebeu desconto R$"+vdesc);
                Console.WriteLine("valor do produto c/ desconto R$"+vprod_desc);
            }
            }
        }
    }
}
