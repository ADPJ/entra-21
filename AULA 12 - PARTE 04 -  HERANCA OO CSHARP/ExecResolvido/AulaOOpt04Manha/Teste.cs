using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt04Manha
{
    class Teste
    {



        private string nome;
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }


        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int[] Endereco { get; set; }
        public Teste(string nome, string cpf, int[] endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }







    }
}
