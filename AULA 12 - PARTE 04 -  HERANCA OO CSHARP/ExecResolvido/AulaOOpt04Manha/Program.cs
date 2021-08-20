using System;

namespace AulaOOpt04Manha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:#.###}", 1552.342885182);
            Pessoa pes = new Pessoa();
            Console.WriteLine("Por Favor insira uma pessoa");
            pes.Nome = CR();
            pes.Cpf = CR();
            pes.Idade = Convert.ToInt32(CR());
            pes.Rua = CR();
            pes.Numero = CR();
            pes.Cidade = CR();
            pes.Estado = CR();

            Console.WriteLine("------------//-------------®");
            Console.WriteLine(@"{0} | {1:000\.000\.000\-00} | {2}", pes.Nome,Convert.ToInt64(pes.Cpf), pes.Idade);
            Console.WriteLine("{0} |n{1} | {2} | {3}", pes.Rua, pes.Numero, pes.Cidade, pes.Estado);

        }
        public static string CR()
        {
            return Console.ReadLine();
        }
    }
}
