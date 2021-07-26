using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número ímpar ou par");
            
            int n1;

            Console.WriteLine("Digite o 1º número");
            n1 = Convert.ToInt32(Console.ReadLine());
            

            if (n1 % 2 == 0)
            {
                Console.WriteLine(n1 + " é número par");
            }
            else
            {
                Console.WriteLine(n1 + " é número ímpar");
            }
            Console.ReadKey();
        }
    }
}
