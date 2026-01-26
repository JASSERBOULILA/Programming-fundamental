using System;

namespace Lab2SpaceExploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add all the planet radiuses

            double mercuryRadius = 2439.7;
            double venusRadius = 6051.8;
            double earthRadius = 6371.0;
            double marsRadius = 3389.5;
            double jupiterRadius = 69911.0;
            double saturnRadius = 58232.0;
            double uranusRadius = 25362.0;
            double neptuneRadius = 24622.0;

            // creating variable for the area for each planet
            double mercuryArea ,venusArea, earthArea, marsArea, jupiterArea, saturnArea, uranusArea, neptuneArea;
            // calculate the all of the area for each planet

            mercuryArea = 4 * Math.PI * Math.Pow(mercuryRadius, 2);
            venusArea = 4 * Math.PI * Math.Pow(venusRadius, 2);
            earthArea = 4 * Math.PI * Math.Pow(earthRadius, 2);
            marsArea = 4 * Math.PI * Math.Pow(marsRadius, 2);
            jupiterArea = 4 * Math.PI * Math.Pow(jupiterRadius, 2);
            saturnArea = 4 * Math.PI * Math.Pow(saturnRadius, 2);
            uranusArea = 4 * Math.PI * Math.Pow(uranusRadius, 2);
            neptuneArea = 4 * Math.PI * Math.Pow(neptuneRadius, 2);

            
            
        }
    }
}
