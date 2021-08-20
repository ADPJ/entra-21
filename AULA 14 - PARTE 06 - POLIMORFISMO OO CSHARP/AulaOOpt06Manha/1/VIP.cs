using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt06Manha
{
    class VIP : Ingresso
    {
        public double ValorExtra { get; set; }

        public override void ImprimeValor()
        {
            Console.WriteLine(Valor + ValorExtra);
        }


    }
}
