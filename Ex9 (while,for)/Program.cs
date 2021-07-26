using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double f_i, f_f, c;
            Console.WriteLine("Digite uma temperatura em Firenhait (inicial)");
            f_i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma temperatura em Firenhait (final)");
            f_f = Convert.ToDouble(Console.ReadLine());
            
            if (f_i < f_f)
            {
                Console.WriteLine("o firenhait inicial precisa ser maior que o firenhait final!");
            }

            while (f_i >= f_f)
            {
                c = 5 * (f_i - 32) / 9;
                Console.WriteLine("A temperatura " + f_i + " é de : " + Math.Round(c, 2));
                f_i--;               
            }

            
            Console.ReadKey();
        }
    }
}
