using System;

namespace Projeto2021_2
{
    class Program
    {        
        static void Main(string[] args)
        {
            int opcao = -1, pagina = 0;

            do
            {
                switch(pagina)
                {
                    case 0:
                        PrimeiraPagina();
                        break;
                    case 1:
                        SegundaPagina();
                        break;
                    default:
                        throw new Exception("Opção inválida!!!");
                        break;
                }

                try
                {
                    Console.Write("\n  Opção desejada: ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if(opcao == 9)
                    {
                        if (pagina == 1)
                        {
                            pagina = 0;
                            continue;
                        }

                        pagina = 1;
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    TrataErro(ex);
                    continue;
                }

                if (pagina == 0)
                {
                    DirecionaOpcaoPrimeiraPagina(opcao);
                }
                else
                {
                    DirecionaOpcaoSegundaPagina(opcao);
                }
            } while (opcao != 0);
        }
        static void TrataErro(Exception ex)
        {
            Console.WriteLine("\n  Ocorreu algum erro durante a execução! Tente novamente.");
            Console.WriteLine("  Erro: " + ex.Message);
            EsperaTecla();
        }
        static void PrimeiraPagina()
        {
            Console.Clear();

            Console.WriteLine(" +**************************************************+");
            Console.WriteLine(" |         Bem-vindo ao Projeto 2021/2!             |");
            Console.WriteLine(" +==================================================+");
            Console.WriteLine(" | Escolha uma das opções abaixo para realização de |");
            Console.WriteLine(" | cálculos matemáticos.                            |");
            Console.WriteLine(" +==================================================+");
            Console.WriteLine(" | 1 - SOMA                                         |");
            Console.WriteLine(" | 2 - SUBTRAÇÃO                                    |");
            Console.WriteLine(" | 3 - MULTIPLICAÇÃO                                |");
            Console.WriteLine(" | 4 - DIVISÃO                                      |");
            Console.WriteLine(" | 5 - EXPONENCIAÇÃO                                |");
            Console.WriteLine(" | 6 - RADICIAÇÃO                                   |");
            Console.WriteLine(" | 7 - FATORIAL                                     |");
            Console.WriteLine(" | 8 - ***NADA***                                   |");
            Console.WriteLine(" | 9 - PRÓXIMA PÁGINA                               |");
            Console.WriteLine(" | 0 - SAIR                                         |");
            Console.WriteLine(" +--------------------------------------------------+");
            Console.WriteLine(" | PÁGINA 1/2                                       |");
            Console.WriteLine(" +==================================================+");
        }
        static void SegundaPagina()
        {
            Console.Clear();

            Console.WriteLine(" +**************************************************+");
            Console.WriteLine(" |         Bem-vindo ao Projeto 2021/2!             |");
            Console.WriteLine(" +==================================================+");
            Console.WriteLine(" | Escolha uma das opções abaixo para realização de |");
            Console.WriteLine(" | cálculos matemáticos.                            |");
            Console.WriteLine(" +==================================================+");
            Console.WriteLine(" | 1 - SOBRE                                        |");
            Console.WriteLine(" | 2 - ***NADA***                                   |");
            Console.WriteLine(" | 3 - ***NADA***                                   |");
            Console.WriteLine(" | 4 - ***NADA***                                   |");
            Console.WriteLine(" | 5 - ***NADA***                                   |");
            Console.WriteLine(" | 6 - ***NADA***                                   |");
            Console.WriteLine(" | 7 - ***NADA***                                   |");
            Console.WriteLine(" | 8 - ***NADA***                                   |");
            Console.WriteLine(" | 9 - VOLTAR                                       |");
            Console.WriteLine(" | 0 - SAIR                                         |");
            Console.WriteLine(" +--------------------------------------------------+");
            Console.WriteLine(" | PÁGINA 2/2                                       |");
            Console.WriteLine(" +==================================================+");
        }
        static void DirecionaOpcaoPrimeiraPagina(int opcao)
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
                case 7:
                    Fatorial();
                    break;
                case 8:
                    Nothing();
                    break;
                case 0:
                    Console.WriteLine("\n  Saindo...");
                    break;
                default:
                    Console.WriteLine("  Opção inválida!");
                    EsperaTecla();
                    break;
            }
        }
        static void DirecionaOpcaoSegundaPagina(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Creditos();
                    break;
                case 2:
                    Nothing();
                    break;
                case 3:
                    Nothing();
                    break;
                case 4:
                    Nothing();
                    break;
                case 5:
                    Nothing();
                    break;
                case 6:
                    Nothing();
                    break;
                case 7:
                    Nothing();
                    break;
                case 0:
                    Console.WriteLine("\n  Saindo...");
                    break;
                default:
                    Console.WriteLine("\n  Opção inválida!");
                    EsperaTecla();
                    break;
            }
        }
        static void EsperaTecla()
        {
            Console.Write("\n  Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static void Somar()
        {
            Console.Clear();

            Console.WriteLine(" +**************************************************+");
            Console.WriteLine(" |              INTERFACE DE SOMA                   |");
            Console.WriteLine(" +--------------------------------------------------+\n");

            double valor01 = 0, valor02 = 0;

            try
            {
                Console.Write("  Informe o primeiro valor: ");
                valor01 = Convert.ToDouble(Console.ReadLine());

                Console.Write("  Informe o segundo valor.: ");
                valor02 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            double sum = valor01 + valor02;

            Console.Write($"\n  {valor01} + {valor02} = {sum}\n");

            EsperaTecla();
        }
        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  |            INTERFACE DE SUBTRAÇÃO                |");
            Console.WriteLine("  +--------------------------------------------------+\n");

            double valor01 = 0, valor02 = 0;

            try
            {
                Console.Write("  Informe o primeiro valor: ");
                valor01 = Convert.ToDouble(Console.ReadLine());

                Console.Write("  Informe o segundo valor.: ");
                valor02 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            double sub = valor01 - valor02;

            Console.Write($"\n  {valor01} - {valor02} = {sub}\n");

            EsperaTecla();
        }
        static void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  |          INTERFACE DE MULTIPLICAÇÃO              |");
            Console.WriteLine("  +--------------------------------------------------+\n");

            double valor01 = 0, valor02 = 0;

            try
            {
                Console.Write("  Informe o primeiro valor: ");
                valor01 = Convert.ToDouble(Console.ReadLine());

                Console.Write("  Informe o segundo valor.: ");
                valor02 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            double mult = valor01 * valor02;

            Console.Write($"\n  {valor01} * {valor02} = {mult}\n");

            EsperaTecla();
        }
        static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  |             INTERFACE DE DIVISÃO                 |");
            Console.WriteLine("  +--------------------------------------------------+\n");

            double dividendo = 0, divisor = 0;

            try
            {
                Console.Write("  Informe o dividendo: ");
                dividendo = Convert.ToDouble(Console.ReadLine());

                Console.Write("  Informe o divisor..: ");
                divisor = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            double div = dividendo / divisor;

            Console.Write($"\n  {dividendo} / {divisor} = {div:N3}\n");

            EsperaTecla();
        }
        static void Exponenciacao()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  |           INTERFACE DE EXPONENCIAÇÃO             |");
            Console.WriteLine("  +--------------------------------------------------+\n");

            double valorBase = 0, valorExpoente = 0;

            try
            {
                Console.Write("  Informe o valor da base....: ");
                valorBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("  Informe o valor do expoente: ");
                valorExpoente = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            double pot = Math.Pow(valorBase, valorExpoente);

            Console.Write($"\n  {valorBase} ^ {valorExpoente} = {pot}\n");

            EsperaTecla();
        }
        static void Radiciacao()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  |            INTERFACE DE RADICIAÇÃO               |");
            Console.WriteLine("  +--------------------------------------------------+\n");


            double radicando = 0, indice = 0;

            try
            {
                Console.Write("  Informe o radicando: ");
                radicando = Convert.ToDouble(Console.ReadLine());

                Console.Write("  Informe o índice...: ");
                indice = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            double resultado = Math.Pow(radicando, 1 / indice);

            Console.Write($"\n  O resultado é {resultado:N3}\n");

            EsperaTecla();
        }
        static void Fatorial()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  |            INTERFACE DE FATORIAL                 |");
            Console.WriteLine("  +--------------------------------------------------+\n");

            int fat = 1, entrada = 0;

            try
            {
                Console.Write("  Informe um valor inteiro: ");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada < 0)
                {
                    throw new Exception("Valor informado é negativo!");
                }
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return;
            }

            if (entrada == 0)
            {
                Console.WriteLine($"\n  {entrada}! = {fat + 1}");
                return;
            }

            for (int i = 2; i <= entrada; i++)
            {
                fat *= i;
            }

            Console.WriteLine($"\n  {entrada}! = {fat}");

            EsperaTecla();
        }
        static void Nothing()
        {
            Console.WriteLine("\n  There is nothing to see here, go away!!!");

            EsperaTecla();
        }
        static void Creditos()
        {
            Console.Clear();

            Console.WriteLine("  ────────▄▄▄▄▄▄────────   Projetinho realizado para finalização");
            Console.WriteLine("  ──────█▀──────▀█──────   do módulo de programação em .NET C#,");
            Console.WriteLine("  ─────█─▄▀█──█▀▄─█─────   alternando em versões.");
            Console.WriteLine("  ────▐▌──────────▐▌────");
            Console.WriteLine("  ────█▌▀▄──▄▄──▄▀▐█────   user: vinicioslop");
            Console.WriteLine("  ───▐██──▀▀──▀▀──██▌───   link: LINK AQUI");
            Console.WriteLine("  ──▄████▄──▐▌──▄████▄──");
            Console.WriteLine("\n");

            // A IMPLEMENTAR
            Console.Write("  Sair do programa? (S)im ou (N)ão: ");
            string opcao = Console.ReadLine().ToUpper();

            EsperaTecla();
        }
    }
}
