using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static string nome;
        static double valor;
        static string formaPagamento;
        static double valorFinal;
        public static void Main(string[] args)
        {
            int op;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nome do Produto");
                Console.WriteLine("2. Valor do Produto");
                Console.WriteLine("3. Forma de Pagamento");
                Console.WriteLine("4. Mostrar Dados da Compra");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        LerNomeProduto();
                        Console.Clear();
                        break;
                    case 2:
                        ValorProd();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        FormaPG();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        MostrarDadosCompra();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }

            } while (op != 5);
        }

        static void LerNomeProduto()
        {
            Console.WriteLine("Informe o nome do produto:");
            nome = Console.ReadLine();
        }

        static void ValorProd()
        {
            Console.WriteLine("Informe o valor do produto:");
            valor = double.Parse(Console.ReadLine());
        }

        static void FormaPG()
        {
            int opc;

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1. A vista no dinheiro");
            Console.WriteLine("2. PIX");
            Console.WriteLine("3. Parcelado");
            Console.Write("Opção: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    formaPagamento = "A vista no dinheiro";
                    PagarAVista(valor);
                    break;
                case 2:
                    formaPagamento = "PIX";
                    PagarComPIX(valor);
                    break;
                case 3:
                    formaPagamento = "Parcelado";
                    PagarParcelado(valor);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }

        static void PagarAVista(double valorCompra)
        {
            Console.WriteLine("Você escolheu pagar à vista no dinheiro.");
            double valorComDesconto = valorCompra * 0.9;
            valorFinal = valorComDesconto;
            Console.WriteLine("Valor com desconto: R$" + valorComDesconto);
        }

        static void PagarComPIX(double preco)
        {
            Console.WriteLine("Você escolheu pagar com PIX.");
            Console.WriteLine("A chave PIX: 20986971");
            Console.WriteLine("Valor: R$" + preco);
            valorFinal = preco;
        }

        static void PagarParcelado(double valorparc)
        {
            double quant;
            Console.WriteLine("Informe o numero de parcelas:");
            int parcelas = int.Parse(Console.ReadLine());
            quant = valorparc / parcelas;

            Console.WriteLine($"Valor total da compra: R${valorparc}");
            Console.WriteLine($"Número de parcelas: {parcelas}");
            Console.WriteLine($"Valor de cada parcela: R${quant}");
            valorFinal = valorparc;

        }

        static void MostrarDadosCompra()
        {
            Console.Clear();
            Console.WriteLine("Nome do Produto: " + nome);
            Console.WriteLine("Valor do Produto: R$" + valor);
            Console.WriteLine("Forma de Pagamento: " + formaPagamento);
            Console.WriteLine("Valor Final: R$" + valorFinal);
            Console.ReadKey();
        }
    }
}
