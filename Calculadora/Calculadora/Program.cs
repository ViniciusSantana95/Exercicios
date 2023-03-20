using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double num1 = 0;
            double num2 = 0 ;
            double resultado;
            do
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("1 - soma");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - divisão");
                Console.WriteLine("4 - multiplicação");
                Console.WriteLine("5 - Resto da divisão");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("Selecione uma das opções acima");
                opcao = int.Parse(Console.ReadLine());

                if (opcao != 6) { 
                    Console.WriteLine("Informe o primeiro numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero");
                num2 = double.Parse(Console.ReadLine());
            }

                switch (opcao)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        Multiplicacao();
                        break;
                    case 5:
                        RestoDivisao();
                        break;
                    case 6:
                        Console.WriteLine("Você escolheu sair");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }



                void Soma()
                {
                    resultado = num1 + num2;
                    Console.WriteLine("Você escolheu soma");
                    Console.WriteLine("A soma de " + num1 + " + " + num2 + " é : " + resultado + "\n");
                }

                void Subtracao()
                {
                    resultado = num1 - num2;
                    Console.WriteLine("Você escolheu subtracao");
                    Console.WriteLine("A subtracao de " + num1 + " - " + num2 + " é : " + resultado + "\n");
                }

                void Divisao()
                {
                    resultado = num1 / num2;
                    Console.WriteLine("Você escolheu divisão");
                    Console.WriteLine("A divisão de " + num1 + " / " + num2 + " é : " + resultado + "\n");
                }

                void Multiplicacao()
                {
                    resultado = num1 * num2;
                    Console.WriteLine("Você escolheu multiplicação");
                    Console.WriteLine("A Multiplicação de " + num1 + " * " + num2 + " é : " + resultado + "\n");
                }

                void RestoDivisao()
                {
                    resultado = num1 % num2;
                    Console.WriteLine("Você escolheu resto da divisão");
                    Console.WriteLine("O resto da Divisão de " + num1 + " / " + num2 + " é : " + resultado + "\n");
                }


            } while (opcao != 6);

        }
    }
}