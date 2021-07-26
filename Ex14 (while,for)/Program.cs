using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i= 1, cont = 0;
            Console.WriteLine("Verificação de Número Primo (2 divisores, apenas)");
            Console.WriteLine("Digite um nº inteiro positivo: ");
            num = Int32.Parse(Console.ReadLine());
            while ( i <= num )
            {
                if (num % i == 0) { 
                    cont++; 
                } 
                i++;
            }

            if (cont == 2) { 
                 Console.WriteLine(num + " é PRIMO pois tem " + cont + " divisores");
            }
            else { 
                Console.WriteLine(num + " NÃO é PRIMO, pois tem " + cont + " divisores"); 
            }
            
            Console.ReadKey();
       
        }
    }
}
