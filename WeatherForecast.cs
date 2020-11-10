using System;

namespace ReactAPI_Asp_Day1
{
    public class WeatherForecast
    {

        // In-class API practice:
        // Add a "Precipitation" string property to the WeatherForecast class.
        // Add a random generation of 5 precipitation descriptions to the API method (similar to the summaries).


        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Precipitation { get; set; }
    }
}
