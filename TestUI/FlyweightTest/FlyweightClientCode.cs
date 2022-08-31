using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flyweight;

namespace TestUI.FlyweightTest
{
    public class FlyweightClientCode
    {
        public static void Run()
        {
            var glockBullet = new Bullet { Range = 20.4, Size = "9mm", Sprite = "bullet.jpg" };
            var rifleBullet = new Bullet { Range = 60.4, Size = "5.56x45mm", Sprite = "m4a1Bullet.jpg" };
            var sniperBullet = new Bullet { Range = 250.3, Size = "7.62x51mm", Sprite = "awpBullet.jpg" };
            FlyweightFactory<Bullet> factory = new FlyweightFactory<Bullet>(glockBullet, rifleBullet, sniperBullet);
            var bullet = factory.GetFlyweight(glockBullet);
            bullet.GetInstrictState().FireAt(5, 50);

        }
    }
}