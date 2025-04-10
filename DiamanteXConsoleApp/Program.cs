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
                Console.WriteLine("----------------------------------");
                int tamanho = Convert.ToInt32(Console.ReadLine());
                string stgTamaho = tamanho.ToString();

                if (stgTamaho.Contains(".") || stgTamaho.Contains(","))
                {
                    Console.WriteLine("O valor deve ser inteiro, não pode conter vírgulas");
                    Console.WriteLine("Por favor, tente novamente");        //Lembrar de juntar esses tente novamente e
                    Console.ReadLine();                                     //continue como uma function
                    continue;

                }

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("O valor não pode ser par");
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
                                                  

                for (int i = tamanho; i != -1; i = i - 2)
                {
                    for (int j = 0; j != i; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
        }
    }
}
