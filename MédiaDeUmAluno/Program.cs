using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MédiaDeUmAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcule uma média de um aluno, sabendo que 7 para cima ele está APROVADO.
            double n1, n2, total;
            Console.WriteLine("Determinando se um aluno foi APROVADO ou REPROVADO");
            Console.WriteLine("Digite a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            total = (n1 + n2) / 2;

            if (total >= 7)
            {
                Console.WriteLine("Você foi APROVADO com uma média de: " + total);
            }

            else
            {
                Console.WriteLine("Você foi REPROVADO com uma média de: " + total);
            }

            Console.WriteLine("Pressione qualquer tecla para parar o programa.");
            Console.ReadKey();
        }
    }
}
