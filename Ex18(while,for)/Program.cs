using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, anterior = 0, atual = 1, proximo = 0, i =1;
            Console.WriteLine("Série de Fibonacci - ");
            Console.WriteLine("Digite quantos intervalos você deseja");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                i++;
                Console.WriteLine(atual);
               
                proximo = anterior + atual;
           
                anterior = atual;
             
                atual = proximo;
                proximo += atual;
                
            }

                Console.ReadKey();
        }
    }
}
