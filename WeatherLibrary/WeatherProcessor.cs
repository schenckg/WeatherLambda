using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    static public class WeatherProcessor
    {
        private static string OpenWeatherAppID { get; set; }

        public static void InitializeWeatherProcessor(string strOpenWeatherAppID)
        {
            HttpRequest.InitializeAPIClient("http://api.openweathermap.org/data/2.5/");
            OpenWeatherAppID = strOpenWeatherAppID;
        }

        public static async Task<string> LoadWeather(string strZipCode)
        {
            string strURL = $"weather?units=imperial&zip={strZipCode}&appid={OpenWeatherAppID}";
            using (HttpResponseMessage response = await HttpRequest.APIClient.GetAsync(strURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    dynamic results = await response.Content.ReadAsAsync<dynamic>();

                    string strCity = results?.name;
                    string strTemperature = results?["main"]?.temp;
                    strTemperature = strTemperature.Substring(0, strTemperature.IndexOf('.'));
                    string strConditions = results?["weather"]?[0]?.main;

                    string strWeather = $"The weather in {strCity} is {strConditions.ToLower()} with a temperature of {strTemperature} degrees.";

                    return strWeather;
                }

                throw (new Exception(response.ReasonPhrase));
            }
        }
    }
}
