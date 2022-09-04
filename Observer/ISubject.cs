using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        private void NotifyAllObservers() { }
        void AddObserver(IObserver observer);
        void SetState(string state);

    }
}