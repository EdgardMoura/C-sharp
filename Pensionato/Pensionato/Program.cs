using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            QuartosAlugados[] vect = new QuartosAlugados[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                
                Console.Write("E-mail: ");
                string mail = Console.ReadLine();
                
                Console.Write("Quarto: ");
                int bedroom = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[bedroom] = new QuartosAlugados (name, mail, bedroom );
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}

    

