using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Abstract
{
    public interface IMediator
    {
        public TResponse Request<TResponse>(IRequest<TResponse> request) where TResponse : class, IResponse;

    }
}