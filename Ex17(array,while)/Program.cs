using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int contador = 0, resultado = 0;

            while (contador <= 9)
            {
                Console.WriteLine("Dê um valor para a posição [" + contador + "]");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            
            Console.Clear();
            contador = 0;
            
            Console.WriteLine("Os números das posições do vetor X os números dos valores do vetor!!!");
            Console.WriteLine();
            
            while (contador <= 9)
            {
                
                resultado = numeros[contador] * contador;
                Console.WriteLine("[" + contador + "] X " + numeros[contador] + " = " + resultado);
                contador++;
            }
            
            Console.ReadKey();
        }
    }
}
