using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            double[] pesos = new double[5];
            double[] alturas = new double[5];
            double[] imcs = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Digite o peso (em kg) da {i + 1}ª pessoa:");
                pesos[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite a altura (em metros) da {i + 1}ª pessoa:");
                alturas[i] = Convert.ToDouble(Console.ReadLine());


                imcs[i] = pesos[i] / (alturas[i] * alturas[i]);
            }


            Console.WriteLine("Resultados:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nome: {nomes[i]}, Peso: {pesos[i]}, Altura: {alturas[i]}, IMC: {imcs[i]:F2}");
            }

            Console.ReadKey();
        }
    }
}
