using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Multidimensional array
        Console.WriteLine("1. Multidimensional array:");
        int[,] matrix = new int[3, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        DisplayMatrix(matrix);

        // 2. Jagged array
        Console.WriteLine("\n2. Jagged array:");
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] {1, 2, 3};
        jaggedArray[1] = new int[] {4, 5};
        jaggedArray[2] = new int[] {6, 7, 8, 9};
        DisplayJaggedArray(jaggedArray);

        // 3. Array.Copy method
        Console.WriteLine("\n3. Array.Copy method:");
        int[] source = {1, 2, 3, 4, 5};
        int[] destination = new int[5];
        Array.Copy(source, destination, 5);
        Console.WriteLine("Source array:");
        DisplayArray(source);
        Console.WriteLine("Destination array:");
        DisplayArray(destination);

        // 4. Array.Resize method
        Console.WriteLine("\n4. Array.Resize method:");
        Array.Resize(ref source, 7);
        source[5] = 6;
        source[6] = 7;
        DisplayArray(source);

        // 5. Using LINQ methods on arrays
        Console.WriteLine("\n5. LINQ methods on arrays:");
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers:");
        DisplayArray(evenNumbers.ToArray());

        // 6. Array of objects
        Console.WriteLine("\n6. Array of objects:");
        Person[] people = new Person[]
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 35)
        };
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }

    static void DisplayArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void DisplayJaggedArray(int[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine(string.Join(", ", jaggedArray[i]));
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}