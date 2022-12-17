using ConsoleApp24;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество рядов алгоритма: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите x: ");
        int x = int.Parse(Console.ReadLine());

        Algorithm algorithm = new(n, x);
        Console.WriteLine(algorithm.GetAlgorithm());
    }
}