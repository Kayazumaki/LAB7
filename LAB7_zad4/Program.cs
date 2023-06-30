using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

            Console.WriteLine("Podaj numery wierszy do porównania:");
            Console.Write("Wiersz 1 (0-3): ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Wiersz (0-3): ");
            int row2 = int.Parse(Console.ReadLine());

            double difference = CalculateRowDifference(array, row1, row2);
            Console.WriteLine($"Różnica między wierszami {row1} i {row2}: {difference}");

            Console.ReadLine();
        }

        static double CalculateRowDifference(int[,] array, int row1, int row2)
        {
            int numCols = array.GetLength(1);
            double difference = 0;

            for (int k = 0; k < numCols; k++)
            {
                int element1 = array[row1, k];
                int element2 = array[row2, k];
                difference += Math.Pow(element1 - element2, 2);
            }

            return difference;
        }
    }
}
