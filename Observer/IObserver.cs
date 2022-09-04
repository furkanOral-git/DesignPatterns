using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        void ObserveTo(ISubject subject);
        void Update(string state);
    }
}