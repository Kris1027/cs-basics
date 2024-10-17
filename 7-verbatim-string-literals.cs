using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // 1. Basic verbatim string
        Console.WriteLine("1. Basic verbatim string:");
        string regularString = "First line\nSecond line";
        string verbatimString = @"First line
Second line";
        Console.WriteLine("Regular string:");
        Console.WriteLine(regularString);
        Console.WriteLine("Verbatim string:");
        Console.WriteLine(verbatimString);

        // 2. File paths
        Console.WriteLine("\n2. File paths:");
        string regularPath = "C:\\Program Files\\My App\\Data";
        string verbatimPath = @"C:\Program Files\My App\Data";
        Console.WriteLine($"Regular path: {regularPath}");
        Console.WriteLine($"Verbatim path: {verbatimPath}");

        // 3. Quotes in verbatim strings
        Console.WriteLine("\n3. Quotes in verbatim strings:");
        string quoteInVerbatim = @"He said, ""Hello!""";
        Console.WriteLine(quoteInVerbatim);

        // 4. Regular expressions
        Console.WriteLine("\n4. Regular expressions:");
        string regularRegex = "\\b\\w+@\\w+\\.\\w+";
        string verbatimRegex = @"\b\w+@\w+\.\w+";
        Console.WriteLine($"Regular regex: {regularRegex}");
        Console.WriteLine($"Verbatim regex: {verbatimRegex}");

        // 5. Combining with string interpolation
        Console.WriteLine("\n5. Combining with string interpolation:");
        string name = "Alice";
        int age = 30;
        string interpolatedVerbatim = $@"Name: {name}
Age: {age}";
        Console.WriteLine(interpolatedVerbatim);

        // 6. Preserving whitespace
        Console.WriteLine("\n6. Preserving whitespace:");
        string codeSnippet = @"
    public void MyMethod()
    {
        Console.WriteLine(""Hello, World!"");
    }";
        Console.WriteLine(codeSnippet);
    }
}