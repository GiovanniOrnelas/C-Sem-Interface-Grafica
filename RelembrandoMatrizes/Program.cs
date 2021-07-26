using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelembrandoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 5];

            int linhas = 0, colunas = 0;

            while (linhas <= 1)
            {
                while(colunas <= 4)
                {
                    Console.WriteLine("Dê um valor para a coluna [" + colunas + "] da linhas [" + linhas + "]");
                    numeros[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }
            
            linhas = 0;
            colunas = 0;
            
            Console.WriteLine("Vetor Original:");
            
            while (linhas <= 1)
            {
                while (colunas <= 4)
                {
                    Console.Write(numeros[linhas,colunas] + "\t");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }

            linhas = 0;
            colunas = 0;

            Console.WriteLine("\n\nMatriz Diagonal Principal");

            while (linhas <= 1)
            {
                while (colunas <= 4)
                {
                    if (linhas == colunas) { 
                    Console.Write(numeros[linhas, colunas] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
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
