using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[7];
            int posicoes = 0, loppins=1, contador_mult2=0, contador_mult3=0,contador_mult2e3=0;

            while (posicoes <= 6)
            {
                Console.WriteLine("Digite o " + loppins + "º número");
                numeros[posicoes] = Convert.ToInt32(Console.ReadLine());
                loppins++;
                posicoes++;
            }

            posicoes = 0;
            Console.WriteLine();
            while (posicoes <= 6)
            {

                if (numeros[posicoes] % 2 == 0 && numeros[posicoes] % 3 == 0)
                {
                    contador_mult2e3++;
                    Console.WriteLine("Os multiplos de 2 e de 3 são: " + numeros[posicoes]);
                }

                if (numeros[posicoes] % 2 == 0)
                {
                    contador_mult2++;
                    Console.WriteLine("Os multiplos de 2 são: " + numeros[posicoes]);
                }


                if (numeros[posicoes] % 3 == 0)
                {
                    contador_mult3++;
                    Console.WriteLine("Os multiplos de 3 são: " + numeros[posicoes]);
                }
                
                posicoes++;
            }
            
            Console.WriteLine("Existem " + contador_mult2 + " números multiplos de 2");
            Console.WriteLine("Existem " + contador_mult3 + " números multiplos de 3");
            Console.WriteLine("Existem " + contador_mult2e3 + " números multiplos de 2 e 3");
            Console.ReadKey();
        }
    }
}
