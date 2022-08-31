using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight<TEntity> : IFlyweight<TEntity> where TEntity : class
    {
        private TEntity _instrictState;

        public Flyweight(TEntity instrictState)
        {
            _instrictState = instrictState;
        }
        public TEntity GetInstrictState()
        {
            return _instrictState;
        }
    }
}