using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Declaration and initialization of an array
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("1. Array contents:");
        DisplayArray(numbers);

        // 2. Accessing and modifying elements
        Console.WriteLine("\n2. Modifying an element:");
        numbers[2] = 10;
        DisplayArray(numbers);

        // 3. Using foreach loop
        Console.WriteLine("\n3. Sum of elements (foreach):");
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");

        // 4. Using LINQ
        Console.WriteLine("\n4. Average of elements (LINQ):");
        double average = numbers.Average();
        Console.WriteLine($"Average: {average}");

        // 5. Creating a new array
        Console.WriteLine("\n5. New array with squares of numbers:");
        int[] squares = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            squares[i] = numbers[i] * numbers[i];
        }
        DisplayArray(squares);

        // 6. Sorting the array
        Console.WriteLine("\n6. Sorted array:");
        Array.Sort(numbers);
        DisplayArray(numbers);

        // 7. Searching in the array
        Console.WriteLine("\n7. Searching for an element:");
        int searchFor = 4;
        int index = Array.IndexOf(numbers, searchFor);
        Console.WriteLine($"Index of number {searchFor}: {index}");

        // 8. Reversing the array
        Console.WriteLine("\n8. Reversed array:");
        Array.Reverse(numbers);
        DisplayArray(numbers);
    }

    static void DisplayArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}