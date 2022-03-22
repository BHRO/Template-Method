using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodAplicação
{
    class Cha : BebidaQuente
    {

        public override void Mistura() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            Console.WriteLine("Preparando infusão");
        }

        public override double GetPreco() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            return 9.00;
        }

        public override void AddCondimentos() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            Console.WriteLine("Adicionando Açucar");
        }

        
        
       
    }
}
