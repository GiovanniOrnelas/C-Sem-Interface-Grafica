using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Funções_Métodos
{
    class Program
    {

       

        static void primo(int n1)
        {
            int contador = 1, contador_primo=0;
            
            while(contador <= n1) {
            
            if (n1 % contador == 0)
            {
                contador_primo++;
            }
                contador++;
            }

            if (contador_primo == 2)
            {
                Console.WriteLine("\n" + n1 + " é primo!");
            }
            else
            {
                Console.WriteLine("\n" + n1 + " NÃO é primo!");
            }
        }

        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Digite um número para saber se ele é primo ou não");
            num1 = Convert.ToInt32(Console.ReadLine());

            primo(num1);
            Console.ReadKey();
        }
    }
}
