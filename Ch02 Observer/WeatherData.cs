using Ch02_Observer.@interface;
using System.Collections.Generic;

namespace Ch02_Observer
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private float _pressure;
        private float _humidity;
        private float _temperature;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (_observers.Contains(o))
            {
                _observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChange()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChange();
        }
    }
}
