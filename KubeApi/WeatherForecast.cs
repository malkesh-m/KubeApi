using System;

namespace KubeApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class StockForecast
    {
        public DateTime Date { get; set; }

        public int Change { get; set; }

        public double Value { get; set; }
    }
}
