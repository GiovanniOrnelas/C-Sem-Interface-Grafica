using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compra de um carro");
            double custo_fabrica, custo_total, porc_distribuidor, imposto;
            Console.WriteLine("Qual foi o valor de fábrica?");
            custo_fabrica = Convert.ToDouble(Console.ReadLine());
            
            if (custo_fabrica < 33000.00)
            {
                porc_distribuidor = custo_fabrica * 0.05;
                custo_total = porc_distribuidor + custo_fabrica;
                Console.WriteLine("O preço total do carro é de : R$" + Math.Round(custo_total,2));
                //Console.WriteLine("até 11,999,99 mil");
            }

            if (custo_fabrica >= 33000.00 && custo_fabrica <= 66000.00)
            {
                porc_distribuidor = custo_fabrica * 0.10;
                imposto = custo_fabrica * 0.15;
                custo_total = porc_distribuidor + custo_fabrica + imposto;
                Console.WriteLine("O preço total do carro é de : R$" + Math.Round(custo_total, 2));
                //Console.WriteLine("12mil até 25.000,00 ");
            }

            if (custo_fabrica > 66000.00)
            {
                porc_distribuidor = custo_fabrica * 0.15;
                imposto = custo_fabrica * 0.20;
                custo_total = porc_distribuidor + custo_fabrica + imposto;
                Console.WriteLine("O preço total do carro é de : R$" + Math.Round(custo_total, 2));
                //Console.WriteLine("25.000,01 até ... ");
            }

            Console.ReadKey();
        }
    }
}
