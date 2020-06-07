using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyWeather.Core;
using TinyWeather.Properties;
using TinyWeather.Utils;

namespace TinyWeather
{
    public partial class form_widget : Form
    {
        private static Form parentForm;
        public form_widget(Form frm)
        {
            parentForm = frm;
            InitializeComponent();
        }
        static string configFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.ini";
        INIFile ini = new INIFile(configFile);
        private void form_widget_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            if (File.Exists(configFile))
            {
                LoadElements(ini.IniReadValue("Settings", "StartCity"));
                timer_refresh.Interval = Convert.ToInt32(ini.IniReadValue("Settings", "RefreshTime"));
            }
            else
            {
                LoadElements("London");
                timer_refresh.Interval = 1000;
            }
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2), 0);
           
            if (bool.Parse(ini.IniReadValue("Settings", "TopMost")))
                this.TopMost = true;

            #region Darkmode
            (Color, Color, Color) colors = Utils.Utils.CheckDarkMode(bool.Parse(ini.IniReadValue("Settings", "DarkMode")));
            this.BackColor = colors.Item2;
            lbl_cityName.ForeColor = colors.Item3;
            lbl_temperature.ForeColor = colors.Item3;
            #endregion
        }

        public async void LoadElements(string cityName)
        {
            DateTime today = DateTime.Now;
            var weather = await WeatherService.load(cityName);
            pbox_globalStatus.Image = (Bitmap)Resources.ResourceManager.GetObject(weather.weather[0].icon);

            if (bool.Parse(ini.IniReadValue("Settings", "Fahreneit")))
                lbl_temperature.Text = Math.Round(Utils.Utils.ktoCelsius(weather.main.temp), 1).ToString() + " °C";
            else
                lbl_temperature.Text = Math.Round(Utils.Utils.ktoFahreneit(weather.main.temp), 1).ToString() + " °F";

            lbl_cityName.Text = $"{weather.name}, {weather.sys.country}";

        }

        #region show mainform
        private void lbl_cityName_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbox_globalStatus_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_temperature_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_widget_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void form_widget_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Visible = true;
            parentForm.WindowState = FormWindowState.Normal;
        }

        #endregion

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            LoadElements(lbl_cityName.Text);
        }


    }
}
