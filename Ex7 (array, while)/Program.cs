using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7__array__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador_de_30 = 0;
            int[] vetor = new int[15];
            Console.WriteLine("Vetor de 15 elementos - ocorrências do número 30");
            Console.WriteLine("LEITURA DO VETOR...");
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] == 30) { contador_de_30++; }
            }
            Console.Clear();
            Console.WriteLine("Vetor Original: ");
            for (i = 0; i < 15; i++) { Console.Write(vetor[i] + "\t"); }
            if (contador_de_30 > 0)
            {
                Console.Write("\n\nO número 30 aparece " + contador_de_30 + " vezes no vetor,");
                Console.WriteLine(" nas posições: ");
                for (i = 0; i < 15; i++)
                {
                    if (vetor[i] == 30) { Console.Write(i + "\t"); }
                }
            }
            else { Console.WriteLine("\n\nNão foi digitado o número 30 no vetor!"); }
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
