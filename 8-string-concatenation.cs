using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        int number = 42;

        // 1. Using the + operator
        Console.WriteLine("1. Using the + operator:");
        string result1 = str1 + " " + str2 + " " + number;
        Console.WriteLine(result1);

        // 2. Using string interpolation
        Console.WriteLine("\n2. Using string interpolation:");
        string result2 = $"{str1} {str2} {number}";
        Console.WriteLine(result2);

        // 3. Using String.Concat method
        Console.WriteLine("\n3. Using String.Concat method:");
        string result3 = String.Concat(str1, " ", str2, " ", number);
        Console.WriteLine(result3);

        // 4. Using String.Join method
        Console.WriteLine("\n4. Using String.Join method:");
        string result4 = String.Join(" ", str1, str2, number);
        Console.WriteLine(result4);

        // 5. Using StringBuilder
        Console.WriteLine("\n5. Using StringBuilder:");
        StringBuilder sb = new StringBuilder();
        sb.Append(str1);
        sb.Append(" ");
        sb.Append(str2);
        sb.Append(" ");
        sb.Append(number);
        string result5 = sb.ToString();
        Console.WriteLine(result5);

        // 6. Performance comparison
        Console.WriteLine("\n6. Performance comparison:");
        int iterations = 100000;

        Stopwatch sw = Stopwatch.StartNew();
        string concat = "";
        for (int i = 0; i < iterations; i++)
        {
            concat += i.ToString();
        }
        sw.Stop();
        Console.WriteLine($"+ operator: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        StringBuilder sbPerf = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sbPerf.Append(i);
        }
        string sbResult = sbPerf.ToString();
        sw.Stop();
        Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds} ms");
    }
}