using System.Collections;
using System.Collections.Generic;


namespace Saturation.Mobiles
{
    public class SimpleEnemyShip : Mobile
    {
        public override double Health { get; set; } = 50;
        public override double Attack { get; set; } =  15;

        public List<Bullet> bullets { get; set; }

        public override void Initialize()
        {
            for (int i = 0; i < 50; i++)
                bullets.Add(new Bullet());
        }
    }
}
