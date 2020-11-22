using System;

namespace Academy.TemperatureEvent
{
    public class s1
    {
        private Termometro _t;

        public s1(Termometro t)
        {
            this._t = t;
            TemperatureEventHandler del = new TemperatureEventHandler(Temperature_ToHigh);
            this._t.TemperatureTooHigh += del;
        }

        public void Temperature_ToHigh(object sender, double temp)
        {
            Console.WriteLine("Temperatura {0} troppo alta", temp);
        }
    }
}