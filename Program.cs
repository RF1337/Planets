using System;
using System.Collections.Generic;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
           //2
            //Creating list
            List<Planet> planets = new List<Planet>();
            //Adding objects to list
            planets.Add(new Planet("Mercury"));
            planets.Add(new Planet("Earth"));
            planets.Add(new Planet("Mars"));
            planets.Add(new Planet("Jupiter"));
            planets.Add(new Planet("Saturn"));
            planets.Add(new Planet("Uranus"));
            planets.Add(new Planet("Neptune"));
            planets.Add(new Planet("Pluto"));

            //3
            //Creating foreach loop
            Console.WriteLine("Planets without venus");
            //prints all planets without venus
            foreach (Planet planet in planets)
            {
                //Printing planet's name to console
                Console.WriteLine(planet.planetName);
            }
            //4
            //Creating space
            Console.WriteLine();
            //Adding venus to the list
            planets.Add(new Planet("Venus"));
            Console.WriteLine("Planets with venus");
            //Prints all planets with venus
            foreach (Planet planet in planets)
            {
                //Printing planet's name to console
                Console.WriteLine(planet.planetName);
            }
            //5 
            //no it doesn't


            //6
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].planetName == "Mercury")
                {
                    planets.RemoveAt(i);
                }
            }
            Console.WriteLine("After pluto was removed there are " + planets.Count + " planets");
            

            //7
            planets.Add(new Planet("Pluto"));


            //8
            Console.WriteLine("There are " + planets.Count + " planets after pluto was added back again");


            //9
            //Creating space
            Console.WriteLine();
            //Creating list
            List<Planet> meanPlanets = new List<Planet>();
            //Adding planets to list
            meanPlanets.Add(new Planet("Mars"));
            meanPlanets.Add(new Planet("Jupiter"));
            meanPlanets.Add(new Planet("Saturn"));
            meanPlanets.Add(new Planet("Uranus"));
            meanPlanets.Add(new Planet("Neptune"));
            meanPlanets.Add(new Planet("Pluto"));
            //Printing all planets in meanPlanets list to console
            foreach (Planet planet in meanPlanets)
            {
                Console.WriteLine(planet.planetName);
            }

            //10
            //Creating space
            Console.WriteLine();
            List<Planet> planetsDiameter = new List<Planet>();
            planetsDiameter.Add(new Planet("Venus"));
            planetsDiameter.Add(new Planet("Earth"));
            planetsDiameter.Add(new Planet("Uranus"));
            planetsDiameter.Add(new Planet("Neptune"));

            foreach(Planet planet in planetsDiameter)
            {
                Console.WriteLine(planet.planetName);
            }

            //11
            planetsDiameter.Clear();
            Console.WriteLine("After clearing all planets there are now " + planetsDiameter.Count + " planets left" +
                "with a diameter between 10,000km and 50,000km");
        }
    }
}
