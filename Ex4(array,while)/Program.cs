using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sal = new double[8];
            double[] sal_reajustado = new double[8];
            int i;
            Console.WriteLine("Salários de 8 funcionários - Reajuste de 12%");
            Console.WriteLine("Leitura dos salários: ");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite sal[" + i + "]: ");
                sal[i] = Double.Parse(Console.ReadLine());
                sal_reajustado[i] = 1.12 * sal[i];//Reajuste de 12% em sal[i]
            }
            Console.Clear();
            Console.WriteLine("Salários Anteriores: \n\n");
            for (i = 0; i < 8; i++) { Console.WriteLine("R$ " + Math.Round(sal[i], 2)); }
            Console.WriteLine("\n\nSalários Reajustados em 12%: \n");
            for (i = 0; i < 8; i++) { Console.WriteLine("R$ " + Math.Round(sal_reajustado[i], 2)); }
            Console.WriteLine("\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
