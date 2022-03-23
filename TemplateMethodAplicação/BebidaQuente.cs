using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodAplicação
{
    abstract class BebidaQuente
    {

        public void Prerarar() // Esse é o Template Method, ele define a sequência de etapas a serem executadas.
        {
            this.EsquentarAgua(); //Passo 1
            this.Mistura();       // Passo 2 
            this.ColocarEmCopo(); // Passo 3

            if( this.TemCondimentos() == true){

            this.AddCondimentos();// Passo 4

            }

            Console.WriteLine("Valor a ser pago\nR$ "+GetPreco());
            
        }

        public void EsquentarAgua()  // Comportamento padrão da classe base, comum entre as classes concretas
        {

            Console.WriteLine("Esquentando água");
        
        }

        public abstract void Mistura(); // comportamento a ser definido pelas classes concretas

        public void ColocarEmCopo()  // Comportamento padrão da classe base, comum entre as classes concretas
        {
            Console.WriteLine("Colocando no copo");
        
        
        }

        public abstract void AddCondimentos(); // Comportamento a ser definido nas classes concretas

        public abstract double GetPreco();//Comportamento a ser definido nas classes concretas


        public virtual Boolean TemCondimentos() // Esse comportamento é um gancho, ele é um comportamento padrão
        {
            return false;
        }

       
        


    }
}
