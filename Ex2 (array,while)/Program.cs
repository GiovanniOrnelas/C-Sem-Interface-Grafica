using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            int contador = 0, contador_impar=0, contador_par =0;

            while (contador <= 9)
            {

                Console.WriteLine("\nDigite a [" + contador + "] posição do vetor.");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            Console.Clear();
            contador = 0;
            while (contador <= 9)
            {
                if (numeros[contador] < 0)
                {
                    Console.WriteLine("A posição " + contador + " precisa ser número positivo.");
                }

                else if (numeros[contador] == 0)
                {
                    Console.WriteLine("Você digitou 0 nas posições " + contador + ", sendo um número neutro.");
                }

                else if (numeros[contador] % 2 == 0)
                {
                    contador_par++;
                    Console.WriteLine("Os números " + numeros[contador] + " digitado é um número par.");
                }
                else
                {
                    contador_impar++;
                    Console.WriteLine("Os números " + numeros[contador] + " digitado é um número ímpar.");
                }
                contador++;
            }

            Console.WriteLine("Pressione algum tecla para parar o programa...");
            Console.ReadKey();

        }
    }
}
