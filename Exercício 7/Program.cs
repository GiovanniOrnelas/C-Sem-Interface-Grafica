using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Entrar com o dia e o mês de uma data e informar quantos dias se passaram desde o início do 
               ano. Esqueça a questão dos anos bissextos e considere sempre que um mês possui 30 dias
             */
            int dia, mes, dias;
            Console.WriteLine("Insira uma data com apenas dia e mês. (dd/mm)");
            Console.WriteLine("Insira o dia");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o mês");
            mes = Convert.ToInt32(Console.ReadLine());
            dias = (mes * 30) + dia;
            Console.WriteLine("Os dias desde o começo do ano são: " + dias + " dias");
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
