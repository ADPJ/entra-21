using System;

namespace Aula05
{
    class Program
    {
        //static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        //static int player = 1; //By default player 1 is set  

        //static int choice; //This holds the choice at which position user want to mark   
        //                   // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running

        //static int flag = 0;


        static void Main(string[] args)
        {
            ////Exemplo
            //int[][] matriz = new int[4][]; //Cria as linhas da matriz
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4]; //Cria as colunas
            //}
            //for (int i = 0; i < matriz.Length; i++) //Percorre as linhas
            //{
            //    for (int j = 0; j < matriz[i].Length; j++) //Percorre as colunas
            //    {

            //    }
            //}

            ////01
            //int[][] matriz = new int[4][]; //Cria as linhas da matriz
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4]; //Cria as colunas
            //}
            //for (int i = 0; i < matriz.Length; i++) //Percorre as linhas
            //{
            //    for (int j = 0; j < matriz[i].Length; j++) //Percorre as colunas
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j);
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //int contMaior = 0;
            //for (int i = 0; i < matriz.Length; i++) //Percorre as linhas
            //{
            //    for (int j = 0; j < matriz[i].Length; j++) //Percorre as colunas
            //    {
            //        if (matriz[i][j] > 10)
            //        {
            //            Console.WriteLine(matriz[i][j]);
            //            contMaior++;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("O total de valores maiores que 10 é: " + contMaior);

            ////02
            //int x = 5, y = 5;
            //int[,] matriz = new int[x,y];
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (i == j)
            //        {
            //            matriz[i, j] = 1;
            //        }
            //        else
            //        {
            //            matriz[i, j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////03
            //int x = 4,y = 4;
            //int[,] matriz = new int[x, y];
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = i * j;
            //    }
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////04
            //int x = 2, y = 2;
            //int[,] matriz = new int[x, y];
            //int a;
            //bool procura = false;
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("Insira o valor: " + i + " " + j);
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Insira o valor a ser procurado");
            //a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (matriz[i, j] == a)
            //        {
            //            Console.WriteLine("O valor a ser procurado foi encontrado!");
            //            Console.WriteLine("Sua posição é: " + i + " " + j);
            //            procura = true;
            //            break;
            //        }
            //    }
            //}
            //if (procura == false)
            //{
            //    Console.WriteLine("O valor não foi encontrado!");
            //}

            ////05
            //int[][] matriz1 = new int[2][];
            //int[][] matriz2 = new int[2][];
            //int[][] matriz3 = new int[2][];
            //for (int i = 0; i < matriz1.Length; i++)
            //{
            //    matriz1[i] = new int[2];
            //}

            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    matriz2[i] = new int[2];
            //}

            //for (int i = 0; i < matriz3.Length; i++)
            //{
            //    matriz3[i] = new int[2];
            //}

            //for (int i = 0; i < matriz1.Length; i++)
            //{
            //    for (int j = 0; j < matriz1[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j + " da matriz 1");
            //        matriz1[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    for (int j = 0; j < matriz2[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j + " da matriz 2");
            //        matriz2[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matriz3.Length; i++)
            //{
            //    for (int j = 0; j < matriz3[i].Length; j++)
            //    {
            //        if (matriz1[i][j] > matriz2[i][j])
            //        {
            //            matriz3[i][j] = matriz1[i][j];
            //        }
            //        else
            //        {
            //            matriz3[i][j] = matriz2[i][j];
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz3.Length; i++)
            //{
            //    for (int j = 0; j < matriz3[i].Length; j++)
            //    {
            //        Console.WriteLine("O maior valor na posição " + i + " " + j + " foi de: " + matriz3[i][j]);
            //    }
            //}

            ////06
            //int[][] matriz = new int[10][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[10];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (i < j)
            //        {
            //            matriz[i][j] = (2 * i) + (7 * j) - 2;
            //        }
            //        else if (i == j)
            //        {
            //            matriz[i][j] = (3 * i) - 1;
            //        }
            //        else
            //        {
            //            matriz[i][j] = (4 * i) - (5 * j) + 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////07
            //int[][] matriz = new int[4][];
            //int[][] mat = new int[4][];
            //int soma = 0;

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < mat.Length; i++)
            //{
            //    mat[i] = new int[4];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j);
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (j > i)
            //        {
            //            mat[i][j] = matriz[i][j];
            //            soma += mat[i][j];
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(mat[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Soma: " + soma);

            ////08
            //int[][] matriz = new int[4][];
            //int[][] mat = new int[4][];
            //int soma = 0;

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < mat.Length; i++)
            //{
            //    mat[i] = new int[4];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j);
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (j < i)
            //        {
            //            mat[i][j] = matriz[i][j];
            //            soma += mat[i][j];
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(mat[i][j] + " ");
            //    }
            //}
            //Console.WriteLine("Soma: " + soma);

            ////09
            //int[][] matriz = new int[4][];
            //int[][] mat = new int[4][];
            //Random ran = new Random();

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < mat.Length; i++)
            //{
            //    mat[i] = new int[4];
            //}

            //for (int i = 0; i < mat.Length; i++)
            //{
            //    for (int j = 0; j < mat[i].Length; j++)
            //    {
            //        int aleatorio = ran.Next(0, 21);
            //        mat[i][j] = aleatorio;
            //        matriz[i][j] = aleatorio;
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (j > i)
            //        {
            //            matriz[i][j] = 0;
            //        }
            //    }
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < mat.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < mat[i].Length; j++)
            //    {
            //        Console.Write(mat[i][j] + " ");
            //    }
            //}

            //10
            //int[][] matriz = new int[5][];
            //Random ran = new Random();
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[5];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        HashSet<int> numeros = new HashSet<int>();

            //        for (int a = 0; a < 26; a++)
            //            while (!numeros.Add(ran.Next(0,100))) ;
            //        foreach (var p in numeros)
            //        {
            //            matriz[i][j] = p;
            //        }
            //    }
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /////////////////////////////////////////////////////////////////////////////////////
            ///Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02
            ///
            ////01
            //int x = 3, y = 3;
            //int[,] matriz = new int[x, y];
            //int[] arrayMatriz = new int[3];
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j);
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < y; i++)
            //{
            //    arrayMatriz[i] += matriz[0, i];
            //    arrayMatriz[i] += matriz[1, i];
            //    arrayMatriz[i] += matriz[2, i];
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}

            //for (int i = 0; i < arrayMatriz.Length; i++)
            //{
            //    Console.Write(arrayMatriz[i] + " ");
            //}

            ////02
            //int x = 2, y = 4;
            //double[,] matriz = new double[x, y];
            //int matricula;
            //double mediaP, mediaT, maior = 0, matMaior = 0, media = 0;

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine("Insira a matrícula:");
            //    matricula = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.WriteLine("Insira a média das provas:");
            //    mediaP = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Insira a média dos trabalhos");
            //    mediaT = Convert.ToDouble(Console.ReadLine());

            //    matriz[i, 0] = matricula;
            //    matriz[i, 1] = mediaP;
            //    matriz[i, 2] = mediaT;
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    matriz[i, 3] = matriz[i, 1] + matriz[i, 2];
            //    if (matriz[i, 3] > maior)
            //    {
            //        maior = matriz[i, 3];
            //        matMaior = matriz[i, 0];
            //    }
            //}
            //Console.WriteLine("A maior nota foi: " + maior);
            //Console.WriteLine("A matrícula da maior nota foi: " + matMaior);

            //for (int i = 0; i < x; i++)
            //{
            //    media += matriz[i, 3];
            //}
            //media /= x;
            //Console.WriteLine("A média total foi de: " + media);

            ////03
            //int x = 3, y = 6;
            //int[,] matriz = new int[x, y];
            //int somaImp = 0;
            //double media = 0;
            //Random ran = new Random();

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = ran.Next(0, 21);
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j % 2 != 0)
            //        {
            //            somaImp += matriz[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("A soma de todos os elementos em colunas ímpares é: " + somaImp);
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j == 1 || j == 3)
            //        {
            //            media += matriz[i, j];
            //        }
            //    }
            //}
            //media /= 6;
            //Console.WriteLine("A média dos elementos da segunda e quarta coluna é: " + media);

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j == 5)
            //        {
            //            matriz[i, j] = matriz[i, 1] + matriz[i, 2];
            //        }
            //    }
            //}


            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}

            ////04
            //int x = 3, y = 3;
            //int[,] matrizA = new int[x, y];
            //int[,] matrizB = new int[x, y];
            //int[,] matrizC = new int[x, y];
            //Random ran = new Random();

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        int aleatorio = ran.Next(0, 11);
            //        matrizA[i, j] = aleatorio;
            //        aleatorio = ran.Next(0, 11);
            //        matrizB[i, j] = aleatorio;
            //        matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
            //    }
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matrizA[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matrizB[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matrizC[i, j] + " ");
            //    }
            //}


            ////////////////////////////////////////////////////////////////////////////////////
            //Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03

            //01
            //int[][] matriz = new int[3][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = 4;
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////02
            //Random ran = new Random();
            //int[][] matriz = new int[2][];
            //int soma = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        int a = ran.Next(0, 5);
            //        matriz[i][j] = a;
            //        soma += a;
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Soma: " + soma);

            ////03
            //Random ran = new Random();
            //int[][] matriz = new int[2][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        int a = ran.Next(0, 31);
            //        matriz[i][j] = a;
            //        Console.Write(a + " ");
            //    }
            //}
            //Console.WriteLine();
            //int w = matriz.Length;
            //int h = matriz[0].Length;
            //int[,] mat = new int[h, w];
            //for (int i = 0; i < h; ++i)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < w; ++j)
            //    {
            //        mat[i,j] = matriz[j][h - i - 1];
            //        Console.Write(mat[i,j] + " ");
            //    }
            //}

            ////04
            //int x = 3, y = 6;
            //int[,] matriz = new int[x, y];
            //int[] maior = new int[6];
            //Random ran = new Random();

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = ran.Next(0, 11);
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (matriz[i, j] > maior[j])
            //        {
            //            maior[j] = matriz[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < maior.Length; i++)
            //{
            //    Console.Write(maior[i] + " ");
            //}

            ////05
            //int x = 5, y = 5;
            //int[,] matriz = new int[x, y];
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = 0;
            //    }
            //}
            //while (true)
            //{
            //    Console.WriteLine("Assentos: ");
            //    for (int i = 0; i < x; i++)
            //    {
            //        Console.WriteLine();
            //        for (int j = 0; j < y; j++)
            //        {
            //            Console.Write(matriz[i, j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Escolha seu assento: ");
            //    int p0 = int.Parse(Console.ReadLine());
            //    int p1 = int.Parse(Console.ReadLine());
            //    bool z = false;

            //    if (matriz[p0, p1] == 0)
            //    {
            //        Console.WriteLine("Assento ocupado");
            //        matriz[p0, p1] = 1;
            //        z = true;
            //    }               
            //    if (z == false)
            //    {
            //        Console.WriteLine("O assento é inválido ou está ocupado!");
            //    }
            //}

            //06
            int x = 5, y = 2;
            string[,] matriz = new string[x, y];
            matriz[0, 0] = "admin";
            matriz[0, 1] = "password";
            while (true)
            {
                Console.WriteLine("Insira seu usuário e sua senha");
                string user = Console.ReadLine();
                string password = Console.ReadLine();

                if (user == matriz[0, 0] && password == matriz[0, 1])
                {
                    while (true)
                    {
                        Console.WriteLine("Qual operação você deseja fazer?");
                        Console.WriteLine("1 - Criar user | 2 - Deletar user | 3 - LogOut");
                        string escolha = Console.ReadLine();
                        if (escolha == "1")
                        {
                            for (int i = 0; i < x; i++)
                            {
                                Console.WriteLine();
                                for (int j = 0; j < y; j++)
                                {
                                    Console.Write("Id: " + i + " " + matriz[i, j] + " ");
                                }
                            }
                            Console.WriteLine();

                            Console.WriteLine("Insira o usuário e a senha");
                            user = Console.ReadLine();
                            password = Console.ReadLine();

                            for (int i = 0; i < x; i++)
                            {
                                for (int j = 0; j < y; j++)
                                {
                                    if (matriz[i, j] == null && matriz[i, (j + 1)] == null)
                                    {
                                        matriz[i, j] = user;
                                        matriz[i, (j + 1)] = password;
                                        Console.WriteLine("Usuário criado");
                                        i = 200;
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (escolha == "2")
                        {
                            for (int i = 0; i < x; i++)
                            {
                                Console.WriteLine();
                                for (int j = 0; j < y; j++)
                                {
                                    Console.Write("Id: " + i + " " + matriz[i, j] + " ");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Qual id você deseja deletar?");
                            int userAp = int.Parse(Console.ReadLine());
                            int passwordAp = 0;

                            if (matriz[userAp, passwordAp] != null && matriz[userAp, (passwordAp + 1)] != null)
                            {
                                matriz[userAp, passwordAp] = null;
                                matriz[userAp, (passwordAp + 1)] = null;
                                Console.WriteLine("Usuário apagado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Deslogando");
                            break;
                        }
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (matriz[i, j] == user && matriz[i, (j + 1)] == password)
                        {
                            Console.WriteLine("Usuário logado");
                        }
                    }
                }
            }

            //07
            //int x = 4, y = 3;
            //string[,] matriz = new string[x, y];
            //while (true)
            //{
            //    Console.WriteLine("Alunos: ");
            //    Console.WriteLine();
            //    for (int i = 0; i < x; i++)
            //    {
            //        Console.WriteLine();
            //        for (int j = 0; j < y; j++)
            //        {
            //            Console.Write("ID: " + i + " " + matriz[i, j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Em qual id você deseja adicionar um novo aluno?");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.WriteLine("Insira o nome, o cpf e a idade");
            //    string nome = Console.ReadLine();
            //    string cpf = Console.ReadLine();
            //    string idade = Console.ReadLine();

            //    matriz[id, 0] = nome;
            //    matriz[id, 1] = cpf;
            //    matriz[id, 2] = idade;
            //}
            //

            ////08

            //    do

            //    {

            //        Console.Clear();// whenever loop will be again start then screen will be clear  

            //        Console.WriteLine("Player1:X and Player2:O");

            //        Console.WriteLine("\n");

            //        if (player % 2 == 0)//checking the chance of the player  

            //        {

            //            Console.WriteLine("Player 2 Chance");

            //        }

            //        else

            //        {

            //            Console.WriteLine("Player 1 Chance");

            //        }

            //        Console.WriteLine("\n");

            //        Board();// calling the board Function  

            //        choice = int.Parse(Console.ReadLine());//Taking users choice   



            //        // checking that position where user want to run is marked (with X or O) or not  

            //        if (arr[choice] != 'X' && arr[choice] != 'O')

            //        {

            //            if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  

            //            {

            //                arr[choice] = 'O';

            //                player++;

            //            }

            //            else

            //            {

            //                arr[choice] = 'X';

            //                player++;

            //            }

            //        }

            //        else //If there is any possition where user want to run and that is already marked then show message and load board again  

            //        {

            //            Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

            //            Console.WriteLine("\n");

            //            Console.WriteLine("Please wait 2 second board is loading again.....");

            //            Thread.Sleep(2000);

            //        }

            //        flag = CheckWin();// calling of check win  

            //    } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  



            //    Console.Clear();// clearing the console  

            //    Board();// getting filled board again  



            //    if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  

            //    {

            //        Console.WriteLine("Player {0} has won", (player % 2) + 1);

            //    }

            //    else// if flag value is -1 the match will be draw and no one is winner  

            //    {

            //        Console.WriteLine("Draw");

            //    }

            //    Console.ReadLine();

            //}

            //// Board method which creats board  

            //private static void Board()

            //{

            //    Console.WriteLine("     |     |      ");

            //    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            //    Console.WriteLine("_____|_____|_____ ");

            //    Console.WriteLine("     |     |      ");

            //    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            //    Console.WriteLine("_____|_____|_____ ");

            //    Console.WriteLine("     |     |      ");

            //    Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            //    Console.WriteLine("     |     |      ");

            //}



            ////Checking that any player has won or not  

            //private static int CheckWin()

            //{

            //    #region Horzontal Winning Condtion

            //    //Winning Condition For First Row   

            //    if (arr[1] == arr[2] && arr[2] == arr[3])

            //    {

            //        return 1;

            //    }

            //    //Winning Condition For Second Row   

            //    else if (arr[4] == arr[5] && arr[5] == arr[6])

            //    {

            //        return 1;

            //    }

            //    //Winning Condition For Third Row   

            //    else if (arr[6] == arr[7] && arr[7] == arr[8])

            //    {

            //        return 1;

            //    }

            //    #endregion



            //    #region vertical Winning Condtion

            //    //Winning Condition For First Column       

            //    else if (arr[1] == arr[4] && arr[4] == arr[7])

            //    {

            //        return 1;

            //    }

            //    //Winning Condition For Second Column  

            //    else if (arr[2] == arr[5] && arr[5] == arr[8])

            //    {

            //        return 1;

            //    }

            //    //Winning Condition For Third Column  

            //    else if (arr[3] == arr[6] && arr[6] == arr[9])

            //    {

            //        return 1;

            //    }

            //    #endregion



            //    #region Diagonal Winning Condition

            //    else if (arr[1] == arr[5] && arr[5] == arr[9])

            //    {

            //        return 1;

            //    }

            //    else if (arr[3] == arr[5] && arr[5] == arr[7])

            //    {

            //        return 1;

            //    }

            //    #endregion



            //    #region Checking For Draw

            //    // If all the cells or values filled with X or O then any player has won the match  

            //    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

            //    {

            //        return -1;

            //    }

            //    #endregion



            //    else

            //    {

            //        return 0;

            //    }


            /////////////////////////////////////////////////////////////////////////////////////////
            ///Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04
            ////01
            //int x = 2, y = 2;
            //int[,] matriz = new int[x, y];
            //int soma = 0;
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j);
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //        soma += matriz[i, j];
            //    }
            //}

            //Console.WriteLine("A soma deu: " + soma);

            ////02
            //int x = 3, y = 3;
            //int[,] matriz = new int[x, y];
            //Random ran = new Random();
            //int soma = 0;

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = ran.Next(0, 11);
            //        if (i == j)
            //        {
            //            soma += matriz[i, j];
            //        }
            //        Console.Write(matriz[i,j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("A soma deu: " + soma);

            ////03
            //int x = 3, y = 3;
            //int[,] matriz = new int[x, y];
            //Random ran = new Random();
            //int soma = 0;

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = ran.Next(0, 11);
            //        if (j == (3 - 1 - i))
            //        {
            //            soma += matriz[i, j];
            //        }
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("A soma deu: " + soma);

            ////04
            //int x = 2, y = 2;
            //int[,] matriz = new int[x, y];
            //int[,] matriz2 = new int[x, y];
            //int[,] mult = new int[x, y];
            //Random ran = new Random();

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = ran.Next(0, 11);
            //        matriz2[i, j] = ran.Next(0, 11);
            //    }
            //}
            //mult[0, 0] = (matriz[0, 0] * matriz2[0, 0]) + (matriz[0, 1] * matriz2[1, 0]);
            //mult[0,1] = (matriz[0, 0] * matriz2[0, 1]) + (matriz[0, 1] * matriz2[1, 1]);
            //mult[1,0] = (matriz[1, 0] * matriz2[0, 0]) + (matriz[1, 1] * matriz2[1, 0]);
            //mult[1,1] = (matriz[1, 0] * matriz2[0, 1]) + (matriz[1, 1] * matriz2[1, 1]);
            //Console.WriteLine("Matriz A");
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Matriz B");
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz2[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Matriz Multiplicada");
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(mult[i, j] + " ");
            //    }
            //}

            ////05
            //int x = 3, y = 3;
            //int[,] matriz = new int[x, y];
            //Random ran = new Random();
            //int det = 0;

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j);
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////for (int i = 0; i < x; i++)
            ////{
            ////    Console.WriteLine();
            ////    for (int j = 0; j < y; j++)
            ////    {
            ////        matriz[i, j] = ran.Next(0, 11);
            ////        Console.Write(matriz[i, j] + " ");
            ////    }
            ////}

            //for (int i = 0; i < 3; i++)
            //    det = det + (matriz[0, i] * (matriz[1, (i + 1) % 3] * matriz[2, (i + 2) % 3] - matriz[1, (i + 2) % 3] * matriz[2, (i + 1) % 3]));

            //Console.WriteLine("A determinante deu: " +det);

            /////////////////////////////////////////////////////////////////////////////////////
            ///Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05
            ///

            //01
            //int x = 2, y = 4;
            //double[,] matriz = new double[x, y];
            //int matricula;
            //double mediaP, mediaT, maior = 0, matMaior = 0, media = 0;

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine("Insira a matrícula:");
            //    matricula = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.WriteLine("Insira a média das provas:");
            //    mediaP = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Insira a média dos trabalhos");
            //    mediaT = Convert.ToDouble(Console.ReadLine());

            //    matriz[i, 0] = matricula;
            //    matriz[i, 1] = mediaP;
            //    matriz[i, 2] = mediaT;
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    matriz[i, 3] = matriz[i, 1] + matriz[i, 2];
            //    if (matriz[i, 3] > maior)
            //    {
            //        maior = matriz[i, 3];
            //        matMaior = matriz[i, 0];
            //    }
            //}
            //Console.WriteLine("A maior nota foi: " + maior);
            //Console.WriteLine("A matrícula da maior nota foi: " + matMaior);

            //for (int i = 0; i < x; i++)
            //{
            //    media += matriz[i, 3];
            //}
            //media /= x;
            //Console.WriteLine("A média total foi de: " + media);

            //02
            //int x = 3, y = 6;
            //int[,] matriz = new int[x, y];
            //int somaImp = 0;
            //double media = 0;
            //Random ran = new Random();

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        matriz[i, j] = ran.Next(0, 21);
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j % 2 != 0)
            //        {
            //            somaImp += matriz[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("A soma de todos os elementos em colunas ímpares é: " + somaImp);
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j == 1 || j == 3)
            //        {
            //            media += matriz[i, j];
            //        }
            //    }
            //}
            //media /= 6;
            //Console.WriteLine("A média dos elementos da segunda e quarta coluna é: " + media);

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (j == 5)
            //        {
            //            matriz[i, j] = matriz[i, 1] + matriz[i, 2];
            //        }
            //    }
            //}


            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //}

            ////03
            //int x = 2, y = 2;
            //int[,] matriz1 = new int[x, y];
            //int[,] matriz2 = new int[x, y];
            //int[,] matMod = new int[x, y];

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j + " da matriz 1");
            //        matriz1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.WriteLine("Insira o valor " + i + " " + j + " da matriz 2");
            //        matriz2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //while (true)
            //{
            //    Console.WriteLine("Insira a opção");
            //    Console.WriteLine("a - somar as matrizes");
            //    Console.WriteLine("b - subtrair a primeira matriz da segunda");
            //    Console.WriteLine("c - adicionar uma constante");
            //    Console.WriteLine("d - imprimir matrizes (incluso em todas as funções)");
            //    Console.WriteLine("qualquer letra - encerrar programa");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "a")
            //    {
            //        for (int i = 0; i < x; i++)
            //        {
            //            for (int j = 0; j < y; j++)
            //            {
            //                matMod[i, j] = matriz1[i, j] + matriz2[i, j];
            //            }
            //        }
            //        for (int i = 0; i < x; i++)
            //        {
            //            Console.WriteLine();
            //            for (int j = 0; j < y; j++)
            //            {
            //                Console.Write(matMod[i, j] + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    else if (escolha == "b")
            //    {
            //        for (int i = 0; i < x; i++)
            //        {
            //            for (int j = 0; j < y; j++)
            //            {
            //                matMod[i, j] = matriz1[i, j] - matriz2[i, j];
            //            }
            //        }
            //        for (int i = 0; i < x; i++)
            //        {
            //            Console.WriteLine();
            //            for (int j = 0; j < y; j++)
            //            {
            //                Console.Write(matMod[i, j] + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    else if (escolha == "c")
            //    {
            //        Console.WriteLine("Insira a constante");
            //        int constante = int.Parse(Console.ReadLine());
            //        for (int i = 0; i < x; i++)
            //        {
            //            for (int j = 0; j < y; j++)
            //            {
            //                matriz1[i, j] += constante;
            //                matriz2[i, j] += constante;
            //            }
            //        }
            //        Console.WriteLine("Matriz 1");
            //        for (int i = 0; i < x; i++)
            //        {
            //            Console.WriteLine();
            //            for (int j = 0; j < y; j++)
            //            {
            //                Console.Write(matriz1[i, j] + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Matriz 2");
            //        for (int i = 0; i < x; i++)
            //        {
            //            Console.WriteLine();
            //            for (int j = 0; j < y; j++)
            //            {
            //                Console.Write(matriz2[i, j] + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            ////04
            //int k = 0;
            //int[] bunecao = new int[3];

            //bool letraExiste = false;

            //Console.WriteLine("Insira a palavra");
            //string palavra = Console.ReadLine();
            //palavra = palavra.ToLower();
            //Console.Clear();

            //string[] letras = new string[palavra.Length];
            //string[] let = new string[palavra.Length];
            //for (int i = 0; i < letras.Length; i++)
            //{
            //    letras[i] = palavra[i].ToString();
            //}
            //int contador = letras.Length;
            //int cont = 0;
            //while (true)
            //{
            //    Console.WriteLine("Insira uma letra");
            //    string letra = Console.ReadLine();
            //    //string[] letrasJogadas = new string[(palavra.Length + 9)];
            //    for (int i = 0; i < letras.Length; i++)
            //    {
            //        if (letra == letras[i])
            //        {
            //            Console.WriteLine("A letra " + letra + " existe!");
            //            letraExiste = true;
            //            let[i] = letra;
            //            cont++;
            //            for (int c = 0; c < k; c++)
            //            {
            //                Console.Write(bunecao[c]);
            //            }
            //            //letrasJogadas[i] = letra; //Add as letras jogadas
            //            break;
            //        }
            //    }

            //    //for (int i = 0; i < letrasJogadas.Length; i++) //Mostra as letras jogadas
            //    //{
            //    //    if(letrasJogadas[i] == null)
            //    //    {
            //    //        break;
            //    //    }
            //    //    Console.WriteLine("Letras jogadas: " + letrasJogadas[i]);
            //    //}

            //    if (letraExiste == false) //Verificação letraExiste
            //    {
            //        Console.WriteLine("A letra não existe!");
            //        k++;
            //        for (int i = 0; i < k; i++)
            //        {
            //            Console.Write(bunecao[i]);
            //        }
            //        if (k > 8)
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("Você perdeu!");
            //            break;
            //        }
            //    }
            //    letraExiste = false;
            //    Console.WriteLine();

            //    //for (int i = 0; i < let.Length; i++) //Mostrar letras acertadas
            //    //{
            //    //    if (let[i] == null)
            //    //    {
            //    //        Console.Write("_" + " ");
            //    //    }
            //    //    else
            //    //    {
            //    //        for (int d = 0; d < letras.Length; d++)
            //    //        {
            //    //            if (letra == letras[i] && letra == letras[(i + 1)])
            //    //            {
            //    //                let[(i + 1)] = letra;
            //    //            }
            //    //        }
            //    //        Console.Write(let[i] + " ");
            //    //    }
            //    //}

            //    //Verificação encerrarPartida
            //    if (cont == contador)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Você venceu!");
            //        break;
            //    }
            //}
        }
    }
}
