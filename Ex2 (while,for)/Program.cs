using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 100;
            Console.WriteLine("Algoritmo que conta de 100 até 1");
            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador -= 1;
            }
            Console.ReadKey();
        }
    }
}
