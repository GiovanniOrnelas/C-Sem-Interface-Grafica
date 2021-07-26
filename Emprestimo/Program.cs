using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A prefeitura de Guarulhos abriu uma linha de crédito para os funcionários estatutários. O valor
            máximo da prestação não poderá ultrapassar 30% do salário bruto. Crie um algoritmo que permita entrar com o salário bruto e o valor da prestação, e informar se o empréstimo pode ou não ser concedido.*/

            double salario, prestacao, max_prest;
            Console.WriteLine("Qual é o seu salário bruto?");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual é o valor da prestação que você deseja pagar");
            prestacao = Convert.ToDouble(Console.ReadLine());
            max_prest = salario * 0.30;
            if (prestacao > max_prest)
            {
                Console.WriteLine("Empréstimo NÃO concedido, pois você deseja fazer um empréstimo maior que os 30% do seu salário!");
            }
            else
            {
                Console.WriteLine("Empréstimo de R$" + Math.Round(max_prest,2) + " - APROVADO com sucesso!!");
            }
            Console.ReadKey();
        }
    }
}
