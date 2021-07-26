using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0, mult_impar=1, soma_par=0, contador_par=0, contador_impar=0;

            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                contador++;
                if (numero % 2 == 0)
                {
                    contador_par++;
                    soma_par += numero;
                }
                else
                {
                    contador_impar++;
                    mult_impar *= numero;
                }

                Console.WriteLine("Digite um número");
                numero = Convert.ToInt32(Console.ReadLine());             
            }
            Console.WriteLine("A multiplicação dos números ímpares digitados é: " + mult_impar);
            Console.WriteLine("A soma dos números pares digitados é: " + soma_par);
            Console.ReadKey();

        }
    }
}
