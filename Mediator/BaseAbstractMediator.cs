using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mediator
{
    public abstract class BaseAbstractMediator : IMediator
    {

        public TResponse Response<TResponse>(IRequest<TResponse> request) where TResponse : class, IResponse
        {
            
            this.ReactToRequest(request.GetType());
            return request.GetHandler().Handle();
        }
        protected virtual void ReactToRequest(Type requestType) { }
        

    }
}