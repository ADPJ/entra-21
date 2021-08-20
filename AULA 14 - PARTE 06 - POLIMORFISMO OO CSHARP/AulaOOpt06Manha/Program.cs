using Correios.Net;
using System;
using System.Collections.Generic;

namespace AulaOOpt06Manha
{
    class Program
    {
        static void Main(string[] args)
        {

            //// 1) e)
            //Console.WriteLine("Ola ADM, qual o preço do ingreso e qual o Extra do VIP?");
            //double valor, extra;
            //valor = CR(0d);
            //extra = CR(0d);
            //Normal nor = new Normal();
            //nor.Valor = valor;
            //CamaroteInferior camI = new CamaroteInferior();
            //camI.Valor = valor;
            //camI.ValorExtra = extra;
            //Console.WriteLine("Qual a localização do Camarote Inferior?");
            //camI.Localizacao = CR();
            //CamaroteSuperior camS = new CamaroteSuperior();
            //camS.Valor = valor * 3;
            //camS.ValorExtra = extra * 3;
            //Console.WriteLine("Qual a localização do Camarote Superior?");
            //camS.Localizacao = CR();

            //Console.WriteLine("Sr. Cliente, qual desejas comprar?");
            //Console.WriteLine("Ingresso Normal");
            //nor.ImprimeValor();
            //Console.WriteLine("Camarote Inferior");
            //camI.ImprimeValor();
            //Console.WriteLine("Camarote Superior");
            //camS.ImprimeValor();
            //CR();
            //Console.WriteLine("Obrigado pela preferencia");

            ////2) c)
            //Administrativo adm = new Administrativo();
            //Tecnico tec = new Tecnico();
            //adm.Nome = "Joeslei";
            //adm.Salario = 2568.48;
            //adm.NumeroMatricula = 155248;
            //adm.Bonus = 562.12;
            //adm.Turno = false;
            //tec.Nome = "Jaime";
            //tec.Salario = 1978.25;
            //tec.NumeroMatricula = 125466;
            //tec.Bonus = 897.15;
            ////Assistente assis = Preenche();

            //while (true)
            //{
            //    Console.WriteLine("O que deseja Fazer?");
            //    Console.WriteLine("1- Editar");
            //    Console.WriteLine("2- Excluir");
            //    Console.WriteLine("3- Sair");
            //    int escolha = CR(0);

            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Qual deseja editar?");
            //        Console.WriteLine("1");
            //        adm.ExibeDados();
            //        Console.WriteLine("-----------//-----------®");
            //        Console.WriteLine("2");
            //        tec.ExibeDados();
            //        escolha = CR(0);
            //        if (escolha == 1)
            //        {
            //            adm = Preenche(0);
            //        }
            //        else
            //        {
            //            tec = Preenche();
            //        }
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("Qual deseja excluir?");
            //        Console.WriteLine("1");
            //        adm.ExibeDados();
            //        Console.WriteLine("-----------//-----------®");
            //        Console.WriteLine("2");
            //        tec.ExibeDados();
            //        escolha = CR(0);
            //        if (escolha == 1)
            //        {
            //            adm = new Administrativo();
            //        }
            //        else
            //        {
            //            tec = new Tecnico();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Obrigado por usar nossos Serviços");
            //        break;
            //    }
            //}

            //3)c)

            List<Novo> novos = new List<Novo>();
            List<Velho> velhos = new List<Velho>();
            Random ran = new Random();
            for (int i = 0; i < 2; i++)
            {
                Novo n = new Novo();
                n.Endereco = $"Rua XV   n°{ran.Next(10, 200 + 1)}";
                n.Preco = ran.Next(100000, 300000 + 1);
                n.Adicional = ran.Next(50000, 100000 + 1);
                n.CalculaValor();
                Velho v = new Velho();
                v.Endereco = $"Rua General Osório   n°{ran.Next(10, 200 + 1)}";
                v.Preco = ran.Next(100000, 200000 + 1);
                v.Desconto = ran.Next(50000, 100000 + 1);
                v.CalculaValor();
                novos.Add(n); velhos.Add(v);
            }
            Cliente cli = new Cliente();
            cli.Nome = "Cleber";
            cli.DinheiroDisponivel = ran.Next(100000, 300000 + 1);

            while (true)
            {

                Console.WriteLine("Ola Sr " + cli.Nome);
                Console.WriteLine("Com saldo de : {0:c}", cli.DinheiroDisponivel);
                Console.WriteLine("Qual apartamento deseja comprar?");
                Console.WriteLine("Imoveis Novos");
                int contador = 1;
                foreach (var item in novos)
                {
                    Console.WriteLine(contador);
                    MostraObjeto(item);
                    contador++;
                }
                Console.WriteLine("Imoveis Clássicos");
                foreach (var item in velhos)
                {
                    Console.WriteLine(contador);
                    MostraObjeto(item);
                    contador++;
                }
                Console.WriteLine("Qual Deseja Comprar?");
                contador = CR(0);
                if (contador < 3)
                {
                    contador--;
                    if (novos[contador].Preco > cli.DinheiroDisponivel)
                    {
                        Console.WriteLine("Nao tem como pagar à vista");
                        Console.WriteLine("Mas podemos parcelar pra você");
                        double valorParcela = CalculaParcela(novos[contador].Preco);
                        Console.WriteLine("Deseja Finalizar esta compra?");
                        Console.WriteLine("1- Sim\n2- Nao");
                        contador = CR(0);
                        if (contador == 1)
                        {
                            cli.DinheiroDisponivel -= valorParcela;
                            Console.WriteLine("Obrigado pela preferência");
                            break;
                        }
                    }
                    else
                    {                        
                        cli.DinheiroDisponivel -= novos[contador].Preco;
                        Console.WriteLine("Obrigado pela preferência");
                        break;
                    }
                }
                else
                {
                    contador -= 3;
                    if (velhos[contador].Preco > cli.DinheiroDisponivel)
                    {
                        Console.WriteLine("Nao tem como pagar à vista");
                        Console.WriteLine("Mas podemos parcelar pra você");
                        double valorParcela = CalculaParcela(velhos[contador].Preco);
                        Console.WriteLine("Deseja Finalizar esta compra?");
                        Console.WriteLine("1- Sim\n2- Nao");
                        contador = CR(0);
                        if (contador == 1)
                        {
                            cli.DinheiroDisponivel -= valorParcela;
                            Console.WriteLine("Obrigado pela preferência");
                            break;
                        }
                    }
                    else
                    {
                        
                        cli.DinheiroDisponivel -= velhos[contador].Preco;
                        Console.WriteLine("Obrigado pela preferência");
                        break;
                    }
                }
                Console.WriteLine("Pressione Enter para prosseguir");
                CR();
                Console.Clear();
            }
            Console.WriteLine("Saldo Final do Cliente");
            Console.WriteLine(cli.DinheiroDisponivel);
        }
        public static double CalculaParcela(double valor)
        {
            Console.WriteLine("Valor das parcelas {0:c}", (valor * 1.1674) / 12);
            Console.WriteLine("Valor Final {0:c}", (valor * 1.1674));
            return (valor * 1.1674) / 12;
        }
        public static void MostraObjeto(Novo n)
        {
            Console.WriteLine(n.Endereco);
            Console.WriteLine("{0:c}", n.Preco);
            Console.WriteLine("-----------//-------------®");
        }
        public static void MostraObjeto(Velho v)
        {
            Console.WriteLine(v.Endereco);
            Console.WriteLine("{0:c}", v.Preco);
            Console.WriteLine("-----------//-------------®");
        }

        public static Tecnico Preenche()
        {
            Console.WriteLine("Preencha os Dados");
            Tecnico tec = new Tecnico();
            tec.Nome = CR();
            tec.Salario = CR(0d);
            tec.NumeroMatricula = CR(0);
            tec.Bonus = CR(0d);
            return tec;
        }
        public static Administrativo Preenche(int administrativo)
        {
            Console.WriteLine("Preencha os dados novos");
            Administrativo adm = new Administrativo();
            adm.Nome = CR();
            adm.Salario = CR(0d);
            adm.NumeroMatricula = CR(0);
            adm.Bonus = CR(0d);
            Console.WriteLine("Qual o turno?\ndia\nnoite");
            string turno = CR();
            if (turno == "dia")
            {
                adm.Turno = true;
            }
            else
            {
                adm.Turno = false;
            }
            return adm;
        }

        /// <summary>
        /// Esta função é um resumo de Console.ReadLine()
        /// </summary>
        /// <returns>user insert blabla then return blabla</returns>
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static double CR(double j)
        {
            return double.Parse(Console.ReadLine());
        }
        public static int CR(int j)
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double CRD()
        {
            return double.Parse(Console.ReadLine());
        }

    }
}
