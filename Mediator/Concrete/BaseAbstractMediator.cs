using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator.Abstract;

namespace Mediator.Concrete
{
    public abstract class BaseAbstractMediator : IMediator
    {

        public TResponse Request<TResponse>(IRequest<TResponse> request) where TResponse : class, IResponse
        {
            
            this.ReactToRequest(request.GetType());
            return request.GetHandler().Handle();
        }
        protected virtual void ReactToRequest(Type requestType) { }
        

    }
}