using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7__while__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, total;
            while (contador <= 200)
            {
                total = contador + contador;            
                Console.WriteLine(contador + " + " + contador + " = " + total );
                contador++;
            }
            Console.ReadKey();
        }
    }
}
