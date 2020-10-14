using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment03_City
{
    public class City
    {
        public string Name;
        public int Population;
        public double Area;
        public int Founded;
    }

    public class Cities
    {
        public static void Main()
        {
            City[] cities =
            {
                new City
                {
                    Name = "Stockholm",
                    Area = 381.63,
                    Population = 1515017,
                    Founded = 1252
                },
                new City
                {
                    Name = "Göteborg",
                    Area = 215.13,
                    Population = 590580,
                    Founded = 1621
                },
                new City
                {
                    Name = "Malmö",
                    Area = 77.06,
                    Population = 312012,
                    Founded = 1250
                },
                new City
                {
                    Name = "Uppsala",
                    Area = 43.74,
                    Population = 156854,
                    Founded = 1286
                },
                new City
                {
                    Name = "Västerås",
                    Area = 48.07,
                    Population = 121806,
                    Founded = 990
                },
                new City
                {
                    Name = "Örebro",
                    Area = 50.64,
                    Population = 119091,
                    Founded = 1200
                }
            };
            //Highest population using LINQ
            var highPop = cities.OrderBy(c => c.Population).Last();
            Console.WriteLine("Highest population: " + highPop.Population);
            //Earliest founding using LINQ
            var founded = cities.OrderBy(c => c.Founded).First();
            Console.WriteLine("Earliest founding: " + founded.Founded);
            //Average population density using LINQ
            var avgPopDensity = cities.Select(c => c.Population / c.Area).Average();
            Console.WriteLine("Average population density: " + Math.Round(avgPopDensity) + " people per square kilometer");
            //Long city names using LINQ
            var longNames = cities.Where(c => c.Name.Length > 6).Select(c => c.Name).ToList();
            Console.WriteLine("Cities with names longer than six letters: " + string.Join(", ", longNames));
        }
    }
}