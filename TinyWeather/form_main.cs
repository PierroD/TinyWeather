using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyWeather.Core;
using TinyWeather.Properties;

namespace TinyWeather
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadElements("London");
        }
        private dynamic weather;
        public async void LoadElements(string cityName)
        {
            try
            {
                DateTime today = DateTime.Now;

                weather = await WeatherService.load(cityName);



                #region wind speed
                lbl_windSpeed.Text = weather.wind.speed.ToString();
                lbl_windUnit.Location = new Point(lbl_windSpeed.Width - 2, lbl_windUnit.Location.Y);
                lbl_windDirection.Text = windDirection(weather.wind.deg);
                #endregion

                #region sunset&sunrise
                lbl_sunrise.Text = ConvertFromUnixTimestamp(weather.sys.sunrise).ToLocalTime().ToString(@"hh\:mm") + " AM";
                lbl_sunset.Text = ConvertFromUnixTimestamp(weather.sys.sunset).ToLocalTime().ToString(@"hh\:mm") + " PM";
                #endregion

                #region visibility
                double visibility = weather.visibility / 1000;
                lbl_visibility.Text = visibility.ToString();
                lbl_visibilityUnit.Location = new Point(lbl_visibility.Width - 2, lbl_visibilityUnit.Location.Y);
                switch (visibility)
                {
                    case double n when (n >= 7):
                        lbl_visibilityText.Text = "Normal";
                        break;
                    case double n when (n >= 5):
                        lbl_visibilityText.Text = "Average";
                        break;
                    case double n when (n >= 0):
                        lbl_visibilityText.Text = "Bad";
                        break;
                }
                #endregion

                #region humidity
                int humidity = weather.main.humidity;
                lbl_humidity.Text = humidity.ToString();
                lbl_humidityUnit.Location = new Point(lbl_humidity.Width - 2, lbl_humidityUnit.Location.Y);
                tbar_humidity.Value = humidity;
                switch (ktoCelsius(weather.main.temp))
                {
                    case double n when ((n >= 20 && n <= 40 && humidity <= 40) || (n >= 10 && n <= 20 && humidity <= 30) || (n <= 10 && humidity <= 20)):
                        lbl_humidityText.Text = "Normal";
                        break;
                    case double n when (humidity <= 10):
                        lbl_humidityText.Text = "Too dry";
                        break;
                    default:
                        lbl_humidityText.Text = "Too wet";
                        break;
                }
                #endregion

                #region left_panel
                lbl_cityName.Text = weather.name;
                lbl_temperature.Text = Math.Round(ktoCelsius(weather.main.temp), 1).ToString();
                lbl_temperatureUnit.Location = new Point(lbl_temperature.Width - 3, lbl_temperatureUnit.Location.Y);
                lbl_day.Text = $"{today.DayOfWeek},";
                lbl_hour.Location = new Point(lbl_day.Location.X + lbl_day.Width, lbl_day.Location.Y);
                lbl_hour.Text = today.ToShortTimeString();
                lbl_description.Text = weather.weather[0].description;
                pbox_globalStatus.Image = (Bitmap)Resources.ResourceManager.GetObject(weather.weather[0].icon);
                pbox_city.Load($"https://www.countryflags.io/{weather.sys.country}/shiny/64.png");
                #endregion
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{tbox_search.Text} doesn't exist inside our database or in real life", "City not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Utils
        static double ktoCelsius(double k)
        {
            return (k - 273.15);
        }

        static double ktoFahreneit(double k)
        {
            return ((k - 273.15) * 9 / 5 + 32);
        }

        static string windDirection(int num)
        {
            int val = (int)((num / 22.5) + 0.5);
            string[] windDirection = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW" };
            return windDirection[(val % 16)];
        }

        static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);//on recupere la date zero de référence : le 1/1/1970 00:00:00
            return origin.AddSeconds(timestamp);//on ajoute le timestamp (nombre de secondes depuis la date zero)
        }
        #endregion


        private void rbtn_celsius_Click(object sender, EventArgs e)
        {
            lbl_temperatureUnit.Text = "°C";
            lbl_temperature.Text = Math.Round(ktoCelsius(weather.main.temp), 1).ToString();
            lbl_temperatureUnit.Location = new Point(lbl_temperature.Width - 3, lbl_temperatureUnit.Location.Y);
        }

        private void rbtn_fahrenheit_Click(object sender, EventArgs e)
        {
            lbl_temperatureUnit.Text = "°F";
            lbl_temperature.Text = Math.Round(ktoFahreneit(weather.main.temp), 1).ToString();
            lbl_temperatureUnit.Location = new Point(lbl_temperature.Width - 3, lbl_temperatureUnit.Location.Y);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadElements(tbox_search.Text);
        }

        private void tbox_search_Enter(object sender, EventArgs e)
        {
            if (tbox_search.Text == "Search for places ...")
                tbox_search.Text = String.Empty;
        }

        private void tbox_search_Leave(object sender, EventArgs e)
        {
            if (tbox_search.Text == String.Empty)
                tbox_search.Text = "Search for places ...";

        }
    }
}
