using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współrzędne punktu początkowego:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędne punktu końcowego:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine($"Długość odcinka: {distance}");
            Console.ReadLine();
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}
