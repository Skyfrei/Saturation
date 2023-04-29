using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Saturation.Mobiles
{
    public abstract class Mobile :  MonoBehaviour
    {
        public virtual double Health { get; set; } =  100;
        public virtual double Attack { get; set; } =  20;
        public virtual double Speed  { get; set; } = 1;
        public virtual double Armor  { get; set; } = 20;

        public virtual void Initialize()
        {

        }

        public void TakeDamage(Mobile receiver, ICarryDamage projectile)
        {
            // Collision happens and then calculations proceed
            receiver.Health = (receiver.Health * receiver.Armor * 0.35) - projectile.Damage;
        }

        private void Start()
        {
            
        }
        private void Update()
        {
            
        }  
        
    }
}


