using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("8================D v1.0");
        Console.WriteLine("");
        Console.WriteLine("1. Sprawdź, czy a+b=Parzyste | T/F");
        Console.WriteLine("2. Sprawdź, czy średnia arytmetyczna dwóch liczb jest większa od średniej geometrycznej");
        Console.WriteLine("3. Sprawdź, czy dokładnie dwie z trzech liczb są sobie równe");
        Console.WriteLine("4. Znajdź najmniejszą z czterech liczb");
        Console.WriteLine("5. Sprawdź, czy trzy liczby spełniają nierówność trójkąta");
        Console.WriteLine("6. Sprawdź, czy z trzech liczb da się zbudować trójkąt i jaki to trójkąt");
        Console.WriteLine("");

        while (true)
        {
            string S = Console.ReadLine();

            if (S == "1")
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
            else if (S == "2")
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę:");
                double g = double.Parse(Console.ReadLine());

                double sredniaArytmetyczna = (a + g) / 2;
                double sredniaGeometryczna = Math.Sqrt(a * g);

                if (sredniaArytmetyczna > sredniaGeometryczna)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }
            else if (S == "3")
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę:");
                int l = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj trzecią liczbę:");
                int m = int.Parse(Console.ReadLine());

                if ((k == l && l != m) || (k == m && k != l) || (l == m && l != k))
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }
            else if (S == "4")
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę:");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj trzecią liczbę:");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj czwartą liczbę:");
                int d = int.Parse(Console.ReadLine());

                int najmniejsza = Math.Min(Math.Min(a, b), Math.Min(c, d));

                Console.WriteLine($"Najmniejsza liczba to: {najmniejsza}");
            }
            else if (S == "5")
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę:");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj trzecią liczbę:");
                double c = double.Parse(Console.ReadLine());

                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }
            else if (S == "6")
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę:");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj trzecią liczbę:");
                double c = double.Parse(Console.ReadLine());

                if (a + b > c && a + c > b && b + c > a)
                {
                    double[] liczby = { a, b, c };
                    Array.Sort(liczby);

                    if (liczby[0] * liczby[0] + liczby[1] * liczby[1] == liczby[2] * liczby[2])
                    {
                        Console.WriteLine("Prostokątny");
                    }
                    else if (liczby[0] * liczby[0] + liczby[1] * liczby[1] > liczby[2] * liczby[2])
                    {
                        Console.WriteLine("Ostrokątny");
                    }
                    else
                    {
                        Console.WriteLine("Rozwartokątny");
                    }
                }
                else
                {
                    Console.WriteLine("Nie da się zbudować trójkąta.");
                }
            }
            else
            {
                Console.WriteLine("Coś nie tyka, bratku");
            }
        }
    }
}
