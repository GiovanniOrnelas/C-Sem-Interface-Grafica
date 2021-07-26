using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasto, total, desconto;
            Console.WriteLine("Quanto você gastou no produto?");
            gasto = Convert.ToDouble(Console.ReadLine());
            if (gasto < 50) // 0 até 49 - 5%
            {
                desconto = gasto * 0.05;
                total = gasto - desconto;
                Console.WriteLine("Você gastou R$" + gasto + " e ganhou 5% de desconto, ficando : R$" + Math.Round(total,2));
                if (gasto <= 80) // 0 até 80
                {
                    Console.WriteLine("Classificação: Barato");
                }
            }

            if (gasto >=50 && gasto <= 100) // 50 até 100 - 10%
            {
                desconto = gasto * 0.10;
                total = gasto - desconto;
                Console.WriteLine("Você gastou R$" + gasto + " e ganhou 10% de desconto, ficando : R$" + Math.Round(total, 2));
                
                if (gasto <= 80) // 0 até 80
                {
                    Console.WriteLine("Classificação: Barato");
                }

                if (gasto >80  && gasto <=100) // 81 ate 100
                {
                    Console.WriteLine("Classificação: Normal");
                }
            }

            if (gasto > 100) // 101 - ... - 15%
            {
                desconto = gasto * 0.15;
                total = gasto - desconto;
                Console.WriteLine("Você gastou R$" + gasto + " e ganhou 15% de desconto, ficando : R$" + Math.Round(total, 2));

                if (gasto >=101 && gasto <=199) // 101 - 199
                {
                    Console.WriteLine("Classificação: Caro");
                }

                if (gasto >= 200) // 200 - ...
                {
                    Console.WriteLine("Classificação: Muito caro");
                }
            }


            Console.ReadKey();
        }
    }
}
