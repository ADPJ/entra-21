using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05.aula06
{


    /* 5) Escreva uma função que receba 3 notas de um aluno e uma letra.
     * Se a letra for A a função retorna a média aritmética das notas do aluno,
     * se for P, a sua média ponderada(pesos: 5, 3 e 2) e se for M, a sua mediana. */

    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("Insira as 3 notas");
            string escolha;
            double nota1, nota2, nota3;
            nota1 = prog.CRD(); // CRD é uma função que pede um numero do usuario
            nota2 = prog.CRD(); // CRD é uma função que pede um numero do usuario
            nota3 = prog.CRD(); // CRD é uma função que pede um numero do usuario
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("a -> média aritmética das notas");
            Console.WriteLine("p -> média ponderada das notas");
            Console.WriteLine("m -> mediana das notas");
            escolha = prog.CR();// CR é uma função que chama o Console.ReadLine
            double devolucao = prog.Escolha(nota1, nota2, nota3, escolha);
            Console.WriteLine("-------------//-----------");
            
            if (devolucao == -1)
            {
                Console.WriteLine("Deu Ruim, opção inválida");
            }

            else
            {
                Console.WriteLine(devolucao);
            }

        }

        public double Escolha(double n1, double n2, double n3, string opcao)

        {
            double resultado = 0;

            switch (opcao)

            {
                case "A":
                case "a":

                    resultado = (n1 + n2 + n3) / 3;

                    return resultado;

                case "P":// media ponderada
                case "p":// (n1*p1 + n2*p2 + ... + nn*pn) / p1+p2+...pn

                    resultado = (n1 * 5 + n2 * 3 + n3 * 2) / (5 + 3 + 2);

                    return resultado;

                case "M":
                case "m":

                    double[] notas = new double[3];

                    notas[0] = n1;
                    notas[1] = n2;
                    notas[2] = n3;

                    Array.Sort(notas);

                    resultado = notas[1];

                    return resultado;

                default:

                    return -1;       
            }
        }
        
        public int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public string CR()
        {
            return Console.ReadLine();

        }

    }
}
