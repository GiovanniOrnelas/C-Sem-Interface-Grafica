using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 2;
            Console.WriteLine("Algoritmo que mostra os números pares de 0 - 100");
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador += 2;
            }
            Console.ReadKey();
        }
    }
}
