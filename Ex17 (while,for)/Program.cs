using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {                
                    Console.WriteLine(n1 + " tem que ser menor que o " + n2);              
            }

            while (n1 <= n2)
            {                          
                Console.WriteLine(n1);            
                n1++;                  
            }

            
            
            

            Console.ReadKey();
        }
    }
}
