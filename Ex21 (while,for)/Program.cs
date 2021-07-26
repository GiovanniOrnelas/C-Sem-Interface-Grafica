using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade=0, contador = 1, media_idades=0, contador_maior_idade=0, contador_menor_idade =0, porc_maiores=0, porc_menores=0, contador_mulheres_maior_idade =0, porc_mulheres_maior_idade =0;
            char sexo;
            while (contador <= 6)
            {
                Console.WriteLine("Digite sua idade");
                idade = Convert.ToDouble(Console.ReadLine());
                media_idades += idade;
                if (idade >= 18)
                {
                    contador_maior_idade++;
                }
                else if (idade <18)
                {
                    contador_menor_idade++;
                }
                Console.WriteLine("Digite o seu sexo: M/F");
                sexo = Convert.ToChar(Console.ReadLine());

                if (idade >= 18 && (sexo == 'F' || sexo == 'f'))
                {
                    contador_mulheres_maior_idade++;
                }

                contador++;

            }

            Console.Clear();
            media_idades /= 6;
            porc_maiores = (100 * contador_maior_idade) / 6;
            porc_menores = (100 * contador_menor_idade) / 6;
            porc_mulheres_maior_idade = (100 * contador_mulheres_maior_idade) / 6   ;
            Console.WriteLine("Média das idades digitadas: " + Math.Round(media_idades,2));
            Console.WriteLine("Porcentagem de maiores de idades: " + Math.Round(porc_maiores,2) + "%");
            Console.WriteLine("Porcentagem de menores de idades: " + Math.Round(porc_menores,2) + "%");
            Console.WriteLine("Porcentagem de mulheres maiores de idade: " + Math.Round(porc_mulheres_maior_idade, 2) + "%");
            Console.WriteLine("Digite alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
