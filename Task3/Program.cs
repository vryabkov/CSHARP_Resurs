using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReversed(array, index - 1);
        }
    }
}
