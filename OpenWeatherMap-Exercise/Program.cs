using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace OpenWeatherMap_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an instance of the HttpClient Class called client
            var client = new HttpClient();

            // TODO: Ask for the users API Key and store that in a variable called "api_Key"
            Console.Write("Please enter your API Key: ");
            var apiKey = Console.ReadLine();
            Console.WriteLine();

            // TODO: Ask the user for their city name and store that in a variable called "city_name"
            Console.Write("Please enter the city name: ");
            var city_name = Console.ReadLine();
            Console.WriteLine();

            // TODO: Create a variable to store the URL (use String Interpolation for the {city_name} and {api_Key}  HINT: Make sure to use the "imperial" measurement endpoint
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={apiKey}&units=imperial";

            // TODO: Create a variable to store the response from your GET request to that URL from above  HINT: Don't forget to call .Result 
            var response = client.GetStringAsync(url).Result;

            // TODO: Create a variable to store the formattedResponse after you JObject.Parse() the response from above
            var formattedResponse = JObject.Parse(response);

            // TODO: Write out the current temperature in degrees Fahrenheit
            Console.WriteLine($"The current temperature in {city_name} is: {formattedResponse["main"]["temp"]} °F");
        }
    }
}
