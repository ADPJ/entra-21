using System;

namespace AulaOOpt03Manha
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exec01
            //Console.WriteLine("Preencha um cachorro");
            //string nome, raca;
            //int idade;
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = Convert.ToInt32(Console.ReadLine());
            //Cachorro cao = new Cachorro(nome, raca, idade);

            //Console.WriteLine("-----------//-----------®");
            //Console.WriteLine(cao.GetNome());
            //Console.WriteLine(cao.GetRaca());
            //Console.WriteLine(cao.GetIdade());


            ////extra Usando os Setters 
            //Console.WriteLine("-----------//-----------®");
            //Console.WriteLine("Insira um Doginho");
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = Convert.ToInt32(Console.ReadLine());
            //cao.SetNome(raca);
            //cao.SetRaca(raca);
            //cao.SetIdade(idade);
            //Console.WriteLine("-----------//-----------®");
            //Console.WriteLine(cao.GetNome());
            //Console.WriteLine(cao.GetRaca());
            //Console.WriteLine(cao.GetIdade());

            //exec04
            // Criando um cliente vazio para preenche-lo 
            // usando os Setters
            Cliente raiva = new Cliente("", "", new string[1]);
            // ------
            Console.WriteLine("Preencha o cliente");
            string nome = Console.ReadLine();
            string cpf = Console.ReadLine();
            Console.WriteLine("insira as consultas");
            Console.WriteLine("para parar, insira f");

            //preenche as cosnultas
            string[] consultas = new string[10];
            int indice = 0;
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "f")
                {
                    break;
                }
                try
                {
                    consultas[indice] = temp;
                    indice++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Chegamos ao limite de 10 consultas");
                    break;
                }
            }
            raiva.SetNome(nome);
            raiva.SetCpf(cpf);
            raiva.SetConsultas(consultas);

            //mostra o cliente

            Console.WriteLine(raiva.GetNome());
            Console.WriteLine(raiva.GetCpf());
            //string[] consultasFinal = raiva.GetConsultas();
            for (int i = 0; i < raiva.GetConsultas().Length; i++)
            {
                if (raiva.GetConsultas()[i] == null)
                {
                    break;
                }
                Console.WriteLine(raiva.GetConsultas()[i]);
            }


        }
    }
}
