using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator;

namespace Program.MediatorTest
{
    public class SomeEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SomeEntity(string name)
        {
            Name = name;
        }
    }
}