using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


namespace Saturation.Powerups
{
    [Flags]
    public enum StatusEffects
    {
        Nothing = 0x00000,
        ExtraDamage = 0x00001,
        Poision = 0x00010,
        Electrify = 0x00100,
        Freeze = 0x01000,
        Slow = 0x10000
    };

    public abstract class BasePower : MonoBehaviour
    {
        private void Start()
        {
            
        }
        private void Update()
        {
            
        }    
    }
}



