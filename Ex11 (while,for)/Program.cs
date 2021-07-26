using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, n, i;
            Console.WriteLine("Soma de n Frações simples, do tipo 1 + 1/2 + 1/3 + ... + 1/n");
            Console.WriteLine("Digite o nº de frações desejado: ");
            n = Double.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++) { 
            soma += 1 / i; 
            } 
            Console.WriteLine("A soma de " + n + " frações, vale: " + Math.Round(soma, 2));
            Console.ReadKey();
        
        }
    }
}
