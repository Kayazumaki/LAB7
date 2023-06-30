using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczby oddzielonych przecinkami:");
            string input = Console.ReadLine();

            int[] numbers = ParseNumbers(input);
            int size = numbers.Length;

            int median = CalculateMedian(numbers, size);
            Console.WriteLine($"Mediana: {median}");
            Console.ReadLine();
        }

        static int[] ParseNumbers(string input)
        {
            string[] tokens = input.Split(',');
            int[] numbers = new int[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                int.TryParse(tokens[i], out numbers[i]);
            }

            return numbers;
        }

        static int CalculateMedian(int[] array, int size)
        {
            // Tworzenie kopii tablicy
            int[] sortedArray = new int[size];
            Array.Copy(array, sortedArray, size);

            // Sortowanie kopii tablicy
            Array.Sort(sortedArray);

            // Sprawdzenie, czy rozmiar tablicy jest parzysty
            bool isEvenSize = size % 2 == 0;

            // Obliczenie indeksu środkowego elementu
            int middleIndex = size / 2;

            if (isEvenSize)
            {
                // Jeśli rozmiar tablicy jest parzysty, obliczamy średnią dwóch środkowych elementów
                int median1 = sortedArray[middleIndex - 1];
                int median2 = sortedArray[middleIndex];
                return (median1 + median2) / 2;
            }
            else
            {
                // Jeśli rozmiar tablicy jest nieparzysty, zwracamy wartość środkowego elementu
                return sortedArray[middleIndex];
            }
        }
    }
}
