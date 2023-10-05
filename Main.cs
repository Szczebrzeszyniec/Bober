using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int b = int.Parse(Console.ReadLine());

        int suma = a + b;

        if (suma % 2 == 0)
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }
    }
}
