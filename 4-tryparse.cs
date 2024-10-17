using System;

class Program
{
    static void Main()
    {
        // 1. Integer TryParse
        Console.WriteLine("1. Integer TryParse:");
        string intString = "123";
        if (int.TryParse(intString, out int intResult))
        {
            Console.WriteLine($"Successfully parsed: {intResult}");
        }
        else
        {
            Console.WriteLine("Failed to parse integer");
        }

        // 2. Double TryParse
        Console.WriteLine("\n2. Double TryParse:");
        string doubleString = "3.14";
        if (double.TryParse(doubleString, out double doubleResult))
        {
            Console.WriteLine($"Successfully parsed: {doubleResult}");
        }
        else
        {
            Console.WriteLine("Failed to parse double");
        }

        // 3. Boolean TryParse
        Console.WriteLine("\n3. Boolean TryParse:");
        string boolString = "true";
        if (bool.TryParse(boolString, out bool boolResult))
        {
            Console.WriteLine($"Successfully parsed: {boolResult}");
        }
        else
        {
            Console.WriteLine("Failed to parse boolean");
        }

        // 4. DateTime TryParse
        Console.WriteLine("\n4. DateTime TryParse:");
        string dateString = "2023-05-20";
        if (DateTime.TryParse(dateString, out DateTime dateResult))
        {
            Console.WriteLine($"Successfully parsed: {dateResult}");
        }
        else
        {
            Console.WriteLine("Failed to parse date");
        }

        // 5. Handling invalid input
        Console.WriteLine("\n5. Handling invalid input:");
        string invalidInput = "not a number";
        if (int.TryParse(invalidInput, out int invalidResult))
        {
            Console.WriteLine($"Successfully parsed: {invalidResult}");
        }
        else
        {
            Console.WriteLine("Failed to parse invalid input");
        }
    }
}