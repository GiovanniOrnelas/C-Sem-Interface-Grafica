using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testando
{
    class Program
    {

        static  int dobro (int x)
        {
            return 2 * x;
            
        }

        static void Main(string[] args)
        {
            int num1, contador=1;
         

            while (contador <= 3)
            {
                Console.WriteLine("\n\nDigite um número");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDobro de " + num1 + " = " + dobro(num1));
                contador++;
            }

            Console.ReadKey();
        }
    }
}
