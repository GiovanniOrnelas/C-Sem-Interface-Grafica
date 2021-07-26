using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[8];
            int contador = 0;

            while (contador <= 7)
            {
                Console.WriteLine("Digite o valor da posição [" + contador + "]");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            
            Console.WriteLine();
            contador = 7;
            while (contador >= 0)
            {             
                Console.WriteLine(numeros[contador]);
                contador--;
            }
            Console.ReadKey();
        }
    }
}
