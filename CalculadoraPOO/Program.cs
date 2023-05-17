using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraPOO
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            CalculadoraEntidade calculadora = new CalculadoraEntidade();

            while (true)
            {

                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");
                Console.WriteLine("5 - Historico");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                    break;

                else if (opcao == 5)
                    calculadora.VerHistorico();

                else
                {
                    Console.WriteLine("Digite o 1º valor");
                    float valor1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o 2º valor");
                    float valor2 = float.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case (int)OperacaoMatematica.Soma:
                            var result = calculadora.Somar(valor1, valor2);
                            Console.WriteLine(result);
                            break;

                        case (int)OperacaoMatematica.Subtracao:
                            Console.WriteLine(calculadora.Subtracao(valor1, valor2));
                            break;

                        case (int)OperacaoMatematica.Multiplicacao:
                            Console.WriteLine(calculadora.Multiplicacao(valor1, valor2));
                            break;

                        case (int)OperacaoMatematica.Divisao:
                            Console.WriteLine(calculadora.Divisao(valor1, valor2));
                            break;
                    }
                }
            }
        }
    }
}