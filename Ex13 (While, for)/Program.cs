using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13__While__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, contador = 1, soma = 0;

            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());

            while (contador < n1)
            {
               
                if (n1 % contador == 0)
                {
                    soma += contador;
                }
                
                contador++;
            }

            if (soma == n1)
            {
                Console.WriteLine("Número PERFEITO");
            }

            else
            {
                Console.WriteLine("Número NÃO perfeito");
            }


            Console.ReadKey();
        }
    }
}
