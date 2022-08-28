using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        public TResponse Response<TResponse>(IRequest<TResponse> request) where TResponse : class;
        public TResponse ResponseIfStatusOk<TResponse>(IRequest<TResponse> request) where TResponse : class;
    }
}