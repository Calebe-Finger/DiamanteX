namespace DiamanteXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();        //Limpa o console para a nova operação

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Diamante X");                                        //Cabeçalho com o nome do programa, 
                Console.WriteLine("----------------------------------");                // recebimento do valor do losango
                Console.WriteLine("Digite um valor impar inteiro:");                    // e opção de saída
                Console.WriteLine("S - Para Sair");
                Console.WriteLine("----------------------------------");
                string stgTamanho = Console.ReadLine();

                if (stgTamanho == "S" ||  stgTamanho == "s")            //Verifica se o uúário deseja sair da aplicação
                {
                    break;
                }

                if (!int.TryParse(Console.ReadLine(), out int tamanho))  //Verifica se valor informado pode ser transformado 
                {                                                      //em 'int', para validar que foi informado um número, inteiro.
                    Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");              
                    Console.WriteLine("Por favor, tente novamente");
                    Console.ReadLine();
                    continue;
                }

                tamanho = Convert.ToInt32(stgTamanho);

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número ímpar");         //Valida se o número é par
                    Console.WriteLine("Por favor, tente novamente");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("----------------------------------");        //Separa a introdução dos resultados

                int x = 1;      //Determina a quantidade de X que serão impressas na tela
                for (int espaco = (tamanho / 2) + 1; espaco != 0; espaco--)     //Determina a quantidade de espaços em cada linha
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

                int y = (tamanho - 2);      //Determina a quantidade de X que serão impressas na tela
                for (int espaco = 1; espaco != (tamanho / 2) + 1; espaco++)     //Determina a quantidade de espaços em cada linha
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
