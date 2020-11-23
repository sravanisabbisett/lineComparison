using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class lineComparision
    {
        /// <summary>
        /// Gets the end points of line  coordinates and returns power of difference
        /// </summary>
        /// <returns></returns>

        public double GetEndPointsOfLine()
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

        public double DistanceBwtTwoPoints()
        {
            double xCoordinates = GetEndPointsOfLine();
            double yCoordinates = GetEndPointsOfLine();
            double distance = Math.Sqrt(xCoordinates + yCoordinates);
            return Math.Round(distance, 2);
        }
        

        /// <summary>
        /// Compare two lines and give result of 0 or 1 or -1
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <returns></returns>

        public string CompareTwoLines(double line1, double line2)
        {
            int checkLines = line1.CompareTo(line2);
            Console.WriteLine(checkLines);
            return checkLines == 0 ? "Both lines are equal" :
                   checkLines == -1 ? "First Line is less Than Second Line" :
                   "First Line is Greater Than Second Line";
        }
    }
}
