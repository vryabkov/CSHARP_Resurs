using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {M} до {N} включительно:");

        PrintNumbersRecursive(M, N);
    }

    static void PrintNumbersRecursive(int current, int N)
    {
        if (current <= N)
        {
            Console.WriteLine(current);
            PrintNumbersRecursive(current + 1, N);
        }
    }
}
