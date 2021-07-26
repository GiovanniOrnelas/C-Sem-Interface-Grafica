using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refazendo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, soma=0, media=0, quantidade = 0;

            Console.WriteLine("Digite um número acima de 0, e 0 caso deseje parar o programa ");
            n = Convert.ToDouble(Console.ReadLine());
            
            

            while (n > 0)
            {
                
                
                quantidade++;
                soma = n + soma;
                media = soma / quantidade;

                Console.WriteLine("Digite um número");
                n = Convert.ToDouble(Console.ReadLine());
            }

            if (n <= 0)
            {
                Console.WriteLine("\nPROGRAMA PAROU!!!");             
                Console.WriteLine("\nA soma de todos os números é de: " + soma);
                Console.WriteLine("A quantidade de números inseridos é de: " + quantidade);
                Console.WriteLine("A média é de: " + soma + " / " + quantidade + " = " + media);
            }
            

            
            Console.ReadKey();
        }
    }
}
