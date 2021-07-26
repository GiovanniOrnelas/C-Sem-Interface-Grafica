using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            // fazer uma divisão com dois números, e fazer uma validação que não pode resultar em 0.
            double n1, n2, resultado;
            Console.WriteLine("Criando um projeto com uma divisão de dois números.");
            Console.WriteLine("Escreva o primeiro número para a divisão");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número para a divisão");
            n2 = Convert.ToDouble(Console.ReadLine());
            resultado = n1 / n2;
            if (n1 == 0 || n2== 0)
            {
                Console.WriteLine("Não pode resultar em 0");
            }

            else
            {
                Console.WriteLine("O resultado é de:" + Math.Round(resultado,2));
            }

            Console.WriteLine("Pressione qualquer tecla para por fim ao programa!");
            Console.ReadKey();
        }
    }
}
