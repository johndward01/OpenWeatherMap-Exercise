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

            // TODO: Ask for the users API Key and store that in a variable called "api_Key"

            // TODO: Ask the user for their city name and store that in a variable called "city_name"

            // TODO: Create a variable to store the URL (use String Interpolation for the {city_name} and {api_Key}  HINT: Make sure to use the "imperial" measurement endpoint

            // TODO: Create a variable to store the response from your GET request to that URL from above  HINT: Don't forget to call .Result 

            // TODO: Create a variable to store the formattedResponse after you JObject.Parse() the response from above

            // TODO: Write out the current temperature in degrees Fahrenheit
        }
    }
}
