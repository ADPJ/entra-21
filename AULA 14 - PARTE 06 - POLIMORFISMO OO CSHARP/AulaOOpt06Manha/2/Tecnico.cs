using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt06Manha
{
    class Tecnico : Assistente
    {
        public double Bonus { get; set; }

        public override void ExibeDados()
        {
            Console.WriteLine(Nome);
            Console.WriteLine("{0:c}",Salario + Bonus);
            Console.WriteLine(NumeroMatricula);
        }

    }
}
