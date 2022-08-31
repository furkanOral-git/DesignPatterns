using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flyweight;

namespace TestUI.FlyweightTest
{
    public class Bullet 
    {
        //Instrict State 
        public string Size { get; set; }
        public string Sprite { get; set; }
        public double Range { get; set; }

        //Extrinsic State
        public int X { get; set; }
        public int Y { get; set; }
        
        

        
    }
}