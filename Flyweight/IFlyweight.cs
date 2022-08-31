using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flyweight
{
    public interface IFlyweight<TEntity> where TEntity : class
    {
        public TEntity GetInstrictState();
    }
}