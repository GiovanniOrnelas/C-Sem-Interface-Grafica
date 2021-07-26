using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new String[5];
            double[] precos = new double[5];
            int i, qtde_precos_menor_50 = 0, contador_precos_50_ate_100=0;
            double media_precos_maiores_que_100, contador_precos_maiores_que_100 = 0;
            double soma_precos_maiores_que_100=0;
            Console.WriteLine("Nomes e Preços de 5 Produtos...");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite nome[" + i + "]: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite preços[" + i + "]: ");
                precos[i] = Double.Parse(Console.ReadLine());
                Console.WriteLine();


                if (precos[i] < 50)
                {
                    qtde_precos_menor_50++;
                }

                else if (precos[i] < 100)
                {
                    contador_precos_50_ate_100++;
                }
                else
                {
                    contador_precos_maiores_que_100++;
                    soma_precos_maiores_que_100 += precos[i];
                }
            }
            Console.Clear();
            Console.WriteLine("Lista de Produtos - Preços Respectivos");
            Console.WriteLine();
            
            for (i = 0; i < 5; i++) {
                Console.WriteLine(nomes[i] + " - " + precos[i]);
            }
            
            Console.WriteLine();
            
            if (contador_precos_50_ate_100 > 0)
            {
                Console.WriteLine("Produtos entre R$50 e R$100");
                for (i=0; i <5; i++)
                {
                    if (precos[i] > 50 && precos [i] < 100)
                    {
                        Console.WriteLine(nomes[i] + " - " + precos[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Não há produtos entre R$50 e R$100!!!");
            }
            
            Console.WriteLine();
            
            if (contador_precos_maiores_que_100 > 0)
            {
                media_precos_maiores_que_100 = soma_precos_maiores_que_100 / contador_precos_maiores_que_100;
                Console.WriteLine("Média dos preços maiores que 100 = R$" + Math.Round(media_precos_maiores_que_100,2));
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Existem " + qtde_precos_menor_50 + " quantidades de produtos menores que R$50");            
            Console.WriteLine("\n\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
