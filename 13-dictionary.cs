using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Creating and initializing a dictionary
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            {"Alice", 25},
            {"Bob", 30},
            {"Charlie", 35}
        };
        Console.WriteLine("1. Initial dictionary:");
        DisplayDictionary(ages);

        // 2. Adding elements to the dictionary
        Console.WriteLine("\n2. Adding elements:");
        ages["David"] = 40;
        ages.Add("Eve", 45);
        DisplayDictionary(ages);

        // 3. Accessing values
        Console.WriteLine("\n3. Accessing values:");
        Console.WriteLine($"Alice's age: {ages["Alice"]}");

        // 4. Checking if a key exists
        Console.WriteLine("\n4. Checking if a key exists:");
        string nameToCheck = "Frank";
        if (ages.ContainsKey(nameToCheck))
        {
            Console.WriteLine($"{nameToCheck}'s age: {ages[nameToCheck]}");
        }
        else
        {
            Console.WriteLine($"{nameToCheck} not found in the dictionary");
        }

        // 5. Updating values
        Console.WriteLine("\n5. Updating values:");
        ages["Bob"] = 31;
        DisplayDictionary(ages);

        // 6. Removing elements
        Console.WriteLine("\n6. Removing elements:");
        ages.Remove("Charlie");
        DisplayDictionary(ages);

        // 7. Iterating through the dictionary
        Console.WriteLine("\n7. Iterating through the dictionary:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // 8. Getting all keys and values
        Console.WriteLine("\n8. Getting all keys and values:");
        List<string> keys = new List<string>(ages.Keys);
        List<int> values = new List<int>(ages.Values);
        Console.WriteLine($"Keys: {string.Join(", ", keys)}");
        Console.WriteLine($"Values: {string.Join(", ", values)}");

        // 9. Using TryGetValue
        Console.WriteLine("\n9. Using TryGetValue:");
        if (ages.TryGetValue("Alice", out int aliceAge))
        {
            Console.WriteLine($"Alice's age: {aliceAge}");
        }

        // 10. Dictionary with custom objects
        Console.WriteLine("\n10. Dictionary with custom objects:");
        Dictionary<string, Person> people = new Dictionary<string, Person>
        {
            {"employee1", new Person("Alice", 25)},
            {"employee2", new Person("Bob", 30)}
        };
        foreach (var kvp in people)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {{Name: {kvp.Value.Name}, Age: {kvp.Value.Age}}}");
        }

        // 11. Using LINQ with dictionaries
        Console.WriteLine("\n11. Using LINQ with dictionaries:");
        var youngPeople = ages.Where(kvp => kvp.Value < 35)
                              .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        DisplayDictionary(youngPeople);

        // 12. Clearing the dictionary
        Console.WriteLine("\n12. Clearing the dictionary:");
        ages.Clear();
        Console.WriteLine($"Count after clearing: {ages.Count}");
    }

    static void DisplayDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
    {
        foreach (var kvp in dict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
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