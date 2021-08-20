using System;

namespace AulaOOpt05Manha
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec 1 a
            Empresa emp = new Empresa();
            Console.WriteLine("Preencha a Empreza");
            emp.Nome = CR();
            emp.Idade = Convert.ToInt32(CR());
            emp.Saldo = Convert.ToDouble(CR());
            emp.QtdFuncionarios = int.Parse(CR());
            emp.Cnpj = CR();
            emp.Rua = CR();
            emp.Cep = CR();
            emp.Cidade = CR();
            emp.Estado = CR();
            emp.Pais = CR();
            // formatar o CNPJ @"{0:00\.000\.000\/0000\-00}"
            if (emp.QtdFuncionarios > 8)
            {
                Console.WriteLine(@" {0}  {1}  {2:00\.000\.000\/0000\-00}", emp.Nome, emp.Idade, Convert.ToInt64(emp.Cnpj));
                Console.WriteLine("{0:c}  {1}", emp.Saldo, emp.QtdFuncionarios);
                Console.WriteLine("{0}  {1}  {2}", emp.Rua, emp.Cep, emp.Cidade);
                Console.WriteLine("{0}  {1}", emp.Estado, emp.Pais);
            }
            else
            {
                Console.WriteLine("Micro empresa");
            }


        }
        public static string CR()
        {
            return Console.ReadLine();
        }
    }
}
