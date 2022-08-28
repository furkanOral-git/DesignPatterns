using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator.Abstract;

namespace Program.MediatorTest
{
    public class SomeEntity : IResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SomeEntity(string name)
        {
            Name = name;
        }
    }
}