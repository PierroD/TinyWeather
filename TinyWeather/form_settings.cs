using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyWeather.Utils;
using IWshRuntimeLibrary;
using System.Reflection;

namespace TinyWeather
{
    public partial class form_settings : Form
    {
        public form_settings()
        {
            InitializeComponent();
        }

        static string configFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.ini";
        INIFile ini = new INIFile(configFile);

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(configFile))
                System.IO.File.WriteAllText(configFile, String.Empty);

            using (StreamWriter sw = (System.IO.File.Exists(configFile)) ? System.IO.File.AppendText(configFile) : System.IO.File.CreateText(configFile))
            {
                sw.Flush();
                sw.WriteLine("[Settings]");
                sw.WriteLine($"StartCity={tbox_cityName.Text}");
                sw.WriteLine($"RefreshTime={num_refreshTime.Value}");
                sw.WriteLine($"DarkMode={sw_darkMode.Checked}");
                sw.Close();
            }
            notifyIcon_save.BalloonTipText = "Your settings has been saved successfully";
            notifyIcon_save.Text = "TinyWeather";
            notifyIcon_save.BalloonTipTitle = "Save Notification";
            notifyIcon_save.Icon = SystemIcons.Application;
            notifyIcon_save.Visible = true;
            notifyIcon_save.ShowBalloonTip(1000);
        }

        #region tbox cityName

        private void tbox_cityName_Enter(object sender, EventArgs e)
        {
            if (tbox_cityName.Text == "London")
                tbox_cityName.Text = String.Empty;
        }

        private void tbox_cityName_Leave(object sender, EventArgs e)
        {
            if (tbox_cityName.Text.Length == 0)
                tbox_cityName.Text = "London";
        }
        #endregion

        private void form_settings_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(configFile))
            {
                if (ini.IniReadValue("Settings", "StartCity") != String.Empty)
                    tbox_cityName.Text = ini.IniReadValue("Settings", "StartCity");
                if (bool.Parse(ini.IniReadValue("Settings", "DarkMode")))
                    sw_darkMode.Checked = true;
            }

            (Color, Color, Color) colors = Utils.Utils.CheckDarkMode(bool.Parse(ini.IniReadValue("Settings", "DarkMode")));
            this.BackColor = colors.Item2;
            btn_close.IconColor = colors.Item3;
            foreach (Control lbl in Controls)
            {
                if (lbl is GunaLabel)
                    lbl.ForeColor = colors.Item3;
            }
            tbox_cityName.BaseColor = colors.Item1;
            tbox_cityName.ForeColor = colors.Item3;
            tbox_cityName.FocusedBaseColor = colors.Item1;
            tbox_cityName.FocusedForeColor = colors.Item3;
        }

        private void btn_createShortcut_Click(object sender, EventArgs e)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\TinyWeather.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "New shortcut for TinyWeather";
            shortcut.TargetPath = Directory.GetCurrentDirectory() + @"\TinyWeather.exe";
            shortcut.Save();

            notifyIcon_save.BalloonTipText = "Shortcut created successfully";
            notifyIcon_save.Text = "TinyWeather";
            notifyIcon_save.BalloonTipTitle = "Shortcut created";
            notifyIcon_save.Visible = true;
            notifyIcon_save.ShowBalloonTip(1000);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Do you want to restart TinyWeather ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg.Equals(DialogResult.Yes))
                Application.Restart();
        }
    }
}
