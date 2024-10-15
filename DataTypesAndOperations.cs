using System;

class Program
{
    static void Main()
    {
        // Liczby całkowite
        int liczbaCalkowita = 10;
        long duzaLiczbaCalkowita = 1234567890123456789L;

        // Liczby zmiennoprzecinkowe
        float liczbaZmiennoprzecinkowa = 3.14f;
        double dokladniejszaLiczba = 3.141592653589793;

        // Typ logiczny
        bool prawdaFalsz = true;

        // Znaki i ciągi znaków
        char pojedynczyZnak = 'A';
        string tekst = "Witaj, świecie!";

        // Wyświetlanie wartości
        Console.WriteLine($"Liczba całkowita: {liczbaCalkowita}");
        Console.WriteLine($"Duża liczba całkowita: {duzaLiczbaCalkowita}");
        Console.WriteLine($"Liczba zmiennoprzecinkowa: {liczbaZmiennoprzecinkowa}");
        Console.WriteLine($"Dokładniejsza liczba: {dokladniejszaLiczba}");
        Console.WriteLine($"Wartość logiczna: {prawdaFalsz}");
        Console.WriteLine($"Pojedynczy znak: {pojedynczyZnak}");
        Console.WriteLine($"Tekst: {tekst}");

        // Podstawowe operacje
        int a = 5, b = 3;
        Console.WriteLine($"Dodawanie: {a} + {b} = {a + b}");
        Console.WriteLine($"Odejmowanie: {a} - {b} = {a - b}");
        Console.WriteLine($"Mnożenie: {a} * {b} = {a * b}");
        Console.WriteLine($"Dzielenie: {a} / {b} = {a / b}");
        Console.WriteLine($"Reszta z dzielenia: {a} % {b} = {a % b}");

        // Operacje na ciągach znaków
        string imie = "Jan";
        string nazwisko = "Kowalski";
        string pelneImie = imie + " " + nazwisko;
        Console.WriteLine($"Pełne imię: {pelneImie}");

        // Porównania
        Console.WriteLine($"Czy 5 > 3? {5 > 3}");
        Console.WriteLine($"Czy 5 == 3? {5 == 3}");
        Console.WriteLine($"Czy 5 != 3? {5 != 3}");
    }
}
