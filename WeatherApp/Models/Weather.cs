using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=ec8089c2c109dff7407da592032dc747&units=imperial";
            //synchronous client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

    }
}