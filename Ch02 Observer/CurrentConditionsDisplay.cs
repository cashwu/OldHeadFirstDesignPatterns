using Ch02_Observer.@interface;
using System;

namespace Ch02_Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions : {_temperature} F degress and {_humidity} % humidity ");
        }
    }
}
