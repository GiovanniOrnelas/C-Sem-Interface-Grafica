using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            Console.WriteLine("Algoritmo que mostra os números inteiros de 1 - 100");
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador += 1;
            }
            Console.ReadKey();
        }
    }
}
