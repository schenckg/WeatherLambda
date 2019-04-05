using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherLibrary;

namespace WeatherForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WeatherProcessor.InitializeWeatherProcessor(Properties.Settings.Default.OpenWeatherAppID);
        }

        private async void buttonLookupWeather_Click(object sender, EventArgs e)
        {
            textBoxResults.Clear();
            string strWeather = await WeatherProcessor.LoadWeather(textBoxZipCode.Text);
            textBoxResults.Text = strWeather;
        }
    }
}
