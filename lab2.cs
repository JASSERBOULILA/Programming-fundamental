using System;
public class Program
{
  public static void Main()
  {
    // Lab 2 - COMP 1030 Programming Fundamentals
 
    /* STEP 1: Create string variables for each of the following:
    a) Todays weather conditions (i.e. "cloudy", "sunny", "partly-cloudy", "rainy")
    
    b) Possibility of precipitation (i.e. "40%" or "60%" or whatever)
    c) Wind conditions (i.e. "30 km/h with gusts to 50 km/h")
    d) Daily high temperature (i.e. "18°C")
    e) Daily low temperature (i.e. "7°C")
    f) UV index (i.e. "4 or moderate", "7 or high", or whatever)
    */

    string weather = "cloudy";
    string precipitation = "40%";
    string wind = "30 km/h with gusts to 50 km/h";
    string high = "18°C";
    string low = "7°C";
    string uv = "4 or moderate";
 
    // STEP 2: Create another string variable that assembles all of the above variables that describes today's weather, using String interpolation or simple concatenation.
 
    string sentence = $"Today's weather is {weather}, with {precipitation} chance of precipitation, {wind}, with a high of {high} and a low of {low}. The UV index is {uv}.";
 
    // STEP 3: Output the sentence created in STEP 2 to the console with Console.WriteLine().
 
    Console.WriteLine(sentence);
  }
}