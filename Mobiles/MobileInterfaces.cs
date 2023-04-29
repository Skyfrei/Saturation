using System.Collections.Generic;
using Saturation.Powerups;


namespace Saturation.Mobiles
{
    public interface ICanShoot
    {
        List<Bullet> bullets { get; set; }

        void ShootBullet();
    }

    public interface ICarryDamage
    {
        double Damage { get; set; }
        StatusEffects effects { get; set; }
        
    }
}