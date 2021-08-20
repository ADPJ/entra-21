using System;

namespace AulaEnumELambda
{
    class Program
    {
        enum Nomes
        {
            Carla,
            Joaquina,
            Astolfo,
            Tesla,
            JoanaDark
        }

        static void Main(string[] args)
        {
            //// 1)
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0} : {1}", i + 1, (Nomes)i);
            //}
            //Console.WriteLine("Qual nome Desejas?");
            //int escolha = Convert.ToInt32(Console.ReadLine());
            //escolha--;
            //Console.WriteLine("Este é o nome escolhido {0}", (Nomes)escolha);
            //string j = ((Nomes)escolha).ToString();
            //try
            //{
            //    // Deve usar o Convert, pois o int.Parse é simples de mais
            //    int k = Convert.ToInt32(Nomes.Carla);
            //    Console.WriteLine(k);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Deu ruim");
            //}

            // 2)
            Func<int, int> eleva = x =>
             {
                 if (x <= 10)
                 {
                     return x * x;
                 }
                 else
                 {
                     return x;
                 }
             };

            Console.WriteLine("Insira um numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(eleva(numero));
            Teste(eleva(numero));


        }
        public static void Teste(int j)
        {
            Console.WriteLine(j*j);
        }

    }
}
