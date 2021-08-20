using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt06Manha
{
    class Velho : Imovel
    {
        public double Desconto { get; set; }

        public override void CalculaValor()
        {
            Preco -= Desconto; // Preco = Preco - Desconto
        }

    }
}
