using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net; 
namespace Weather_Appilcation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "601aa1be2ac1dd5f97df21bc47761c28";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", City.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                //picIcon.ImageLocation = "https://openweathermap.org/img/w/ " + Info.Weather[0].icon + ".png";
                labCondition.Text = Info.Weather[0].main;
                labDetail.Text = Info.Weather[0].description;
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labsunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labTemp.Text = Math.Round((Info.main.temp - 273.15)*1.8+32).ToString() + string.Format("°F");
                labWindS.Text = Info.wind.speed.ToString() + "  " + "mph";
                labHumidity.Text = Info.main.humidity.ToString() + "%";


            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();

            return day;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void labTemp_Click(object sender, EventArgs e)
        {

        }

        private void labPressure_Click(object sender, EventArgs e)
        {

        }
    }
}
