using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            int contador = 0;
            Console.WriteLine("Impressão do vetor...:\n");
            while (contador <= 9)
            {
                Console.WriteLine("Digite vet [" + contador + "]: ");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            Console.Clear();
            
            Console.WriteLine("Impressão do vetor na tela:\n");

            contador = 0;
            while (contador <= 9)
            {
                Console.WriteLine(numeros[contador] + "\t");
                contador++;
            }
            Console.WriteLine("Pressione alguma tecla para parar o programa...");
            Console.ReadKey();
        }
    }
}
