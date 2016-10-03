using System;
using System.Collections.Generic;

namespace Ch02_Observer
{
    public class WeatherDataHandler : IObservable<WeatherData>
    {
        //IObservable<string> a 
        //IObserver<string>
        
        private readonly List<IObserver<WeatherData>> _observers;

        public WeatherDataHandler()
        {
            this._observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber<WeatherData>(_observers, observer);
        }
    }

    public class Unsubscriber<TWeatherData> : IDisposable
    {
        private readonly List<IObserver<TWeatherData>> _observers;
        private readonly IObserver<TWeatherData> _observer;

        public Unsubscriber(List<IObserver<TWeatherData>> observers, IObserver<TWeatherData> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
