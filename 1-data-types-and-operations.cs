using System;

class Program
{
    static void Main()
    {
        // Integer numbers
        int integerNumber = 10;
        long largeIntegerNumber = 1234567890123456789L;

        // Floating point numbers
        float floatNumber = 3.14f;
        double moreAccurateNumber = 3.141592653589793;

        // Boolean type
        bool trueFalse = true;

        // Characters and strings
        char singleCharacter = 'A';
        string text = "Hello, world!";

        // Displaying values
        Console.WriteLine($"Integer number: {integerNumber}");
        Console.WriteLine($"Large integer number: {largeIntegerNumber}");
        Console.WriteLine($"Floating point number: {floatNumber}");
        Console.WriteLine($"More accurate number: {moreAccurateNumber}");
        Console.WriteLine($"Boolean value: {trueFalse}");
        Console.WriteLine($"Single character: {singleCharacter}");
        Console.WriteLine($"Text: {text}");

        // Basic operations
        int a = 5, b = 3;
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");
        Console.WriteLine($"Remainder: {a} % {b} = {a % b}");

        // String operations
        string firstName = "John";
        string lastName = "Smith";
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full name: {fullName}");

        // Comparisons
        Console.WriteLine($"Is 5 > 3? {5 > 3}");
        Console.WriteLine($"Is 5 == 3? {5 == 3}");
        Console.WriteLine($"Is 5 != 3? {5 != 3}");
    }
}