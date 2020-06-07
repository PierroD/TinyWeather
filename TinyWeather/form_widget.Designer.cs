namespace TinyWeather
{
    partial class form_widget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_widget));
            this.elipse_form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pbox_globalStatus = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_cityName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_temperature = new Guna.UI.WinForms.GunaLabel();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_globalStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.Radius = 5;
            this.elipse_form.TargetControl = this;
            // 
            // pbox_globalStatus
            // 
            this.pbox_globalStatus.BackColor = System.Drawing.Color.Transparent;
            this.pbox_globalStatus.BaseColor = System.Drawing.Color.White;
            this.pbox_globalStatus.Location = new System.Drawing.Point(12, 12);
            this.pbox_globalStatus.Name = "pbox_globalStatus";
            this.pbox_globalStatus.Size = new System.Drawing.Size(40, 26);
            this.pbox_globalStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_globalStatus.TabIndex = 0;
            this.pbox_globalStatus.TabStop = false;
            this.pbox_globalStatus.DoubleClick += new System.EventHandler(this.pbox_globalStatus_DoubleClick);
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cityName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.Location = new System.Drawing.Point(131, 16);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(62, 19);
            this.lbl_cityName.TabIndex = 1;
            this.lbl_cityName.Text = "Lyon, FR";
            this.lbl_cityName.DoubleClick += new System.EventHandler(this.lbl_cityName_DoubleClick);
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temperature.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperature.Location = new System.Drawing.Point(58, 13);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(50, 23);
            this.lbl_temperature.TabIndex = 2;
            this.lbl_temperature.Text = "15 °C";
            this.lbl_temperature.DoubleClick += new System.EventHandler(this.lbl_temperature_DoubleClick);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // form_widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 50);
            this.Controls.Add(this.lbl_temperature);
            this.Controls.Add(this.lbl_cityName);
            this.Controls.Add(this.pbox_globalStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_widget";
            this.Text = "TinyWeather - Widget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_widget_FormClosing);
            this.Load += new System.EventHandler(this.form_widget_Load);
            this.DoubleClick += new System.EventHandler(this.form_widget_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_globalStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipse_form;
        private Guna.UI.WinForms.GunaLabel lbl_temperature;
        private Guna.UI.WinForms.GunaLabel lbl_cityName;
        private Guna.UI.WinForms.GunaPictureBox pbox_globalStatus;
        private System.Windows.Forms.Timer timer_refresh;
    }
}