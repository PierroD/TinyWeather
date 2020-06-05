using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TinyWeather.Models;

namespace TinyWeather.Core
{
    public class WeatherService
    {

        public static async Task<WeatherResultModel> load(string cityName)
        {
            using (HttpResponseMessage response = await ApiHelper.init().GetAsync($"weather?q={cityName}&appid=1bcc6336317cecebc65a7d48e06b236d"))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherResultModel result = await response.Content.ReadAsAsync<WeatherResultModel>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
