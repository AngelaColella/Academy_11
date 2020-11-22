using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TemperatureEvent
{
    class Program
    {
        static void Main(string[] args)
        {           
                Termometro t = new Termometro();
                s1 subscriber1 = new s1(t);
                double temperature = 0;

                for (int i = 0; i < 50; i++)
                {
                    temperature = Helper.GetRandomDouble(20, 31);
                    t.SimulateTemperature(temperature);
                }
        }
    }
}
