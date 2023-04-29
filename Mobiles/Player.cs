using System.Collections;
using System.Collections.Generic;

using Saturation.Powerups;

namespace Saturation.Mobiles
{
        public class Player : Mobile, ICanShoot
        {
                public override double Health { get; set; } = 300;
                public override double Attack { get; set; } = 35;
                public override double Speed  { get; set; } = 1.2;
                public override double Armor  { get; set; } = 25;

                public List<BasePower> powers;
                public List<Bullet> bullets { get; set; }

                #region Beautify
                public int Score { get; set; }

                #endregion

                public override void Initialize()
                {
                        for (int i = 0; i < 100; i++)
                                bullets.Add(new Bullet());
                }

                #region BulletLogic
                public void ShootBullet()
                {
                        foreach (Bullet bullet in bullets)
                        {
                                if (!bullet.IsFired)
                                        continue;
                                
                                bullet.IsFired = true;
                                return;
                        }
                }
                #endregion

        }
}

