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
                }

                for (int i = 1; i != tamanho; i = i + 2)
                {
                    Console.WriteLine(i);           //Estou escrevendo os números referente ás quantidades 
                }                                   //de X para facilitar as primeiras versões
                Console.ReadLine();
            }
        }
    }
}
