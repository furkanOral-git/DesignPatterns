using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Program.MediatorTest;

namespace TestUI.MediatorTest
{
    public class MediatorClientCode
    {
        public static void Run()
        {
            CustomMediator mediator = new CustomMediator();
            CreateSomeEntityRequest request = new CreateSomeEntityRequest();
            request.Name = "Furkan";

            mediator.Response<SomeEntity>(request);
        }
    }
}