namespace DiamanteXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante X");
            Console.WriteLine("----------------------");
            Console.WriteLine("Digite um valor impar inteiro:");
            Console.WriteLine("----------------------");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            if (tamanho % 2 == 0)
            {
                Console.WriteLine("O valor não pode ser par");
                Console.WriteLine("Por favor, tente novamente");
                Console.ReadLine();
            }
        }
    }
}
