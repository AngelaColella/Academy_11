using System;

namespace Academy.TemperatureEvent
{
    public class Helper
    {
        public static double GetRandomDouble(double max, double min)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }
}