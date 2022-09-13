using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число факториала:");
        int Factorial1 = int.Parse(Console.ReadLine());
        Console.WriteLine(fact(Factorial1));
        Console.ReadLine();
    }
    static int fact(int num)
    {
        return (num == 0) ? 1 : num * fact(num - 1);
    }
}