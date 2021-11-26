using System;

namespace Projeto2021_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            do {
                Console.WriteLine("Bem-vindo ao Projeto 2021/2!\n");

                Console.WriteLine("Escolha uma das opções abaixo para");
                Console.WriteLine("realização de cálculos matemáricos.\n");
                Console.WriteLine("1 - SOMA");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - MULTIPLICAÇÃO");
                Console.WriteLine("4 - DIVISÃO");
                Console.WriteLine("5 - EXPONENCIAÇÃO");
                Console.WriteLine("6 - RADICIAÇÃO");
                Console.WriteLine("0 - SAIR");

                Console.Write("\nOpção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                DirecionaOpcao(opcao);
            } while (opcao != 0);
        }
        static void EsperaTecla()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static void DirecionaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    Exponenciacao();
                    break;
                case 6:
                    Radiciacao();
                    break;
                case 0:
                    Console.WriteLine("\nSaindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    EsperaTecla();
                    break;
            }
        }
        static void Somar()
        {
            Console.WriteLine("INTERFACE DE SOMA\n");

            Console.Write("Informe o primeiro valor: ");
            double valor01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo valor.: ");
            double valor02 = Convert.ToDouble(Console.ReadLine());

            double sum = valor01 + valor02;

            Console.Write($"{valor01} + {valor02} = {sum}\n");

            EsperaTecla();
        }
        static void Subtrair()
        {
            Console.WriteLine("INTERFACE DE SUBTRAÇÃO\n");

            Console.Write("Informe o primeiro valor: ");
            double valor01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo valor.: ");
            double valor02 = Convert.ToDouble(Console.ReadLine());

            double sub = valor01 - valor02;

            Console.Write($"{valor01} - {valor02} = {sub}\n");

            EsperaTecla();
        }
        static void Multiplicar()
        {
            Console.WriteLine("INTERFACE DE MULTIPLICAÇÃO\n");

            Console.Write("Informe o primeiro valor: ");
            double valor01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo valor.: ");
            double valor02 = Convert.ToDouble(Console.ReadLine());

            double mult = valor01 * valor02;

            Console.Write($"{valor01} * {valor02} = {mult}\n");

            EsperaTecla();
        }
        static void Dividir()
        {
            Console.WriteLine("INTERFACE DE DIVISÃO\n");

            Console.Write("Informe o dividendo: ");
            double dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o divisor..: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            double div = dividendo / divisor;

            Console.Write($"{dividendo} / {divisor} = {div:N3}\n");

            EsperaTecla();
        }
        static void Exponenciacao()
        {
            Console.WriteLine("INTERFACE DE EXPONENCIAÇÃO\n");

            Console.Write("Informe o valor da base....: ");
            double valorBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do expoente: ");
            double valorExpoente = Convert.ToDouble(Console.ReadLine());

            double pot = Math.Pow(valorBase, valorExpoente);

            Console.Write($"{valorBase} ^ {valorExpoente} = {pot}\n");

            EsperaTecla();
        }
        static void Radiciacao()
        {
            Console.WriteLine("A implementar...\n");

            EsperaTecla();
        }
    }
}