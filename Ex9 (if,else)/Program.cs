using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasto, venda, lucro;
            Console.WriteLine("Vendas de um produto");
            Console.WriteLine("Quanto você gastou no produto?");
            gasto = Convert.ToDouble(Console.ReadLine());
            if (gasto < 10) // 0 - 9,99 
            {
                lucro = gasto * 0.70;
                venda = lucro + gasto;
                Console.WriteLine("Fornecedor cobrou R$ " + gasto + ", e você obteve um lucro de : R$ " + (Math.Round(lucro, 2) + " encima do preço que você irá propor"));
            }

            if (gasto >= 10 && gasto < 30) // 10 - 29,99
            {
                lucro = gasto * 0.50;
                venda = lucro + gasto;
                Console.WriteLine("Fornecedor cobrou R$ " + gasto + ", e você obteve um lucro de : R$ " + (Math.Round(lucro,2) + " encima do preço que você irá propor"));
                }
            if (gasto >= 30 && gasto < 50) // 30 - 49,99
            {
                lucro = gasto * 0.40;
                venda = lucro + gasto;
                Console.WriteLine("Fornecedor cobrou R$ " + gasto + ", e você obteve um lucro de : R$ " + (Math.Round(lucro, 2) + " encima do preço que você irá propor"));
            }

            if (gasto >= 50) // 50 - ...
                {
                    lucro = gasto * 0.30;
                    venda = lucro + gasto;
                Console.WriteLine("Fornecedor cobrou R$ " + gasto + ", e você obteve um lucro de : R$ " + (Math.Round(lucro, 2) + " encima do preço que você irá propor"));
            }
                Console.ReadKey();
            }
        }
    }
