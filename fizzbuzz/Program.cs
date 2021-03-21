using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "FizzBuzz";
            Console.WriteLine($"Witaj w aplikacji {appName}. Podaj liczbę całkowitą:");

            string input = Console.ReadLine();

            int number;
            bool divisible3 = false;
            bool divisible5 =  false;

            if (int.TryParse(input, out number))
            {
                if (number % 3 == 0)
                {
                    divisible3 = true;
                }
                if (number % 5 == 0)
                {
                    divisible5 = true;
                }
                if (divisible3 && divisible5)
                    Console.WriteLine("FizzBuzz");
                else if (divisible3)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divisible5)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"Podana liczba to:{number}");
                }
            }
            else
                Console.WriteLine("Nie podano liczby całkowitej");

        }
    }
}
