using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator;


namespace Program.MediatorTest
{
    public class CustomMediator : BaseAbstractMediator, IMediator
    {
        protected override void ReactToRequest(Type requestType)
        {
            if (requestType == typeof(CreateSomeEntityRequest)) IfRequestIsCreateSomeEntity();
        }
        public void IfRequestIsCreateSomeEntity()
        {
            System.Console.WriteLine("Mediator : Reacting to request of CreateSomeEntity");
        }
    }
}