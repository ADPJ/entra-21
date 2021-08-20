using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt03Manha
{
    class Cliente
    {
        private string nome, cpf;
        private string[] consultas;

        public Cliente(string nome, string cpf, string[] consultas)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.consultas = consultas;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return cpf;
        }
        public void SetConsultas(string[] consultas)
        {
            this.consultas = consultas;
        }
        public string[] GetConsultas()
        {
            return consultas;
        }

    }
}
