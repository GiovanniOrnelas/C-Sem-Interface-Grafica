using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Último_Ex__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contador_pares = 0, i;

            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                Console.WriteLine("\nDivisores de " + num);
                for (i=1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("\nDigite um número");
                num = Convert.ToInt32(Console.ReadLine());
                
                if (num % 2 == 0)
                {
                    contador_pares++;
                }
            }

            Console.WriteLine("Digite qualquer tecla para parar o programa...");
            Console.ReadKey();
        }
    }
}
