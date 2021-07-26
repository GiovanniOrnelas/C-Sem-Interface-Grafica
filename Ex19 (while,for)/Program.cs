using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1= 0, n2 = 0, proximo =0, i=1;

            Console.WriteLine("Digite o número de termos da série que deseja imprimir");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o 1º número com que você deseja começar");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número com que você deseja começar");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSérie de Ricci com " + n + " termos!");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            n -= 2;           

            while (i <= n)
            {
                proximo = n1 + n2;
                n1 = n2;
                n2 = proximo;
                Console.WriteLine(proximo);
                i++;
            }

            Console.ReadKey();
        }
    }
}
