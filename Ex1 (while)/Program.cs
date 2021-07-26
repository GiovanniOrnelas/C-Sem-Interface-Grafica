using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1000;

            Console.WriteLine("Números divisíveis por 11 com resto 5 entre 1000 - 2000");
            
            while (contador <= 2000)
            {
                if (contador % 11 == 5)
                {
                    Console.WriteLine("Os número são: " + contador);
                }
                contador++;
            }

            Console.ReadKey();
        }
    }
}
