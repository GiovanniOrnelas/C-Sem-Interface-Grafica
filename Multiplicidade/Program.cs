using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fator = 2, multiplicidade;

            Console.WriteLine("Decomposição de um número em fatores primos...");
            Console.WriteLine("Digite um número inteiro positivo");
            num = Convert.ToInt32(Console.ReadLine());
            
            while (num > 1)
            {
                multiplicidade = 0;

                while (num % fator == 0)
                {
                    multiplicidade++;
                    num = num / fator;
                }

                if (multiplicidade != 0)
                {
                    Console.WriteLine("Fator " + fator + " Multiplicidade: " + multiplicidade);
                }
                fator++;
            }
            Console.WriteLine("Digite alguma tecla para parar o programa...");
            Console.ReadKey();
        }
    }
}
