using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodAplicação
{
    class Cafe : BebidaQuente
    {


        public override void Mistura() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            Console.WriteLine("Moendo Café");
        }

        public override double GetPreco() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            return 4.50;
        }
     
        public override bool TemCondimentos() //Esse é o método opcional. Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
                                                
        {
            return true;
        }

        public override void AddCondimentos() //Estamos definindo o comportamento com polimorfismo, sobrescrevendo o comportamento da classe base;
        {
            Console.WriteLine("Adicionando açucar");
        }

       

       
    }
}
