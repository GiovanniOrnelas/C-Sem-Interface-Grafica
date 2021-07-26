using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado;
            Console.WriteLine("Divisão com dois números");
            Console.WriteLine("LEMBRANDO: NÃO PODE DAR 0!");
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToDouble(Console.ReadLine());
            resultado = n1 / n2;
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("NÃO PODE RESULTAR EM 0!");
            }
            else
            {
                Console.WriteLine("O resultado é de:" + Math.Round(resultado,2));
            }
            Console.WriteLine("Pressione alguma tecla para sair do programa!");
            Console.ReadKey();
        }
    }
}
