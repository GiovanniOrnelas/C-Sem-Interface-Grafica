using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];
            int[] B = new int[6];
            int contador = 0, soma=0, sub=0, cont=1;

            while (contador <= 5)
            {

                Console.WriteLine("Digite o " + cont + "º número do vetor A");
                A[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o " + cont + "º número do vetor B");
                B[contador] = Convert.ToInt32(Console.ReadLine());
                
                soma = A[contador] + B[contador];
                sub = A[contador] - B[contador];
                

                Console.WriteLine();
                Console.WriteLine("A " + cont + "º soma dos vetores é de: " + soma);
                Console.WriteLine("A " + cont + "º subtração dos vetores é de: " + sub);
                Console.WriteLine();
                cont++;
                contador++;
            }
            Console.ReadKey();
            
        }
    }
}
