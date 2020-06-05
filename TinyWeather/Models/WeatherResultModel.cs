using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyWeather.Models
{
    public class WeatherResultModel
    {
        public w[] weather { get; set; }
        public WeatherModel main { get; set; }
        public int visibility { get; set; }
        public WeatherModel wind { get; set; }
        public WeatherModel clouds { get; set; }

        public WeatherModel rain { get; set; }
        public WeatherModel snow { get; set; }

        public int dt { get; set; }

        public WeatherModel sys { get; set; }

        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }

    }

    public class w
    {
        #region weather
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        #endregion
    }
}
