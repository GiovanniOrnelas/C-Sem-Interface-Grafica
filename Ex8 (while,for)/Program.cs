using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 1, pol, total;
            Console.WriteLine("Polegadas em centímetros");
            Console.WriteLine("Digite quantas polegadas você quer converter em centímetros");
            pol = Convert.ToDouble(Console.ReadLine());

            while (contador <= pol){

                total = contador * 2.54;
                Console.WriteLine(contador + " Polegada : " + total);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
