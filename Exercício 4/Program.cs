using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida 
               ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa 
               com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS*/
            int idade, dias;
            string nome;
            Console.WriteLine("Quantos dias você viveu?");
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem?");
            idade = Convert.ToInt32(Console.ReadLine());
            dias = idade * 365;
            Console.WriteLine(nome + " viveu " + dias + " dias");
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();

        }
    }
}
