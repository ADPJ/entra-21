using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt06Manha
{
    class Novo : Imovel
    {
        public double Adicional { get; set; }

        public override void CalculaValor()
        {
            Preco += Adicional; // Preco = Preco + Adicional
        }
    }
}
