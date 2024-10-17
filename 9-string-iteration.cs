using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string sampleText = "Hello, World!";

        // 1. Using a for loop
        Console.WriteLine("1. Using a for loop:");
        for (int i = 0; i < sampleText.Length; i++)
        {
            Console.Write($"{sampleText[i]} ");
        }
        Console.WriteLine();

        // 2. Using a foreach loop
        Console.WriteLine("\n2. Using a foreach loop:");
        foreach (char c in sampleText)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();

        // 3. Using LINQ
        Console.WriteLine("\n3. Using LINQ:");
        sampleText.ToList().ForEach(c => Console.Write($"{c} "));
        Console.WriteLine();

        // 4. Using String.ToCharArray()
        Console.WriteLine("\n4. Using String.ToCharArray():");
        foreach (char c in sampleText.ToCharArray())
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();

        // 5. Reverse iteration using a for loop
        Console.WriteLine("\n5. Reverse iteration using a for loop:");
        for (int i = sampleText.Length - 1; i >= 0; i--)
        {
            Console.Write($"{sampleText[i]} ");
        }
        Console.WriteLine();

        // 6. Using String.Substring for substrings
        Console.WriteLine("\n6. Using String.Substring for substrings:");
        for (int i = 0; i < sampleText.Length; i++)
        {
            Console.WriteLine(sampleText.Substring(i));
        }

        // 7. Iterating over words
        Console.WriteLine("\n7. Iterating over words:");
        string[] words = sampleText.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // 8. Using string.Concat with LINQ for transformation
        Console.WriteLine("\n8. Using string.Concat with LINQ for transformation:");
        string transformed = string.Concat(sampleText.Select(c => char.IsLetter(c) ? (char)(c + 1) : c));
        Console.WriteLine(transformed);
    }
}