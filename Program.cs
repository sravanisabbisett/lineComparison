using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double xCoordinates = GetEndPointsOfX();
            double yCoordinates = GetEndPointsOfY();
            double distance = DistanceBwtTwoPoints(xCoordinates, yCoordinates);
            Console.WriteLine("Distance between the two points::" + distance);
            Console.ReadKey();
        }

        public static double GetEndPointsOfX()
        {
            Console.WriteLine("Enter X1,X2");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());
            return Math.Pow((x2 - x1), 2);
        }

        public static double GetEndPointsOfY()
        {
            Console.WriteLine("Enter Y1,Y2");
            var y1 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            return Math.Pow((y2 - y1), 2);
        }
        
        public static double DistanceBwtTwoPoints(double xCordinates,double yCoridinates)
        {
            double distance=Math.Sqrt(xCordinates + yCoridinates);
            return Math.Round(distance, 2);
        }
    }
}
