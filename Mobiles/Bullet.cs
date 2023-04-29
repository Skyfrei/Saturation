using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Saturation.Powerups;

namespace Saturation.Mobiles
{
        public class Bullet : Mobile, ICarryDamage
        {
            public bool IsFired;
            public double Damage { get; set; }
            public StatusEffects effects { get; set; } = 0x00000; 

            private void OnCollisionEnter(Collision other)
            {
                
            }
        }
}

