using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            int posicoes = 0, contador_impares = 0, contador_pares = 0, numero = 1;

            while (posicoes <= 5)
            {
                Console.WriteLine("Digite o " + numero + "º número");
                numeros[posicoes] = Convert.ToInt32(Console.ReadLine());
                posicoes++;
                numero++;
            }
            Console.WriteLine();
            posicoes = 0;
            
            while (posicoes <= 5)
            {
                if (numeros[posicoes] % 2 == 0)
                {
                    contador_pares++;
                    Console.WriteLine("Números pares :" + numeros[posicoes]);
                }

                else
                {
                    contador_impares++;
                    Console.WriteLine("Números ímpares :" + numeros[posicoes]);
                }
                posicoes++;
            }

     

            Console.WriteLine("\nDentre os números digitados, apenas " + contador_pares + " números são pares");
            Console.WriteLine("Dentre os números digitados, apenas " + contador_impares + " números são ímpares");
            Console.ReadKey();
        }
    }
}
