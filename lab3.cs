using System;

    public static class Lab3
    {
        public static void Run()
        {
            // STEP 1: Determine the radius of each of the planets of the solar system (in kilometres) and declare a variable for each using an appropriate real number type

            double mercuryRadius = 2439.7;
            double venusRadius = 6051.8;
            double earthRadius = 6371.0;
            double marsRadius = 3389.5;
            double jupiterRadius = 69911.0;
            double saturnRadius = 58232.0;
            double uranusRadius = 25362.0;
            double neptuneRadius = 24622.0;

            // STEP 2: For each of the above variables, declare a new variable to hold the surface area using an appropriate real number type
            double mercuryArea ,venusArea, earthArea, marsArea, jupiterArea, saturnArea, uranusArea, neptuneArea;

            // STEP 3: Set each of the above variables declared in STEP 2 to the surface area using an expression

            mercuryArea = 4 * Math.PI * Math.Pow(mercuryRadius, 2);
            venusArea = 4 * Math.PI * Math.Pow(venusRadius, 2);
            earthArea = 4 * Math.PI * Math.Pow(earthRadius, 2);
            marsArea = 4 * Math.PI * Math.Pow(marsRadius, 2);
            jupiterArea = 4 * Math.PI * Math.Pow(jupiterRadius, 2);
            saturnArea = 4 * Math.PI * Math.Pow(saturnRadius, 2);
            uranusArea = 4 * Math.PI * Math.Pow(uranusRadius, 2);
            neptuneArea = 4 * Math.PI * Math.Pow(neptuneRadius, 2);

            // STEP 4: Output a friendly sentence to the console stating the surface area of each of the planets using Console.Write()

            Console.WriteLine($"Mercury surface area is approximately {mercuryArea:N0} km².");
            Console.WriteLine($"Venus surface area is approximately {venusArea:N0} km².");
            Console.WriteLine($"Earth surface area is approximately {earthArea:N0} km².");
            Console.WriteLine($"Mars surface area is approximately {marsArea:N0} km².");
            Console.WriteLine($"Jupiter surface area is approximately {jupiterArea:N0} km².");
            Console.WriteLine($"Saturn surface area is approximately {saturnArea:N0} km².");
            Console.WriteLine($"Uranus surface area is approximately {uranusArea:N0} km².");
            Console.WriteLine($"Neptune surface area is approximately {neptuneArea:N0} km².");
             
        }
    }

