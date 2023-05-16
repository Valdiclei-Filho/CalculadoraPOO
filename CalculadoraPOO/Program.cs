using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraPOO
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            List<string> historico = new List<string>();
            while (true)
            {
                ConjuntoAritmetico conjunto = new ConjuntoAritmetico();

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
                {
                    conjunto.Historico(historico);
                    break;
                }

                Console.WriteLine("Digite o 1º valor");
                float valor1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2º valor");
                float valor2 = float.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case (int)Operacoes.Soma:
                        var result = conjunto.Somar(valor1, valor2);
                        historico.Add($"{valor1} + {valor2} = {result}");
                        Console.WriteLine(result);



                        break;
                    case (int)Operacoes.Subtracao:
                        Console.WriteLine(conjunto.Subtracao(valor1, valor2));
                        break;
                    case (int)Operacoes.Multiplicacao:
                        Console.WriteLine(conjunto.Multiplicacao(valor1, valor2));
                        break;
                    case (int)Operacoes.Divisao:
                        Console.WriteLine(conjunto.Divisao(valor1, valor2));
                        break;

                }

            }
        }

    }
}