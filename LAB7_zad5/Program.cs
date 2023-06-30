using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_zad5
{
    internal class Program
    {
        static void Main()
        {
            int n;
            while (true)
            {
                Console.Write("Podaj liczbę naturalną większą od 5: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 5)
                    break;

                Console.WriteLine("Nieprawidłowa wartość. Spróbuj ponownie.");
            }

            int primeDivisors = CountPrimeDivisors(n);
            Console.WriteLine("Liczba dzielników pierwszych liczby to: " + primeDivisors);
            Console.ReadKey();
        }

        static int CountPrimeDivisors(int n)
        {
            if (n <= 5)
                return 0;

            var divisors = new HashSet<int>();

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                while (n % i == 0)
                {
                    divisors.Add(i);
                    n /= i;
                }
            }

            if (n > 1)
                divisors.Add(n);

            int primeDivisors = 0;

            foreach (int divisor in divisors)
            {
                if (IsPrime(divisor))
                    primeDivisors++;
            }

            return primeDivisors;
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
