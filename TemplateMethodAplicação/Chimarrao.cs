using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodAplicação
{
    class Chimarrao : BebidaQuente
    {
        public override void AddCondimentos() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            Console.WriteLine("Adicionando frutas e ervas exóticas"); 
        }

        public override double GetPreco() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            return 12.50;
        }

        public override void Mistura() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            Console.WriteLine("Preparando Erva Mate");
        }
    }
}
