namespace DiamanteXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Diamante X");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Digite um valor impar inteiro:");
                Console.WriteLine("S - Para Sair");
                Console.WriteLine("----------------------------------");
                string stgTamanho = Console.ReadLine();

                if (stgTamanho == "S" ||  stgTamanho == "s")
                {
                    break;
                }

                if (!int.TryParse(Console.ReadLine(), out int tamanho))
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
                    Console.WriteLine("Por favor, tente novamente");
                    Console.ReadLine();
                    continue;
                }

                tamanho = Convert.ToInt32(stgTamanho);

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número ímpar");
                    Console.WriteLine("Por favor, tente novamente");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("----------------------------------");

                int x = 1;
                for (int espaco = (tamanho / 2) + 1; espaco != 0; espaco--)
                {
                    for (int cont = 0; cont < (espaco - 1); cont++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j != x; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine("");
                    x = x + 2;
                }

                int y = (tamanho - 2);
                for (int espaco = 1; espaco != (tamanho / 2) + 1; espaco++)
                {
                    for (int cont = 0; cont != espaco; cont++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j != y; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine("");
                    y = y - 2;
                }
                Console.ReadLine();
            }
        }
    }
}
