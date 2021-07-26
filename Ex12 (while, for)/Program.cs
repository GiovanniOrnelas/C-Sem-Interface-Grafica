using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12__while__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, cont = 1, divisores;
            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());

            while (cont <= n1)
            {
               
                if (n1 % cont == 0)
                {
                    Console.WriteLine("Os número divisíveis por " + n1 + " são: " + cont);       
                }
                
                cont++;
            }
            
            Console.ReadKey();
        }
    }
}
