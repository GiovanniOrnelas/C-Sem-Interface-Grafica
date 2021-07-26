using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1, 0, 5, -2, -5, 7};
            int soma_A0_A1_A5 = 0, contador=0;
            Console.WriteLine("Vetor Tosco - pré-definido pelo usuário...\n ");

            Console.WriteLine("Impressão do Vetor: \n");
            soma_A0_A1_A5 = A[0] + A[1] + A[5];
            while (contador <= 5)
            {
                Console.Write(A[contador] + "\t");
                contador++;
            }
            Console.WriteLine("\n\n\nA soma das posições 0, 1 e 5 vale: " + soma_A0_A1_A5);
            Console.WriteLine("\nModificação na posição 4, ela valerá 100");
            A[4] = 100;
            Console.WriteLine("\nNovo vetor com modificação!!!");
            contador = 0;
            while (contador <= 5)
            {
                Console.Write(A[contador] + "\t");
                contador++;
            }
            Console.WriteLine("\n\n\nPressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
