using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[7];
           

            int x, numeracao = 1, contador=0, resultado;

            Console.WriteLine("Digite o valor de X");
            x = Convert.ToInt32(Console.ReadLine());

            while (contador <= 6)
            {
                Console.WriteLine("Digite o " + numeracao + "º número");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;
                numeracao++;
            }
            Console.Clear();
            Console.WriteLine();           
            contador = 0;
            numeracao = 0;
           
            while (contador <= 6)
            {
                resultado = numeros[contador] * x;
                Console.WriteLine(x + " X " + numeros[contador] + " = " + resultado);
                Console.WriteLine();
                contador++;
                numeracao++;
            }
           
            Console.ReadKey();
        }
    }
}
