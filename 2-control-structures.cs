using System;

class Program
{
    static void Main()
    {
        // 1. Conditional statement if-else
        int age = 18;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are not an adult yet.");
        }

        // 2. Switch statement
        string dayOfWeek = "Wednesday";
        switch (dayOfWeek)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                Console.WriteLine("Weekday");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Invalid day of the week");
                break;
        }

        // 3. For loop
        Console.WriteLine("For loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // 4. While loop
        Console.WriteLine("While loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine($"Iteration {j}");
            j++;
        }

        // 5. Do-while loop
        Console.WriteLine("Do-while loop:");
        int k = 1;
        do
        {
            Console.WriteLine($"Iteration {k}");
            k++;
        } while (k <= 5);

        // 6. Foreach loop
        Console.WriteLine("Foreach loop:");
        string[] fruits = { "apple", "banana", "orange" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
