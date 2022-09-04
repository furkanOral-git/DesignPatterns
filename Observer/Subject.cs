using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> _observers;
        private string _state = "default";

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
        }


        private void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this._state);
            }
        }
        public void SetState(string state)
        {
            this._state = state;
            NotifyAllObservers();
        }
    }
}