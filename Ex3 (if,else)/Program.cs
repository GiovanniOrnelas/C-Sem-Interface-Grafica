using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento, salario_reajustado;
            string nome;
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu salário?");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario < 2500)
            {
                aumento = salario * 0.12;
                salario_reajustado = aumento + salario;
                Console.WriteLine(nome + " teve um aumento de : R$" + aumento + " e o seu salário é de: R$" + salario_reajustado);
            }
            else
            {
                aumento = salario * 0.05;
                salario_reajustado = aumento + salario;
                Console.WriteLine(nome + " teve um aumento de R$: " + aumento + " e o seu salário é de: R$" + salario_reajustado);
            }
            Console.ReadKey();
        }
    }
}
