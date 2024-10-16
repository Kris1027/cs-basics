using System;

class Program
{
    static void Main()
    {
        // Calling a method without parameters and without a return value
        GreetUser();

        // Calling a method with parameters
        int sum = Add(5, 3);
        Console.WriteLine($"Sum: {sum}");

        // Calling a method with default parameters
        DisplayInfo("John");
        DisplayInfo("Anna", 25);

        // Calling a method with reference parameters
        int x = 10, y = 20;
        Swap(ref x, ref y);
        Console.WriteLine($"After swap: x = {x}, y = {y}");

        // Calling a method with an output parameter
        int result;
        bool isParsedSuccessfully = TryParse("123", out result);
        if (isParsedSuccessfully)
        {
            Console.WriteLine($"Parsed value: {result}");
        }
    }

    // Method without parameters and without a return value
    static void GreetUser()
    {
        Console.WriteLine("Hello, user!");
    }

    // Method with parameters and a return value
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method with default parameters
    static void DisplayInfo(string name, int age = 30)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    // Method with reference parameters
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Method with an output parameter
    static bool TryParse(string text, out int result)
    {
        return int.TryParse(text, out result);
    }
}
