using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 3];
            int[,] At =new int[3, 2];
            int linhas = 0, colunas = 0;

            while (linhas <= 1)
            {
                while (colunas <= 2)
                {
                    Console.WriteLine("Dê um valor para a coluna [" + colunas + "] da linhas [" + linhas +"]");
                    A[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    At[colunas, linhas] = A[linhas, colunas];
                    colunas++;
                }
                linhas++;
                colunas = 0;
            }
            Console.Clear();
            linhas = 0;
            colunas = 0;
            Console.WriteLine("Vetor Original:");
            while (linhas <= 1)
            {
                while (colunas <= 2)
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
            Console.WriteLine("\n\nVetor Trocado:");
            while (linhas <= 2)
            {
                while (colunas <= 1)
                {
                    Console.Write(At[linhas, colunas] + "\t");
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
