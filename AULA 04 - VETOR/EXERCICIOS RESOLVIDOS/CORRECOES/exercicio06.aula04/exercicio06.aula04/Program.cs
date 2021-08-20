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
        /*6) Imagine que uma escola deseja cadastrar alunos para isso ,
         * Crie 3 vetores de 4 posições/tamanho 4, um para os nome,outro para cpf,
         * e outro para idade, primeiro, mostre para o usuario em ordem,
         * os alunos ja armazenados, entao,
         * o usuario escolhe em qual lugar ele deseja armazenar um novo aluno
         * (ex: usuario escolheu 2 , pede-se um nome,cpf e idade, entao,
         * coloque tudo isso na 2° posição dos tres vetores)
         * ao terminar de colocar aluno, pede-se ao usuario se deseja colocar um novo aluno ou sair. */

        {
            string[] nome = new string[4];
            string[] cpf = new string[4];
            int[] idade = new int[4];

            while (true)
            {
                for (int i = 0; i < nome.Length; i++)
                {
                    Console.WriteLine("Digite o cadastro do aluno:");
                    Console.WriteLine("aluno_________________: " + (i + 1));
                    Console.WriteLine("nome__________________: " + nome[i]);
                    Console.WriteLine("CPF___________________: " + cpf[i]);
                    Console.WriteLine("idade_________________: " + idade[i]);
                    Console.WriteLine("========================");
                }

                Console.WriteLine("digite qual aluno deseja alterar");
                int escolha = Convert.ToInt32(Console.ReadLine());

                {
                    Console.WriteLine("informe o nome do aluno:");
                    nome[escolha - 1] = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("informe o CPF do aluno:");
                    cpf[escolha - 1] = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("informe a idade do aluno:");
                    idade[escolha - 1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=======================");
                    Console.WriteLine("escolha 1-sair ou 2-continuar alterando");
                    escolha = Convert.ToInt32(Console.ReadLine());
                }

                if (escolha == 1)
                {
                    break;
                }
            }
        }
    }
}
