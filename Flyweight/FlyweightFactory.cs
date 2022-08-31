using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Reflection;

namespace Flyweight
{
    public class FlyweightFactory<TEntity> : IFlyweightFactory<TEntity> where TEntity : class
    {
        private Dictionary<string, IFlyweight<TEntity>> _cache;

        public FlyweightFactory(params TEntity[] Args)
        {
            if (_cache == null) _cache = new Dictionary<string, IFlyweight<TEntity>>();

            foreach (var item in Args)
            {
                _cache.Add(this.GetKey(item), new Flyweight<TEntity>(item));
            }
        }
        public IFlyweight<TEntity> GetFlyweight(TEntity instrictState)
        {
            var key = this.GetKey(instrictState);
            if (_cache.Where(t => t.Key == key).Count() == 0)
            {
                var fly = new Flyweight<TEntity>(instrictState);
                _cache.Add(key, fly);
                return fly;
            }
            else
            {
                return _cache[key];
            }
        }
        public void ListFlyweights()
        {
            System.Console.WriteLine($"FlyweightFactory : I have {_cache.Count()} flyweights");
        }
        private string GetKey(TEntity sharedState)
        {
            List<string> elements = new List<string>();
            //Get All Property names of TEntity
            List<string> propertyNames = typeof(TEntity).GetProperties().Select(p => p.Name).ToList();

            //TEntity converted to JsonElement model
            var jsonString = JsonSerializer.Serialize(sharedState);
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonString);

            foreach (var name in propertyNames)
            {
                var value = jsonElement.GetProperty(name).ToString();

                if (value != "")
                {
                    elements.Add(value);
                }

            }
            elements.Sort();
            return string.Join('_', elements);

        }

       
    }
}