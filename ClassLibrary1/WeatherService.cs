using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ClassLibrary1
{

    public class WeatherService
    {
        private string _baseUri = "http://api.openweathermap.org/data/2.5/weather";
        private const string _apiKey = "94b57cd17f0600b04624dfea875aa067";
        
        public Root GetWeather(string city)
        {
            var restClient = new RestClient();
            var restReqquest = new RestRequest(_baseUri);

            restReqquest.AddParameter("appid", _apiKey);
            restReqquest.AddParameter("q",city);

            var root = restClient.Execute<Root>(restReqquest).Data;

            return root;
        }

    }
}
