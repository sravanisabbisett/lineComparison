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
            string compareTwoLines = CompareTwoLines(line1distance,line2Distance);
            Console.WriteLine(compareTwoLines);
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the end points of line  coordinates and returns power of difference
        /// </summary>
        /// <returns></returns>
        
        public static double GetEndPointsOfLine()
        {
            Console.WriteLine("Enter endPoint1,endPoint2");
            var endPoint1 = Convert.ToDouble(Console.ReadLine());
            var endPoint2 = Convert.ToDouble(Console.ReadLine());
            return Math.Pow((endPoint2 - endPoint1), 2);
        }

        /// <summary>
        /// calculate the Distance Between two points
        /// </summary>
        /// <returns></returns>
        
        public static double DistanceBwtTwoPoints()
        {
            double xCoordinates = GetEndPointsOfLine();
            double yCoordinates = GetEndPointsOfLine();
            double distance=Math.Sqrt(xCoordinates + yCoordinates);
            return Math.Round(distance, 2);
        }

        /// <summary>
        /// Compare two lines and give result of 0 or 1 or -1
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <returns></returns>
        
        public static string CompareTwoLines(double line1,double line2)
        {
            int checkLines = line1.CompareTo(line2);
            Console.WriteLine(checkLines);
            return checkLines == 0 ? "Both lines are equal" :
                   checkLines == -1 ? "First Line is less Than Second Line" :
                   "First Line is Greater Than Second Line";
        }
        
    }
}
