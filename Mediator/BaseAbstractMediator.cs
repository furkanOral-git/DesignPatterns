using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mediator
{
    public abstract class BaseAbstractMediator : IMediator
    {
        private Status _status;

        protected void SetStatusOK()
        {
            _status = Status.OK;
        }
        protected void SetStatusWAIT()
        {
            _status = Status.WAIT;
        }
        protected void SetStatusIGNORED()
        {
            _status = Status.IGNORED;
        }
        protected virtual void ReactToRequest(Type requestType) { }

        public TResponse ResponseIfStatusOk<TResponse>(IRequest<TResponse> request) where TResponse : class
        {
            if (this._status == Status.OK) return this.Response<TResponse>(request);
            else throw new Exception($"Mediator Status : {this._status}, please update mediator status information or this exception tells you something that goes wrong!");
        }
        public TResponse Response<TResponse>(IRequest<TResponse> request) where TResponse : class
        {

            this.ReactToRequest(request.GetType());
            return request.GetHandler().Handle();
        }

    }
}