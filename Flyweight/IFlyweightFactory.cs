using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flyweight
{
    public interface IFlyweightFactory<TEntity> where TEntity : class
    {
        IFlyweight<TEntity> GetFlyweight(TEntity instrictState);
        private string GetKey(TEntity instrictState) { return "" ;}
    }
}