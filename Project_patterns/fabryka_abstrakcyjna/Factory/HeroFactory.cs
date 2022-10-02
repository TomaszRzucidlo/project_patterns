using Project_patterns.fabryka_abstrakcyjna.AttackSection;
using Project_patterns.fabryka_abstrakcyjna.DefenseSection;
using Project_patterns.fabryka_abstrakcyjna.WeaponSection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_patterns.fabryka_abstrakcyjna.Factory
{
    public abstract class HeroFactory
    {
        public abstract Attack CreateAttack();
        public abstract Defense CreateDefense();
        public abstract Weapon CreateWeapon();
    }
}
