using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Flyweight;

namespace TestUI.FlyweightTest
{
    public static class BulletFireStartCommand
    {
        public static void FireAt(this Bullet bullet, int x, int y)
        {
            //Extrinsic states have been set
            bullet.X = x;
            bullet.Y = y;
            var json = JsonSerializer.Serialize(bullet, new JsonSerializerOptions { WriteIndented = true });
            System.Console.WriteLine("Bullet has been fired by FireStartCommand");
            System.Console.WriteLine(json);
        }
    }
}