using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Matrizess
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 5];
            int[,] B = new int[5, 5];
            int linhas = 0, colunas = 0, soma_A_B = 0, sub_A_B=0;

            while (linhas <= 4)
            {
                while (colunas <= 4){
                    
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

            while (linhas <= 4)
            {
                while (colunas <= 4)
                {
                    Console.WriteLine("Digite o valor da coluna [" + colunas + "] da linha [" + linhas + "]");
                    B[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }
            Console.Clear();
            linhas = 0;
            colunas = 0;

            Console.WriteLine("Vetor Oringinal A:");
            while (linhas <= 4)
            {
                while (colunas <= 4)
                {

                    Console.Write(A[linhas, colunas] + "\t");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;

            }

            linhas = 0;
            colunas = 0;
            
            Console.WriteLine("\nVetor Oringinal B:");
            while (linhas <= 4)
            {
                while (colunas <= 4)
                {

                    Console.Write(B[linhas, colunas] + "\t");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;

            }

            linhas = 0;
            colunas = 0;

            Console.WriteLine("\nVetor com SOMA de A e B");
            while (linhas <= 4)
            {
                while (colunas <= 4)
                {
                    soma_A_B = A[linhas, colunas] + B[linhas, colunas];
                    Console.Write(soma_A_B + "\t");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }

            linhas = 0;
            colunas = 0;

            Console.WriteLine("\nVetor com SUBTRAÇÃO de A e B");
            while (linhas <= 4)
            {
                while (colunas <= 4)
                {
                    sub_A_B = A[linhas, colunas] - B[linhas, colunas];
                    Console.Write(sub_A_B + "\t");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }
            
            Console.ReadKey();
        }
    }
}
