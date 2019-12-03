using System;
using System.Collections.Generic;

namespace DotNetPatterns
{
    public class Observable<T> : IObservable<T>
    {
        readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber<T>(_observers, observer);
        }

        public void OnCompleted()
        {
            foreach (IObserver<T> observer in _observers)
            {
                observer.OnCompleted();
            }
        }

        public void OnError(Exception error)
        {
            foreach (IObserver<T> observer in _observers)
            {
                observer.OnError(error);
            }
        }

        public void OnNext(T value)
        {
            foreach (IObserver<T> observer in _observers)
            {
                observer.OnNext(value);
            }
        }
    }
}
