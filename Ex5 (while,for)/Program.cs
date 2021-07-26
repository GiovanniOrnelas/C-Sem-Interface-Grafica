using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, total;
            Console.WriteLine("Quadrado de 1 - 20");
            while (contador <= 20)
            {
                total = contador * contador;
                Console.WriteLine(contador + "²" + " = " + total);
                contador += 1;
            }
            Console.ReadKey();
        }
    }
}
