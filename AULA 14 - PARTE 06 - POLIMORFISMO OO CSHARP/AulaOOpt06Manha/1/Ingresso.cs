using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt06Manha
{
    class Ingresso
    {
        public double Valor { get; set; }
        public string Dono { get; set; }
        public virtual void ImprimeValor()
        {
            Console.WriteLine(Valor);
        }
    }
}
