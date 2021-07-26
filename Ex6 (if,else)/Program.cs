using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, divisao, resto;
            Console.WriteLine("Digite um número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um outro número");
            b = Convert.ToInt32(Console.ReadLine());
            divisao = a / b;
            resto = a % b;
            if (b!=0)
            {
                Console.WriteLine("A divisão entre os números é de: " + divisao);
                Console.WriteLine("O resto da divisão entre os números é de: " + resto);
            }
            else
            {
                Console.WriteLine("Não se pode ter 0 no divisor");
            }
            Console.ReadKey();
        }
    }
}
