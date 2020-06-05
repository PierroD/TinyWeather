using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TinyWeather
{
    public class ApiHelper
    {
        private static HttpClient apiUrl { get; set; }
        public static HttpClient init()
        {
            apiUrl = new HttpClient(new HttpClientHandler());
            apiUrl.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");
            apiUrl.DefaultRequestHeaders.Accept.Clear();
            apiUrl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return apiUrl;
        }
    }
}
