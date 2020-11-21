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
        /// Gets the end points of line for x coordinates and returns power of difference.
        /// </summary>
        /// <returns></returns>
       
        public static double GetEndPointsOfX()
        {
            Console.WriteLine("Enter X1,X2");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());
            return Math.Pow((x2 - x1), 2);
        }

        /// <summary>
        /// Gets the end points of line y coordinates and returns power of difference
        /// </summary>
        /// <returns></returns>
        
        public static double GetEndPointsOfY()
        {
            Console.WriteLine("Enter Y1,Y2");
            var y1 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            return Math.Pow((y2 - y1), 2);
        }

        /// <summary>
        /// calculate the Distance Between two points
        /// </summary>
        /// <returns></returns>
        
        public static double DistanceBwtTwoPoints()
        {
            double xCoordinates = GetEndPointsOfX();
            double yCoordinates = GetEndPointsOfY();
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
