using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6__while__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, contador = 1, total;
            Console.WriteLine("Digite dez números que o programa irá falar o quadrado dele");
            

           while (contador <=10)
            {
                Console.WriteLine("Digite o " + contador + "º número");
                n1 = Convert.ToInt32(Console.ReadLine());
                total = n1 * n1;
                Console.WriteLine(n1 + "² = " + total);
                contador++;
                Console.WriteLine("-------------------------------");
            }
            Console.ReadKey();
        }
    }
}
