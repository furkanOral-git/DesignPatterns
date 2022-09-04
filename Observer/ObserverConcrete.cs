using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observer
{
    public class ObserverConcrete : IObserver
    {
        private readonly string _name;

        public ObserverConcrete(string name)
        {
            _name = name;
        }
        public void ObserveTo(ISubject subject)
        {
            subject.AddObserver(this);
        }

        public void Update(string state)
        {
            System.Console.WriteLine($"{_name} : The state has been changed to {state}");
        }
    }
}