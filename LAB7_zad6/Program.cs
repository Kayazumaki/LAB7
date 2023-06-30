using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_zad6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Podaj z ilu liczb rzeczywistych chcesz policzyć średnią arytmetyczną: ");
            int size = int.Parse(Console.ReadLine());

            double[] numbers = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double average = CalculateRecursiveAverage(numbers, size);
            Console.WriteLine("Średnia arytmetyczna: " + average);
            Console.ReadKey();
        }

        static double CalculateRecursiveAverage(double[] numbers, int size)
        {
            if (size == 0)
                return 0;

            double lastNumber = numbers[size - 1];
            double sumOfPrevious = CalculateRecursiveAverage(numbers, size - 1);
            double currentAverage = (sumOfPrevious * (size - 1) + lastNumber) / size;

            return currentAverage;
        }
    }
}
