using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07.aula03
{
    class Program
    {
        static void Main(string[] args)

//6) Uma escola precisa fazer o cadastro dos alunos, para isso, precisa-se:
//nome,cpf,endereço do aluno, para isso, aramezene todos esses valores em variáveis e então mostre na tela,
//em seguida, pergunte se a pessoa deseja cadastrar mais um aluno, isso se repete até a pessoa parar de adicionar
//ps: pode usar apenas 3 variaveis

        {
            string nome, cpf, endereco;
            while (nome == "s")
            while (true)
            {
                Console.WriteLine("Insira o Nome");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o CPF");
                cpf = Console.ReadLine();
                Console.WriteLine("Insira o Endereco");
                endereco = Console.ReadLine();
                Console.WriteLine("-----------//-----------");
                Console.WriteLine(nome);
                Console.WriteLine(cpf);
                Console.WriteLine(endereco);
                Console.WriteLine("Deseja cadastrar mais um aluno?");
                Console.WriteLine("s = sim | n = não");
                nome = Console.ReadLine();
                if (nome == "n")
                {
                    break;
                }
            }




        }
    }
}
