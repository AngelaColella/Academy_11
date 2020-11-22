namespace Academy.TemperatureEvent
{
    public delegate void TemperatureEventHandler(object sender, double temp); // dichiarazione del delegate
    public class Termometro
    {
        public event TemperatureEventHandler TemperatureTooHigh; // evento

        public void SimulateTemperature(double temperature)
        {
            if (TemperatureTooHigh != null && temperature > 25)
            {
                TemperatureTooHigh(this, temperature);
            }
        }

        public Termometro()
        {
        }
    }
}