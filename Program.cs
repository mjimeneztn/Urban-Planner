using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 5,
                Width = 4.6,
                Depth = 6.4,
            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Michelle jimenez");
            Building OneTwoThree = new Building("123 south Avenue")
            {
                Stories = 2,
                Width = 90.3,
                Depth = 600.4,
            };
            OneTwoThree.Construct();
            OneTwoThree.Purchase("Jim Bob");
            List<Building> place = new List<Building>()
            { FiveOneTwoEigth, OneTwoThree };
            Console.WriteLine($"Buildings:");

            foreach (Building building in place)
            {
                    building.GetInformation();
            }

        }
    }
}
