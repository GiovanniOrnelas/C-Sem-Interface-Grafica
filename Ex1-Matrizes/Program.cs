using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];
            int linhas = 0, colunas=0;

            Console.WriteLine("Matriz de Números Inteiros, de 5x5: \n");
            Console.WriteLine("Leitura da Matriz...");
            
            while (linhas <= 4) // LINHAS
            {
                while (colunas <= 4)// COLUNAS
                {
                    Console.WriteLine("Digite matriz de [" + linhas + " , " + colunas + "]");
                    numeros[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    colunas++;
                }               
                linhas++;
                colunas = 0;
            }
            
            Console.Clear();
            Console.WriteLine("Impressão da matriz 5x5: \n");
            
            colunas = 0;
            linhas = 0;
            while (linhas <= 4) // LINHAS
            {              
                while (colunas <= 4)// COLUNAS
                {
                    Console.Write(numeros[linhas,colunas] + "\t");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
                colunas = 0;
            }
           
            Console.WriteLine("\nImpressão da matriz SEM diagonal principal: \n");
            colunas = 0;
            linhas = 0;

            while (linhas <= 4) // LINHAS
            {
                while (colunas <= 4)// COLUNAS
                {
                    if (linhas != colunas)
                    {
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

            Console.WriteLine("\nImpressão da matriz SEM diagonal secundária: \n");
            colunas = 0;
            linhas = 0;

            while (linhas <= 4) // LINHAS
            {
                while (colunas <= 4)// COLUNAS
                {
                    if (linhas + colunas != 4)
                    {
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


            Console.WriteLine("\nImpressão da matriz diagonal principal: \n");
            colunas = 0;
            linhas = 0;

            while (linhas <= 4) // LINHAS
            {
                while (colunas <= 4)// COLUNAS
                {
                    if (linhas == colunas)
                    {
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

            Console.WriteLine("\nImpressão da matriz diagonal secundária: \n");
            colunas = 0;
            linhas = 0;

            while (linhas <= 4) // LINHAS
            {
                while (colunas <= 4)// COLUNAS
                {
                    if (linhas + colunas == 4)
                    {
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
