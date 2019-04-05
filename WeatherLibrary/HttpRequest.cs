using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WeatherLibrary
{
    static public class HttpRequest
    {
        public static HttpClient APIClient { get; set; }
        private static string BaseAddress { get; set; }

        public static void InitializeAPIClient(string strBaseAddress)
        {
            APIClient = new HttpClient
            {
                BaseAddress = new Uri(strBaseAddress)
            };
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}