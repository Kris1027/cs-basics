using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Creating and initializing a list
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("1. Initial list:");
        DisplayList(numbers);

        // 2. Adding elements to the list
        Console.WriteLine("\n2. Adding elements:");
        numbers.Add(6);
        numbers.AddRange(new int[] { 7, 8, 9 });
        DisplayList(numbers);

        // 3. Inserting an element at a specific index
        Console.WriteLine("\n3. Inserting an element:");
        numbers.Insert(2, 10);
        DisplayList(numbers);

        // 4. Removing elements
        Console.WriteLine("\n4. Removing elements:");
        numbers.Remove(4);
        numbers.RemoveAt(0);
        DisplayList(numbers);

        // 5. Checking if an element exists
        Console.WriteLine("\n5. Checking if an element exists:");
        bool contains5 = numbers.Contains(5);
        Console.WriteLine($"List contains 5: {contains5}");

        // 6. Finding elements
        Console.WriteLine("\n6. Finding elements:");
        int firstEven = numbers.Find(n => n % 2 == 0);
        Console.WriteLine($"First even number: {firstEven}");

        // 7. Sorting the list
        Console.WriteLine("\n7. Sorting the list:");
        numbers.Sort();
        DisplayList(numbers);

        // 8. Reversing the list
        Console.WriteLine("\n8. Reversing the list:");
        numbers.Reverse();
        DisplayList(numbers);

        // 9. Using LINQ with lists
        Console.WriteLine("\n9. Using LINQ:");
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even numbers:");
        DisplayList(evenNumbers);

        // 10. List of custom objects
        Console.WriteLine("\n10. List of custom objects:");
        List<Person> people = new List<Person>
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 35)
        };
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        // 11. Finding index of an element
        Console.WriteLine("\n11. Finding index of an element:");
        int index = numbers.IndexOf(5);
        Console.WriteLine($"Index of 5: {index}");

        // 12. Clearing the list
        Console.WriteLine("\n12. Clearing the list:");
        numbers.Clear();
        Console.WriteLine($"Count after clearing: {numbers.Count}");
    }

    static void DisplayList<T>(List<T> list)
    {
        Console.WriteLine(string.Join(", ", list));
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