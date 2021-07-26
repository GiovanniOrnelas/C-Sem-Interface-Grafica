using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a 
            cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber 
            quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de 
            poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com 
            base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular 
            os dados solicitados. */
            double pao, pao_total, broa, broa_total, economia, total;
            Console.WriteLine("Padaria Hotpão");
            Console.WriteLine("Quantos pães você vendeu hoje?");
            pao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantas broas você vendeu hoje?");
            broa = Convert.ToDouble(Console.ReadLine());
            pao_total = pao * 0.12;
            broa_total = broa * 1.50;
            total = pao_total + broa_total;
            economia = total / 0.10;
            Console.WriteLine("Você vendeu " + pao + " pães hoje e " + broa + " broas hoje");
            Console.WriteLine("Você obteve um lucro de $" + Math.Round(total,2) + " nas vendas de hoje");
            Console.WriteLine("Você deve guardar " + economia + " em sua poupança");
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
