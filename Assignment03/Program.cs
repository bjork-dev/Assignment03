using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;

namespace Assignment03
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

            //Change from here

            int highestPopulation = cities[2].Population;
            /*
            foreach (City city in cities)
            {
                if (city.Population > highestPopulation)
                {
                    highestPopulation = city.Population;
                }
            }
            */

            var highPop = cities.Where(city => city.Population > highestPopulation);

            Console.WriteLine("Highest population: " + highestPopulation);

            int earliestFounding = cities[0].Founded;
            foreach (City city in cities)
            {
                if (city.Founded < earliestFounding)
                {
                    earliestFounding = city.Founded;
                }
            }
            Console.WriteLine("Earliest founding: " + earliestFounding);

            double totalPopulationDensity = 0;
            foreach (City city in cities)
            {
                totalPopulationDensity += city.Population / city.Area;
            }
            double averagePopulationDensity = Math.Round(totalPopulationDensity / cities.Length);
            Console.WriteLine("Average population density: " + averagePopulationDensity + " people per square kilometer");

            List<City> longNameCities = new List<City>();
            foreach (City city in cities)
            {
                if (city.Name.Length > 6)
                {
                    longNameCities.Add(city);
                }
            }
            List<string> longNames = new List<string>();
            foreach (City city in longNameCities)
            {
                longNames.Add(city.Name);
            }
            Console.WriteLine("Cities with names longer than six letters: " + String.Join(", ", longNames));
        }
    }
}