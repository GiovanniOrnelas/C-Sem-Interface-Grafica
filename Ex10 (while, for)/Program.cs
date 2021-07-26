using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10__while__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 1000;

            while (contador <= 2000)
            {
                
                if (contador % 11 == 5)
                {
                    Console.WriteLine(contador);
                }
                
                contador++;
            }
            
            Console.ReadKey();    
        }
    }
}
