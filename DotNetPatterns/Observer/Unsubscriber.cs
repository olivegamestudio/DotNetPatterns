﻿using System;
using System.Collections.Generic;

namespace DotNetPatterns
{
    public class Unsubscriber<T> : IDisposable
    {
        readonly List<IObserver<T>> _observers;

        readonly IObserver<T> _observer;

        internal Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
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
