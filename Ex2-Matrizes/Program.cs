using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // MATRIZ TRIANGULAR SUPERIOR i<j
            // MATRIZ TRIANGULAR INFERIOR i>j

            int[,] numeros = new int[5, 5];
            int coluna = 0, linha = 0;

            while (linha <= 4)
            {
                while (coluna <= 4)
                {
                    Console.WriteLine("Digite o valor da coluna [" + coluna + "] da linha [" + linha +"]");
                    numeros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    coluna++;
                }
                
                linha++;
                coluna = 0;
            }
            Console.Clear();
            coluna = 0;
            linha = 0;
            
            Console.WriteLine("O fator original: ");

            while (linha <= 4)
            {
                while (coluna <= 4)
                {
                    Console.Write(numeros[linha, coluna] + "\t");
                    coluna++;
                }
                Console.WriteLine();
                linha++;
                coluna = 0;
            }

            coluna = 0;
            linha = 0;
            
            Console.WriteLine("Matriz triangular superior: ");

            while (linha <= 4)
            {
                while (coluna <= 4)
                {
                    if (linha < coluna)
                    {
                        Console.Write(numeros[linha, coluna] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    coluna++;
                }
                Console.WriteLine();
                linha++;
                coluna = 0;
            }

            coluna = 0;
            linha = 0;
            
            Console.WriteLine("Matriz triangular inferior: ");

            while (linha <= 4)
            {
                while (coluna <= 4)
                {
                    if (linha > coluna)
                    {
                        Console.Write(numeros[linha, coluna] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    coluna++;
                }
                Console.WriteLine();
                linha++;
                coluna = 0;
            }

            Console.ReadKey();
        }
    }
}
