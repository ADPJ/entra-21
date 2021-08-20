using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02.aula05
{
    class Program
    {
        static void Main(string[] args)

        /*2) Faça um programa que leia uma matriz de 5 linhas e 4 colunas contendo as seguintes
        informações sobre alunos de uma disciplina, sendo todas as informações do tipo inteiro: •
        Primeira coluna: numero de matrícula (use um inteiro)
        • Segunda coluna: media das provas
        • Terceira coluna: media dos trabalhos
        • Quarta coluna: nota final
        Elabore um programa que:
        (a) Leia as tres primeiras informações de cada aluno
        (b) Calcule a nota final como sendo a soma da media das provas e da média dos trabalhos
        (c) Imprima a matrícula do aluno que obteve a maior nota final (assuma que só existe
        uma maior nota)
        (d) Imprima a media aritmética das notas finais */


        {
            int[][] matriz = new int[3][];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[4];
            }

            //// a)

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length - 1; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Qual a matricula do " + (i + 1) + "° aluno");
                        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Qual a nota das provas do " + (i + 1) + "° aluno");
                        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Qual a nota dos trabalhos do " + (i + 1) + "° aluno");
                        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // b)
                matriz[i][matriz[i].Length - 1] = matriz[i][1] + matriz[i][2];
            }

            //Console.WriteLine("-------------//-----------");

            // c)

            int notaFinal = -1, valorNotaFinal = -1;

            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i][3] > valorNotaFinal)
                {
                    valorNotaFinal = matriz[i][3];
                    notaFinal = i;
                }

            }

            Console.WriteLine("Aluno com a maior nota");
            Console.WriteLine(matriz[notaFinal][0]);

            //Console.WriteLine("-------------//-----------");

            //d)

            int mediaFinal = 0;

            for (int i = 0; i < matriz.Length; i++)
            {
                mediaFinal += matriz[i][3];
            }

            Console.WriteLine("A media final de todos os alunos é !!!");
            Console.WriteLine(mediaFinal / matriz.Length);
        }
    }
}
