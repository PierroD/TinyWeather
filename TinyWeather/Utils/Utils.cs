using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyWeather.Utils
{
    public class Utils
    {
        public static double ktoCelsius(double k)
        {
            return (k - 273.15);
        }

        public static double ktoFahreneit(double k)
        {
            return ((k - 273.15) * 9 / 5 + 32);
        }

        public static string windDirection(int num)
        {
            int val = (int)((num / 22.5) + 0.5);
            string[] windDirection = { "North", "NorthNorthEast", "NorthEast", "EastNorthEast", "East", "EastSouthEast", "SouthEast", "SouthSouthEast", "South", "SouthSouthWest", "SouthWest", "WestSouthWest", "West", "WestNorhtWest", "NorthWest", "NorthNorthWest" };
            return windDirection[(val % 16)];
        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);//on recupere la date zero de référence : le 1/1/1970 00:00:00
            return origin.AddSeconds(timestamp);//on ajoute le timestamp (nombre de secondes depuis la date zero)
        }

        public static (Color, Color, Color) CheckDarkMode(bool check)
        {
            Color mainBgColor;
            Color bgColor;
            Color fColor;
            if (check)
            {
                mainBgColor = Color.FromArgb(28, 29, 33);
                bgColor = Color.FromArgb(36, 37, 42);
                fColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                mainBgColor = Color.FromArgb(246, 246, 247);
                bgColor = Color.White;
                fColor = Color.Black;
            }
            return (mainBgColor, bgColor, fColor);
        }
    }
}
