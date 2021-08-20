using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIO09.AULA02
{
/*9) Receba o salário de um funcionário, baseado no valor que esta na tabela abaixo, então, apresente o salário com aumento.*/

    class Program
    {
        static void Main(string[] args)
        {
            double sal_atual, sal_aumento, aumento, ajuste_1, ajuste_2, ajuste_3, ajuste_4, ajuste_5;


            while (true)
            {

                Console.WriteLine("Digite Salario Atual do Funcionario: ");

                sal_atual = Convert.ToDouble(Console.ReadLine());

                ajuste_1 = 0.10;
                ajuste_2 = 0.15;
                ajuste_3 = 0.20;
                ajuste_4 = 0.25;
                ajuste_5 = 0.30;

                if (sal_atual >= 3550.00)

                {
                    aumento = ajuste_1 * sal_atual;
                    sal_aumento = sal_atual + aumento;

                    Console.WriteLine("Salario Atualizado para R$: " + sal_aumento);
                    sal_atual = Convert.ToDouble(Console.ReadLine());
                }

                else if (sal_atual >= 2400.00)

                {
                    aumento = ajuste_2 * sal_atual;
                    sal_aumento = sal_atual + aumento;

                    Console.WriteLine("Salario Atualizado para R$: " + sal_aumento);
                    sal_atual = Convert.ToDouble(Console.ReadLine());
                }

                else if (sal_atual >= 1100.01)

                {
                    aumento = ajuste_3 * sal_atual;
                    sal_aumento = sal_atual + aumento;

                    Console.WriteLine("Salario Atualizado para R$: " + sal_aumento);
                    sal_atual = Convert.ToDouble(Console.ReadLine());
                }

                else if (sal_atual >= 600.00)

                {
                    aumento = ajuste_4 * sal_atual;
                    sal_aumento = sal_atual + aumento;

                    Console.WriteLine("Salario Atualizado para R$: " + sal_aumento);
                    sal_atual = Convert.ToDouble(Console.ReadLine());
                }

                else

                {
                    aumento = ajuste_5 * sal_atual;
                    sal_aumento = sal_atual + aumento;

                    Console.WriteLine("Salario Atualizado Para R$: " + sal_aumento);
                    sal_atual = Convert.ToDouble(Console.ReadLine());
                }

            }
        }
    }
}
