using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos_de_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, media =0, soma =0, cont = 0;

            Console.WriteLine("Digite um número acima de 0, ou 0 para baixo para parar o programa");
            n = Convert.ToDouble(Console.ReadLine());          

            while (n > 0)
            {
                if (n % 3 == 0)
                {
                    cont++; // conta quantas vezes o numero digitado é multiplo de 3
                    soma += n; // somando os números digitado de multiplo de 3
                }                
               
                Console.WriteLine("Digite um número acima de 0, ou 0 para baixo para parar o programa");
                n = Convert.ToDouble(Console.ReadLine());
                                
            }

            media = soma / cont; // media = soma dos números multiplos de 3 / quantidade dos números multiplos de 3, ou seja, soma dos números multiplos de 3 dividido pela quantidade de números existentes no programa que são multiplos de 3
            Console.WriteLine("Quantidade de multiplos de 3 :" + cont);
            Console.WriteLine("Média dos multiplos de 3: " + media);        
            Console.ReadKey();

        }
    }
}
