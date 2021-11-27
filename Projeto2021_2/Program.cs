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
            Console.WriteLine(" | █████████ Bem-vindo ao Projeto 2021/2! █████████ |");
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
            Console.WriteLine(" | 8 - MAIOR DIVISOR COMUM                          |");
            Console.WriteLine(" | 9 - PRÓXIMA PÁGINA                               |");
            Console.WriteLine(" | 0 - SAIR                                         |");
            Console.WriteLine(" +--------------------------------------------------+");
            Console.WriteLine(" | ██████████████████ PÁGINA 1/2 ██████████████████ |");
            Console.WriteLine(" +==================================================+");
        }
        static void SegundaPagina()
        {
            Console.Clear();

            Console.WriteLine(" +**************************************************+");
            Console.WriteLine(" | █████████ Bem-vindo ao Projeto 2021/2! █████████ |");
            Console.WriteLine(" +==================================================+");
            Console.WriteLine(" | Escolha uma das opções abaixo para realização de |");
            Console.WriteLine(" | cálculos matemáticos.                            |");
            Console.WriteLine(" +==================================================+");
            Console.WriteLine(" | 1 - ESTIMA PI                                    |");
            Console.WriteLine(" | 2 - ESTIMA EULER                                 |");
            Console.WriteLine(" |                                                  |");
            Console.WriteLine(" |                                                  |");
            Console.WriteLine(" |                                                  |");
            Console.WriteLine(" |                                                  |");
            Console.WriteLine(" |                                                  |");
            Console.WriteLine(" | 8 - SOBRE O PROJETO                              |");
            Console.WriteLine(" | 9 - VOLTAR                                       |");
            Console.WriteLine(" | 0 - SAIR                                         |");
            Console.WriteLine(" +--------------------------------------------------+");
            Console.WriteLine(" | ██████████████████ PÁGINA 2/2 ██████████████████ |");
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
                    MDC();
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
                    EstimaPI();
                    break;
                case 2:
                    EstimaEuler();
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
                case 8:
                    Creditos();
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
            Console.WriteLine(" | ████████████████████ SOMA ██████████████████████ |");
            Console.WriteLine(" +==================================================+\n");

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
            Console.WriteLine("  | ██████████████████ SUBTRAÇÃO ███████████████████ |");
            Console.WriteLine("  +==================================================+\n");

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
            Console.WriteLine("  | ████████████████ MULTIPLICAÇÃO █████████████████ |");
            Console.WriteLine("  +==================================================+\n");

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
            Console.WriteLine("  | ████████████████████ DIVISÃO ███████████████████ |");
            Console.WriteLine("  +==================================================+\n");

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
            Console.WriteLine("  | █████████████████ EXPONENCIAÇÃO ████████████████ |");
            Console.WriteLine("  +==================================================+\n");

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
            Console.WriteLine("  | █████████████████ RADICIAÇÃO ███████████████████ |");
            Console.WriteLine("  +==================================================+\n");


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
            Console.WriteLine("  | ███████████████████ FATORIAL ███████████████████ |");
            Console.WriteLine("  +==================================================+\n");

            int fat = 0, entrada = 0;

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

            fat = retornaFat(entrada);

            Console.WriteLine($"\n  {entrada}! = {fat}");

            EsperaTecla();
        }
        static int retornaFat(int entrada)
        {
            int fat = 1;
            
            if (entrada == 0)
            {
                return fat;
            }

            for (int i = 2; i <= entrada; i++)
            {
                fat *= i;
            }

            return fat;
        }
        static void MDC()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  | ███████ MÁXIMO DIVISOR COMUM (ITERATIVO) ███████ |");
            Console.WriteLine("  +==================================================+\n");
            
            int valor01 = 0, valor02 = 0;

            try
            {
                Console.Write("  Digite o 1º número (a): ");
                valor01 = Convert.ToInt32(Console.ReadLine());

                Console.Write("  Digite o 2º número (b): ");
                valor02 = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                TrataErro(ex);
                return;
            }

            int r = -1, a = valor01, b = valor02;

            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            int mdc = a;

            Console.WriteLine($"\n  MDC(a, b) = {mdc}");

            EsperaTecla();
        }
        static void EstimaPI()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  | ███████████████████ ESTIMA PI ██████████████████ |");
            Console.WriteLine("  +==================================================+\n");
            
            double pi = 0.0, aux = 3;

            Console.Write("\n  Quantas iterações? ");
            int iteracoes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= iteracoes - 1; i++)
            {
                if (i % 2 == 0)
                {
                    pi += 1 / aux;
                    aux += 2;
                }
                else
                {
                    pi -= 1 / aux;
                    aux += 2;
                }
            }

            pi = pi - 1;
            pi = pi * 4;
            pi = pi*(-1);

            Console.WriteLine($"\n  Estimativa: {pi:N6}");

            EsperaTecla();
        }
        static void EstimaEuler()
        {
            Console.Clear();

            Console.WriteLine("  +**************************************************+");
            Console.WriteLine("  | ██████████████████ ESTIMA EULER ████████████████ |");
            Console.WriteLine("  +==================================================+\n");
            
            double euler = 0;

            Console.Write("\n  Quantas iterações (<=33)? ");
            double iteracoes = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < iteracoes; i++)
            {
                euler += 1.0/(Double)retornaFat(i);
            }

            Console.WriteLine($"\n  Estimativa: {euler:N10}");

            EsperaTecla();
        }
        static void Nothing()
        {
            Console.Clear();
            
            Console.WriteLine("\n  There is nothing to see here, go away!!!");

            EsperaTecla();
        }
        static void Creditos()
        {
            Console.Clear();

            Console.WriteLine("  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄   Projetinho realizado para finalização");
            Console.WriteLine(" █────────▄▄▄▄▄▄────────█  do módulo de programação em .NET C#,");
            Console.WriteLine(" █──────█▀──────▀█──────█  alternando em versões.");
            Console.WriteLine(" █─────█─▄▀█──█▀▄─█─────█  ");
            Console.WriteLine(" █────▐▌──────────▐▌────█  user: vinicioslop");
            Console.WriteLine(" █────█▌▀▄──▄▄──▄▀▐█────█  link: LINK AQUI");
            Console.WriteLine(" █───▐██──▀▀──▀▀──██▌───█  ");
            Console.WriteLine(" █──▄████▄──▐▌──▄████▄──█  ");
            Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ");

            Console.WriteLine("\n");

            // A IMPLEMENTAR
            Console.Write("  Sair do programa? (S)im ou (N)ão: ");
            string opcao = Console.ReadLine().ToUpper();

            EsperaTecla();
        }
    }
}
