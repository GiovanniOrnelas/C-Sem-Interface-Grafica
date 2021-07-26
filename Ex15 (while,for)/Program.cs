using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1000, novo_salario, aumento = 0.015, i= 2017, ano_atual;
            Console.WriteLine("Salário do filho do dono da empresa....");
            Console.WriteLine("Digite o ano de pesquisa, atual, do salário:");
            ano_atual = Double.Parse(Console.ReadLine());
            novo_salario = salario + aumento * salario;
            while (i <= ano_atual)
            {
                aumento *= 2;
                novo_salario += novo_salario * aumento;
                i++;
               
            }

            if (ano_atual >= 2016)
            {
                Console.WriteLine("Salário em " + ano_atual + " = R$ " + Math.Round(novo_salario, 2));
            }

            else
            {
                Console.WriteLine("Apenas anos acima de 2015");
            }
            
            Console.ReadKey();
        }
    
    }
}
