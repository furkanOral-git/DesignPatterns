using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Observer;

namespace TestUI.ObserverTest
{
    public class ObserverClientCode
    {
        public static void Run()
        {
            var subject = new Subject();


            var observer1 = new ObserverConcrete("Observer1");
            var observer2 = new ObserverConcrete("Observer2");
            var observer3 = new ObserverConcrete("Observer3");
            var observer4 = new ObserverConcrete("Observer4");

            observer1.ObserveTo(subject);
            observer2.ObserveTo(subject);
            observer3.ObserveTo(subject);
            observer4.ObserveTo(subject);


            subject.SetState("Update");
            subject.SetState("News");


        }
    }
}