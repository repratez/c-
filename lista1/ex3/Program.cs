using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{

    class Program
    {
        static void Main(string[] args)
        {
            int pessoasAcimaPeso = 0;
            int pessoasAbaixoPeso = 0;
            int pessoasPesoNormal = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o peso (em kg) da {i + 1}ª pessoa:");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite a altura (em metros) da {i + 1}ª pessoa:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine($"IMC da {nome}: {imc:F2}");

                if (imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                    pessoasAbaixoPeso++;
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    Console.WriteLine("Peso normal");
                    pessoasPesoNormal++;
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                    pessoasAcimaPeso++;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Total de pessoas acima do peso: {pessoasAcimaPeso}");
            Console.WriteLine($"Total de pessoas abaixo do peso: {pessoasAbaixoPeso}");
            Console.WriteLine($"Total de pessoas com peso normal: {pessoasPesoNormal}");

       
            Console.ReadKey();
        }
    }
}
