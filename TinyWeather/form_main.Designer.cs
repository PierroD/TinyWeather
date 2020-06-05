namespace TinyWeather
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.elipse_form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_left = new Guna.UI.WinForms.GunaPanel();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.tbox_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.pbox_city = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_description = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_hour = new Guna.UI.WinForms.GunaLabel();
            this.lbl_day = new Guna.UI.WinForms.GunaLabel();
            this.lbl_temperatureUnit = new Guna.UI.WinForms.GunaLabel();
            this.lbl_temperature = new Guna.UI.WinForms.GunaLabel();
            this.pbox_globalStatus = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.rbtn_celsius = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rbtn_fahrenheit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_humidityText = new Guna.UI.WinForms.GunaLabel();
            this.lbl_humidityUnit = new Guna.UI.WinForms.GunaLabel();
            this.tbar_humidity = new Guna.UI.WinForms.GunaVTrackBar();
            this.lbl_humidity = new Guna.UI.WinForms.GunaLabel();
            this.lbl_humidityTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_visibilityText = new Guna.UI.WinForms.GunaLabel();
            this.lbl_visibilityUnit = new Guna.UI.WinForms.GunaLabel();
            this.lbl_visibility = new Guna.UI.WinForms.GunaLabel();
            this.lbl_visibilityTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_windDirection = new Guna.UI.WinForms.GunaLabel();
            this.lbl_windUnit = new Guna.UI.WinForms.GunaLabel();
            this.lbl_windSpeed = new Guna.UI.WinForms.GunaLabel();
            this.lbl_windTitle = new Guna.UI.WinForms.GunaLabel();
            this.pbox_sunriseSunset = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_sunset = new Guna.UI.WinForms.GunaLabel();
            this.lbl_sunrise = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_sunriseSunsetTitle = new Guna.UI.WinForms.GunaLabel();
            this.drag_form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.lbl_cityName = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_globalStatus)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.pbox_sunriseSunset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.Radius = 40;
            this.elipse_form.TargetControl = this;
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.White;
            this.pnl_left.Controls.Add(this.lbl_cityName);
            this.pnl_left.Controls.Add(this.btn_search);
            this.pnl_left.Controls.Add(this.tbox_search);
            this.pnl_left.Controls.Add(this.pbox_city);
            this.pnl_left.Controls.Add(this.lbl_description);
            this.pnl_left.Controls.Add(this.gunaSeparator2);
            this.pnl_left.Controls.Add(this.lbl_hour);
            this.pnl_left.Controls.Add(this.lbl_day);
            this.pnl_left.Controls.Add(this.lbl_temperatureUnit);
            this.pnl_left.Controls.Add(this.lbl_temperature);
            this.pnl_left.Controls.Add(this.pbox_globalStatus);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(232, 644);
            this.pnl_left.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.AnimationHoverSpeed = 0.07F;
            this.btn_search.AnimationSpeed = 0.03F;
            this.btn_search.BaseColor = System.Drawing.Color.White;
            this.btn_search.BorderColor = System.Drawing.Color.Black;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::TinyWeather.Properties.Resources.search;
            this.btn_search.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_search.Location = new System.Drawing.Point(9, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = global::TinyWeather.Properties.Resources.search_on;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Size = new System.Drawing.Size(35, 35);
            this.btn_search.TabIndex = 16;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_search
            // 
            this.tbox_search.BackColor = System.Drawing.Color.White;
            this.tbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_search.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.tbox_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_search.Location = new System.Drawing.Point(48, 29);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.SelectedText = "";
            this.tbox_search.Size = new System.Drawing.Size(137, 30);
            this.tbox_search.TabIndex = 15;
            this.tbox_search.Text = "Search for places ...";
            this.tbox_search.Enter += new System.EventHandler(this.tbox_search_Enter);
            this.tbox_search.Leave += new System.EventHandler(this.tbox_search_Leave);
            // 
            // pbox_city
            // 
            this.pbox_city.BackColor = System.Drawing.Color.Transparent;
            this.pbox_city.BaseColor = System.Drawing.Color.White;
            this.pbox_city.Location = new System.Drawing.Point(28, 557);
            this.pbox_city.Name = "pbox_city";
            this.pbox_city.Radius = 15;
            this.pbox_city.Size = new System.Drawing.Size(95, 64);
            this.pbox_city.TabIndex = 14;
            this.pbox_city.TabStop = false;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_description.ForeColor = System.Drawing.Color.Black;
            this.lbl_description.Location = new System.Drawing.Point(24, 535);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(101, 19);
            this.lbl_description.TabIndex = 10;
            this.lbl_description.Text = "Mostly Cloudy";
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(13, 517);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(205, 10);
            this.gunaSeparator2.TabIndex = 13;
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lbl_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_hour.Location = new System.Drawing.Point(129, 463);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(67, 31);
            this.lbl_hour.TabIndex = 12;
            this.lbl_hour.Text = "16:00";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_day.ForeColor = System.Drawing.Color.Black;
            this.lbl_day.Location = new System.Drawing.Point(23, 464);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(100, 29);
            this.lbl_day.TabIndex = 10;
            this.lbl_day.Text = "Monday,";
            // 
            // lbl_temperatureUnit
            // 
            this.lbl_temperatureUnit.AutoSize = true;
            this.lbl_temperatureUnit.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperatureUnit.Location = new System.Drawing.Point(104, 368);
            this.lbl_temperatureUnit.Name = "lbl_temperatureUnit";
            this.lbl_temperatureUnit.Size = new System.Drawing.Size(52, 45);
            this.lbl_temperatureUnit.TabIndex = 11;
            this.lbl_temperatureUnit.Text = "°C";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Font = new System.Drawing.Font("Segoe UI", 54F);
            this.lbl_temperature.Location = new System.Drawing.Point(12, 355);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(118, 96);
            this.lbl_temperature.TabIndex = 10;
            this.lbl_temperature.Text = "10";
            // 
            // pbox_globalStatus
            // 
            this.pbox_globalStatus.BaseColor = System.Drawing.Color.White;
            this.pbox_globalStatus.Image = global::TinyWeather.Properties.Resources._11d;
            this.pbox_globalStatus.Location = new System.Drawing.Point(13, 130);
            this.pbox_globalStatus.Name = "pbox_globalStatus";
            this.pbox_globalStatus.Size = new System.Drawing.Size(205, 196);
            this.pbox_globalStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_globalStatus.TabIndex = 0;
            this.pbox_globalStatus.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(261, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 24);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Today";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Black;
            this.gunaSeparator1.Location = new System.Drawing.Point(265, 45);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(55, 10);
            this.gunaSeparator1.TabIndex = 2;
            // 
            // rbtn_celsius
            // 
            this.rbtn_celsius.AnimationHoverSpeed = 0.07F;
            this.rbtn_celsius.AnimationSpeed = 0.03F;
            this.rbtn_celsius.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_celsius.BaseColor = System.Drawing.Color.White;
            this.rbtn_celsius.BorderColor = System.Drawing.Color.Black;
            this.rbtn_celsius.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rbtn_celsius.Checked = true;
            this.rbtn_celsius.CheckedBaseColor = System.Drawing.Color.Black;
            this.rbtn_celsius.CheckedBorderColor = System.Drawing.Color.Black;
            this.rbtn_celsius.CheckedForeColor = System.Drawing.Color.White;
            this.rbtn_celsius.CheckedImage = null;
            this.rbtn_celsius.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rbtn_celsius.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rbtn_celsius.FocusedColor = System.Drawing.Color.Empty;
            this.rbtn_celsius.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_celsius.ForeColor = System.Drawing.Color.Black;
            this.rbtn_celsius.Image = null;
            this.rbtn_celsius.ImageSize = new System.Drawing.Size(20, 20);
            this.rbtn_celsius.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_celsius.Location = new System.Drawing.Point(702, 10);
            this.rbtn_celsius.Name = "rbtn_celsius";
            this.rbtn_celsius.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.rbtn_celsius.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rbtn_celsius.OnHoverForeColor = System.Drawing.Color.White;
            this.rbtn_celsius.OnHoverImage = null;
            this.rbtn_celsius.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_celsius.OnPressedColor = System.Drawing.Color.Black;
            this.rbtn_celsius.Radius = 22;
            this.rbtn_celsius.Size = new System.Drawing.Size(45, 45);
            this.rbtn_celsius.TabIndex = 3;
            this.rbtn_celsius.Text = "°C";
            this.rbtn_celsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rbtn_celsius.Click += new System.EventHandler(this.rbtn_celsius_Click);
            // 
            // rbtn_fahrenheit
            // 
            this.rbtn_fahrenheit.AnimationHoverSpeed = 0.07F;
            this.rbtn_fahrenheit.AnimationSpeed = 0.03F;
            this.rbtn_fahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_fahrenheit.BaseColor = System.Drawing.Color.White;
            this.rbtn_fahrenheit.BorderColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rbtn_fahrenheit.CheckedBaseColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.CheckedBorderColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.CheckedForeColor = System.Drawing.Color.White;
            this.rbtn_fahrenheit.CheckedImage = null;
            this.rbtn_fahrenheit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rbtn_fahrenheit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rbtn_fahrenheit.FocusedColor = System.Drawing.Color.Empty;
            this.rbtn_fahrenheit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_fahrenheit.ForeColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.Image = null;
            this.rbtn_fahrenheit.ImageSize = new System.Drawing.Size(20, 20);
            this.rbtn_fahrenheit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_fahrenheit.Location = new System.Drawing.Point(763, 10);
            this.rbtn_fahrenheit.Name = "rbtn_fahrenheit";
            this.rbtn_fahrenheit.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.rbtn_fahrenheit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.OnHoverForeColor = System.Drawing.Color.White;
            this.rbtn_fahrenheit.OnHoverImage = null;
            this.rbtn_fahrenheit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_fahrenheit.OnPressedColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.Radius = 22;
            this.rbtn_fahrenheit.Size = new System.Drawing.Size(45, 45);
            this.rbtn_fahrenheit.TabIndex = 4;
            this.rbtn_fahrenheit.Text = "°F";
            this.rbtn_fahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rbtn_fahrenheit.Click += new System.EventHandler(this.rbtn_fahrenheit_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.lbl_humidityText);
            this.gunaElipsePanel1.Controls.Add(this.lbl_humidityUnit);
            this.gunaElipsePanel1.Controls.Add(this.tbar_humidity);
            this.gunaElipsePanel1.Controls.Add(this.lbl_humidity);
            this.gunaElipsePanel1.Controls.Add(this.lbl_humidityTitle);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(580, 367);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 40;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(283, 235);
            this.gunaElipsePanel1.TabIndex = 5;
            // 
            // lbl_humidityText
            // 
            this.lbl_humidityText.AutoSize = true;
            this.lbl_humidityText.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_humidityText.ForeColor = System.Drawing.Color.Black;
            this.lbl_humidityText.Location = new System.Drawing.Point(33, 185);
            this.lbl_humidityText.Name = "lbl_humidityText";
            this.lbl_humidityText.Size = new System.Drawing.Size(87, 29);
            this.lbl_humidityText.TabIndex = 10;
            this.lbl_humidityText.Text = "Normal";
            // 
            // lbl_humidityUnit
            // 
            this.lbl_humidityUnit.AutoSize = true;
            this.lbl_humidityUnit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidityUnit.Location = new System.Drawing.Point(140, 68);
            this.lbl_humidityUnit.Name = "lbl_humidityUnit";
            this.lbl_humidityUnit.Size = new System.Drawing.Size(46, 45);
            this.lbl_humidityUnit.TabIndex = 6;
            this.lbl_humidityUnit.Text = "%";
            // 
            // tbar_humidity
            // 
            this.tbar_humidity.Enabled = false;
            this.tbar_humidity.Location = new System.Drawing.Point(227, 68);
            this.tbar_humidity.Name = "tbar_humidity";
            this.tbar_humidity.Size = new System.Drawing.Size(23, 119);
            this.tbar_humidity.TabIndex = 5;
            this.tbar_humidity.TrackColor = System.Drawing.Color.DodgerBlue;
            this.tbar_humidity.TrackHoverColor = System.Drawing.Color.Gray;
            this.tbar_humidity.TrackIdleColor = System.Drawing.Color.Silver;
            this.tbar_humidity.TrackPressedColor = System.Drawing.Color.Black;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidity.Location = new System.Drawing.Point(23, 61);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_humidity.Size = new System.Drawing.Size(142, 86);
            this.lbl_humidity.TabIndex = 4;
            this.lbl_humidity.Text = "100";
            this.lbl_humidity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_humidityTitle
            // 
            this.lbl_humidityTitle.AutoSize = true;
            this.lbl_humidityTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_humidityTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_humidityTitle.Name = "lbl_humidityTitle";
            this.lbl_humidityTitle.Size = new System.Drawing.Size(91, 26);
            this.lbl_humidityTitle.TabIndex = 3;
            this.lbl_humidityTitle.Text = "Humidity";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.lbl_visibilityText);
            this.gunaElipsePanel2.Controls.Add(this.lbl_visibilityUnit);
            this.gunaElipsePanel2.Controls.Add(this.lbl_visibility);
            this.gunaElipsePanel2.Controls.Add(this.lbl_visibilityTitle);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(265, 367);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 40;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(283, 235);
            this.gunaElipsePanel2.TabIndex = 6;
            // 
            // lbl_visibilityText
            // 
            this.lbl_visibilityText.AutoSize = true;
            this.lbl_visibilityText.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_visibilityText.ForeColor = System.Drawing.Color.Black;
            this.lbl_visibilityText.Location = new System.Drawing.Point(33, 185);
            this.lbl_visibilityText.Name = "lbl_visibilityText";
            this.lbl_visibilityText.Size = new System.Drawing.Size(87, 29);
            this.lbl_visibilityText.TabIndex = 9;
            this.lbl_visibilityText.Text = "Normal";
            // 
            // lbl_visibilityUnit
            // 
            this.lbl_visibilityUnit.AutoSize = true;
            this.lbl_visibilityUnit.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibilityUnit.ForeColor = System.Drawing.Color.Black;
            this.lbl_visibilityUnit.Location = new System.Drawing.Point(148, 115);
            this.lbl_visibilityUnit.Name = "lbl_visibilityUnit";
            this.lbl_visibilityUnit.Size = new System.Drawing.Size(51, 36);
            this.lbl_visibilityUnit.TabIndex = 8;
            this.lbl_visibilityUnit.Text = "km";
            // 
            // lbl_visibility
            // 
            this.lbl_visibility.AutoSize = true;
            this.lbl_visibility.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibility.Location = new System.Drawing.Point(23, 74);
            this.lbl_visibility.Name = "lbl_visibility";
            this.lbl_visibility.Size = new System.Drawing.Size(142, 86);
            this.lbl_visibility.TabIndex = 7;
            this.lbl_visibility.Text = "100";
            // 
            // lbl_visibilityTitle
            // 
            this.lbl_visibilityTitle.AutoSize = true;
            this.lbl_visibilityTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibilityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_visibilityTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_visibilityTitle.Name = "lbl_visibilityTitle";
            this.lbl_visibilityTitle.Size = new System.Drawing.Size(85, 26);
            this.lbl_visibilityTitle.TabIndex = 2;
            this.lbl_visibilityTitle.Text = "Visibility";
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.lbl_windDirection);
            this.gunaElipsePanel3.Controls.Add(this.lbl_windUnit);
            this.gunaElipsePanel3.Controls.Add(this.lbl_windSpeed);
            this.gunaElipsePanel3.Controls.Add(this.lbl_windTitle);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(265, 108);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 40;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(283, 235);
            this.gunaElipsePanel3.TabIndex = 8;
            // 
            // lbl_windDirection
            // 
            this.lbl_windDirection.AutoSize = true;
            this.lbl_windDirection.Font = new System.Drawing.Font("Calibri", 20F);
            this.lbl_windDirection.ForeColor = System.Drawing.Color.Black;
            this.lbl_windDirection.Location = new System.Drawing.Point(32, 185);
            this.lbl_windDirection.Name = "lbl_windDirection";
            this.lbl_windDirection.Size = new System.Drawing.Size(75, 33);
            this.lbl_windDirection.TabIndex = 7;
            this.lbl_windDirection.Text = "WSW";
            // 
            // lbl_windUnit
            // 
            this.lbl_windUnit.AutoSize = true;
            this.lbl_windUnit.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windUnit.ForeColor = System.Drawing.Color.Black;
            this.lbl_windUnit.Location = new System.Drawing.Point(182, 102);
            this.lbl_windUnit.Name = "lbl_windUnit";
            this.lbl_windUnit.Size = new System.Drawing.Size(77, 36);
            this.lbl_windUnit.TabIndex = 6;
            this.lbl_windUnit.Text = "km/h";
            // 
            // lbl_windSpeed
            // 
            this.lbl_windSpeed.AutoSize = true;
            this.lbl_windSpeed.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windSpeed.Location = new System.Drawing.Point(23, 61);
            this.lbl_windSpeed.Name = "lbl_windSpeed";
            this.lbl_windSpeed.Size = new System.Drawing.Size(177, 86);
            this.lbl_windSpeed.TabIndex = 5;
            this.lbl_windSpeed.Text = "1050";
            // 
            // lbl_windTitle
            // 
            this.lbl_windTitle.AutoSize = true;
            this.lbl_windTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_windTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_windTitle.Name = "lbl_windTitle";
            this.lbl_windTitle.Size = new System.Drawing.Size(116, 26);
            this.lbl_windTitle.TabIndex = 1;
            this.lbl_windTitle.Text = "Wind Status";
            // 
            // pbox_sunriseSunset
            // 
            this.pbox_sunriseSunset.BackColor = System.Drawing.Color.Transparent;
            this.pbox_sunriseSunset.BaseColor = System.Drawing.Color.White;
            this.pbox_sunriseSunset.Controls.Add(this.lbl_sunset);
            this.pbox_sunriseSunset.Controls.Add(this.lbl_sunrise);
            this.pbox_sunriseSunset.Controls.Add(this.gunaPictureBox1);
            this.pbox_sunriseSunset.Controls.Add(this.lbl_sunriseSunsetTitle);
            this.pbox_sunriseSunset.Location = new System.Drawing.Point(580, 108);
            this.pbox_sunriseSunset.Name = "pbox_sunriseSunset";
            this.pbox_sunriseSunset.Radius = 40;
            this.pbox_sunriseSunset.Size = new System.Drawing.Size(283, 235);
            this.pbox_sunriseSunset.TabIndex = 7;
            // 
            // lbl_sunset
            // 
            this.lbl_sunset.AutoSize = true;
            this.lbl_sunset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunset.ForeColor = System.Drawing.Color.Black;
            this.lbl_sunset.Location = new System.Drawing.Point(120, 154);
            this.lbl_sunset.Name = "lbl_sunset";
            this.lbl_sunset.Size = new System.Drawing.Size(86, 26);
            this.lbl_sunset.TabIndex = 3;
            this.lbl_sunset.Text = "6:35 AM";
            // 
            // lbl_sunrise
            // 
            this.lbl_sunrise.AutoSize = true;
            this.lbl_sunrise.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunrise.ForeColor = System.Drawing.Color.Black;
            this.lbl_sunrise.Location = new System.Drawing.Point(120, 85);
            this.lbl_sunrise.Name = "lbl_sunrise";
            this.lbl_sunrise.Size = new System.Drawing.Size(86, 26);
            this.lbl_sunrise.TabIndex = 2;
            this.lbl_sunrise.Text = "6:35 AM";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::TinyWeather.Properties.Resources.sunsetsunrise;
            this.gunaPictureBox1.Location = new System.Drawing.Point(38, 61);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(64, 145);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lbl_sunriseSunsetTitle
            // 
            this.lbl_sunriseSunsetTitle.AutoSize = true;
            this.lbl_sunriseSunsetTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunriseSunsetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_sunriseSunsetTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_sunriseSunsetTitle.Name = "lbl_sunriseSunsetTitle";
            this.lbl_sunriseSunsetTitle.Size = new System.Drawing.Size(173, 26);
            this.lbl_sunriseSunsetTitle.TabIndex = 0;
            this.lbl_sunriseSunsetTitle.Text = "Sunrise and Sunset";
            // 
            // drag_form
            // 
            this.drag_form.TargetControl = this;
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.Black;
            this.lbl_cityName.Location = new System.Drawing.Point(3, 77);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(229, 41);
            this.lbl_cityName.TabIndex = 17;
            this.lbl_cityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(838, 17);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 9;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(900, 644);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.pbox_sunriseSunset);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.rbtn_fahrenheit);
            this.Controls.Add(this.rbtn_celsius);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_main";
            this.Text = "TinyWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_globalStatus)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            this.pbox_sunriseSunset.ResumeLayout(false);
            this.pbox_sunriseSunset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipse_form;
        private Guna.UI.WinForms.GunaPanel pnl_left;
        private Guna.UI.WinForms.GunaAdvenceButton rbtn_fahrenheit;
        private Guna.UI.WinForms.GunaAdvenceButton rbtn_celsius;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaLabel lbl_windTitle;
        private Guna.UI.WinForms.GunaElipsePanel pbox_sunriseSunset;
        private Guna.UI.WinForms.GunaLabel lbl_sunriseSunsetTitle;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaLabel lbl_visibilityTitle;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lbl_humidityTitle;
        private Guna.UI.WinForms.GunaLabel lbl_windDirection;
        private Guna.UI.WinForms.GunaLabel lbl_windUnit;
        private Guna.UI.WinForms.GunaLabel lbl_windSpeed;
        private Guna.UI.WinForms.GunaLabel lbl_sunset;
        private Guna.UI.WinForms.GunaLabel lbl_sunrise;
        private Guna.UI.WinForms.GunaLabel lbl_visibilityText;
        private Guna.UI.WinForms.GunaLabel lbl_visibilityUnit;
        private Guna.UI.WinForms.GunaLabel lbl_visibility;
        private Guna.UI.WinForms.GunaLabel lbl_humidityText;
        private Guna.UI.WinForms.GunaLabel lbl_humidityUnit;
        private Guna.UI.WinForms.GunaVTrackBar tbar_humidity;
        private Guna.UI.WinForms.GunaLabel lbl_humidity;
        private Guna.UI.WinForms.GunaLabel lbl_hour;
        private Guna.UI.WinForms.GunaLabel lbl_day;
        private Guna.UI.WinForms.GunaLabel lbl_temperatureUnit;
        private Guna.UI.WinForms.GunaLabel lbl_temperature;
        private Guna.UI.WinForms.GunaPictureBox pbox_globalStatus;
        private Guna.UI.WinForms.GunaDragControl drag_form;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaPictureBox pbox_city;
        private Guna.UI.WinForms.GunaLabel lbl_description;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaLineTextBox tbox_search;
        private Guna.UI.WinForms.GunaLabel lbl_cityName;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}

