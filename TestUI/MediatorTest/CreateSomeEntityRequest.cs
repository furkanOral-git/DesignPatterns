using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator;

namespace Program.MediatorTest
{
    public partial class CreateSomeEntityRequest : IRequest<SomeEntity>
    {
        public string Name { get; set; }

        public IRequestHandler<SomeEntity> GetHandler()
        {
            return new CreateSomeEntityRequestHandler(this);
        }

        public class CreateSomeEntityRequestHandler : IRequestHandler<SomeEntity>
        {
            private readonly CreateSomeEntityRequest _request;

            public CreateSomeEntityRequestHandler(CreateSomeEntityRequest request)
            {
                _request = request;
            }
            
            public SomeEntity Handle()
            {
                System.Console.WriteLine("CreateSomeEntityRequestHandler: Request handled");
                return new SomeEntity(_request.Name);
            }
        }
    }
}