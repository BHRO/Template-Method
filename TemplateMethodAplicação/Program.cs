using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodAplicação
{
    class Program
    {

        static void Main(string[] args)
        {
            int operador = 0;
            int sair = 1;
            string voltar = "\nPressione qualquer tecla para voltar";     
            
            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo ao Senac Café\n\nEscolha a sua bebida");
                Console.WriteLine("\nDigite 1 para Café\t\t\tDigite 2 para Chá\t\t\tDigite 3 para Chimarrão\n\n");
                operador = Convert.ToInt32(Console.ReadLine());
                  
            switch (operador)
            {
                case 1:

                    Cafe cafe = new Cafe();
                    Console.Clear();
                    cafe.Prerarar();
                    Console.Write(voltar); 
                    Console.ReadKey();

                break;

                case 2:

                    Cha cha = new Cha();
                    Console.Clear();
                    cha.Prerarar();
                    Console.Write(voltar);
                    Console.ReadKey();
                    
                break;

                case 3:

                    Chimarrao chimarrao = new Chimarrao();
                    Console.Clear();
                    chimarrao.Prerarar();
                    Console.Write(voltar);
                    Console.ReadKey();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("Produto inválido");
                    Console.Write(voltar);
                    Console.ReadKey();
                break;
            }

            } while (sair != 0);

            Console.ReadKey();

        }

        
    }
}
