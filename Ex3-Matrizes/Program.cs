using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 5];
            int[,] B = new int[5, 5];
            int linhas = 0, colunas = 0, soma_A_B = 0, contador = 0;

            while (contador <= 4)
            {
                while (contador <= 4{
                    Console.WriteLine("Digite o valor da coluna [" + colunas + "] da linha [" + linhas + "]");
                    A[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }

            linhas = 0;
            colunas = 0;
            

            while (contador <= 4)
            {
                while (contador <= 4)
                {
                    Console.WriteLine("Digite o valor da coluna [" + colunas + "] da linha [" + linhas + "]");
                    B[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }

            linhas = 0;
            colunas = 0;
            
            Console.WriteLine("Vetor Oringinal A:");
            while (contador <= 4)
            {
                while (contador <= 4)
                {

                    Console.WriteLine(A[linhas, colunas]);
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;

                linhas = 0;
                colunas = 0;
            }

            linhas = 0;
            colunas = 0;
            Console.WriteLine("Vetor Oringinal B:");
            while (contador <= 4)
            {
                while (contador <= 4)
                {

                    Console.WriteLine(B[linhas, colunas]);
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;

                linhas = 0;
                colunas = 0;
            }
            while (contador <= 4)
            {
                while (contador <= 4)
                {
                    soma_A_B = A[linhas, colunas] + B[linhas, colunas];
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }
            Console.WriteLine("Oi");
            Console.ReadKey();
        }
    }
}
