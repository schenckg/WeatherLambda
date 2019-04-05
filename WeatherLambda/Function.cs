using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using WeatherLibrary;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace WeatherLambda
{
    public class Function
    {
        /// <summary>
        /// A simple function that takes a zip code and returns a description of the weather
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<object> FunctionHandler(dynamic input, ILambdaContext context)
        {
            Console.WriteLine("-------- Function Handler ----------");
            //.WriteLine(input);

            // Check if we need to initialize our HTTPRequest
            if (HttpRequest.APIClient == null)
            {
                // Retrieved the Open Weather APP ID from the environment
                string strAppID = Environment.GetEnvironmentVariable("OpenWeatherAppID");

                // Now use it to initialize the HTTPRequest
                WeatherProcessor.InitializeWeatherProcessor(strAppID);
            }

            // Parameter data passed with Invoke AWS Lambda Function request.
            string strZipCode = input?["Details"]?["Parameters"]?.ZipCode;
            if (string.IsNullOrEmpty(strZipCode) || strZipCode.Length != 5)
            {
                Console.WriteLine("Zip code was not set or wasn't five digits");
                return new
                {
                    message = "ZipCode parameter was not set"
                };
            }

            Console.WriteLine($"Zip Code: {strZipCode}");

            // Lookup the weather for the zip code
            try
            {
                string strWeather = await WeatherProcessor.LoadWeather(strZipCode);
                Console.WriteLine(strWeather);

                // Return it
                var result = new
                {
                    message = $"\"{strWeather}\""
                };
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new
                {
                    message = $"The Lambda Function had an exception.  {ex.Message}"
                };
            }
        }
    }
}
