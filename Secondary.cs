using System;

class Program
{
    static void Main()
    {
        // Zadanie 1
        Console.WriteLine("Zadanie 1:");
        for (int i = 1; i <= 10; i++)
        {
            int cube = (i * i * i) + 3;
            Console.Write(cube + ", ");
        }
        Console.WriteLine("\n");

        // Zadanie 2
        Console.WriteLine("Zadanie 2:");
        for (int i = 105; i <= 999; i += 15)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine("\n");

        // Zadanie 3
        Console.WriteLine("Zadanie 3:");
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Dzielniki: ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine("\n");

        // Zadanie 4
        Console.WriteLine("Zadanie 4:");
        int sum = 0;
        for (int i = 10; i < 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("Suma liczb dwucyfrowych: " + sum + "\n");

        // Zadanie 5
        Console.WriteLine("Zadanie 5:");
        Console.Write("Podaj liczbę n: ");
        n = int.Parse(Console.ReadLine());
        int x = 1;
        Console.Write("Bajtuś wybrał: ");
        for (int i = 1; i <= n; i++)
        {
            if (i != n)
            {
                Console.Write(i + " ");
                x++;
            }
        }
        Console.WriteLine("\nWybrana liczba x przez Bajtusia: " + x);

        // Zadanie 6
        Console.WriteLine("Zadanie 6:");
        int a = 1;
        int b = 2;
        Console.Write(a);

        for (int i = 0; i < 7; i++)
        {
            Console.Write(", " + b);
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine();
    }
}
