using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            lineComparision line = new lineComparision();
            double line1distance = line.DistanceBwtTwoPoints();
            Console.WriteLine("Distance between the two points::" + line1distance);
            double line2Distance = line.DistanceBwtTwoPoints();
            Console.WriteLine("Distance between two points::" + line2Distance);
            string compareTwoLines = line.CompareTwoLines(line1distance,line2Distance);
            Console.WriteLine(compareTwoLines);
            Console.ReadKey();
        }

        
        
    }
}
