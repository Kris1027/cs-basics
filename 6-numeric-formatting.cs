using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double number = 1234567.89;
        
        // 1. Basic numeric formatting
        Console.WriteLine("1. Basic numeric formatting:");
        Console.WriteLine($"Default: {number}");
        Console.WriteLine($"Fixed-point (F2): {number:F2}");
        Console.WriteLine($"Number (N): {number:N}");
        Console.WriteLine($"Exponential (E): {number:E}");

        // 2. Currency formatting
        Console.WriteLine("\n2. Currency formatting:");
        Console.WriteLine($"Currency (C): {number:C}");
        Console.WriteLine($"Currency (C) in French culture: {number.ToString("C", new CultureInfo("fr-FR"))}");

        // 3. Percentage formatting
        Console.WriteLine("\n3. Percentage formatting:");
        double percentage = 0.1234;
        Console.WriteLine($"Percentage (P): {percentage:P}");
        Console.WriteLine($"Percentage with 2 decimals (P2): {percentage:P2}");

        // 4. Custom numeric formatting
        Console.WriteLine("\n4. Custom numeric formatting:");
        Console.WriteLine($"Custom (#,##0.00): {number:#,##0.00}");
        Console.WriteLine($"Custom (000.000E+00): {number:000.000E+00}");

        // 5. Padding and alignment
        Console.WriteLine("\n5. Padding and alignment:");
        Console.WriteLine($"Right-aligned, 15 chars wide: {number,15:F2}");
        Console.WriteLine($"Left-aligned, 15 chars wide: {number,-15:F2}");

        // 6. Different bases
        Console.WriteLine("\n6. Different bases:");
        int intNumber = 255;
        Console.WriteLine($"Hexadecimal (X): {intNumber:X}");
        Console.WriteLine($"Binary (convert manually): {Convert.ToString(intNumber, 2)}");

        // 7. Culture-specific formatting
        Console.WriteLine("\n7. Culture-specific formatting:");
        CultureInfo usCulture = new CultureInfo("en-US");
        CultureInfo deCulture = new CultureInfo("de-DE");
        Console.WriteLine($"US format: {number.ToString("N", usCulture)}");
        Console.WriteLine($"German format: {number.ToString("N", deCulture)}");
    }
}