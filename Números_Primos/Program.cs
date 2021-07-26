using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contador = 1, contador_primos=0, divisor=1, contador_divisor =0;
            Console.WriteLine("Digite dez números - Quais deles são primos");

            while (contador <= 10)
            {
                
                Console.WriteLine("Digite o " + contador + "º número");
                num = Convert.ToInt32(Console.ReadLine());
                // as 2 instruções acima lêem 10 números

                contador_divisor = 0;
                // divisores de cada num não lidos
                while (divisor <= num)
                {
                    if (num % divisor == 0) // num = 5 divisor = 1. Ele vai pegar o número digitado e vai fazer as divisões que sobram 0 e vai armazenar dentro da var "contador_divisor" quantos dos números digitados são divisíveis e que sobram 0 de resto.
                    {
                        contador_divisor++;
                    }
                    divisor++;
                }

                if (contador_divisor == 2) // se dentre todos esses números que dividem por tal número e sobram 0 de resto, pegue apenas os número que tem apenas dois divisores com resto 0 e jogue dentro da var "contador_primos" a quantidade de números que tem apenas 2 divisões e some +1 nela.
                {
                    contador_primos++;
                }

                contador++;

            }
            
            Console.WriteLine("Dentre os números digitados, apenas " + contador_primos + " são primos");
            Console.ReadKey();
        }
    }
}
