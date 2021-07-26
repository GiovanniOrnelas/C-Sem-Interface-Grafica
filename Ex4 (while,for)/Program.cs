using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 5;
            Console.WriteLine("Múltiplos de 5");
            while (contador <=600)
            {
                Console.WriteLine(contador);
                contador += 5;
            }
            Console.ReadKey();
        }
    }
}
