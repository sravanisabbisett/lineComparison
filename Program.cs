using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double line1distance = DistanceBwtTwoPoints();
            Console.WriteLine("Distance between the two points::" + line1distance);
            double line2Distance = DistanceBwtTwoPoints();
            Console.WriteLine("Distance between two points::" + line2Distance);
            string checkEquality = CheckEqality(line1distance,line2Distance);
            Console.WriteLine(checkEquality);
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
        
        public static double DistanceBwtTwoPoints()
        {
            double xCoordinates = GetEndPointsOfX();
            double yCoordinates = GetEndPointsOfY();
            double distance=Math.Sqrt(xCoordinates + yCoordinates);
            return Math.Round(distance, 2);
        }

        public static string CheckEqality(double line1,double line2)
        {
            bool checkLines = line1.Equals(line2);
            Console.WriteLine(checkLines);
            return checkLines == true ? "Both lines are equal" : "Both lines are not equal";
        }
        
    }
}
