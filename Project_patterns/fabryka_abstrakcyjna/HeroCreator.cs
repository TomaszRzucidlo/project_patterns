using Project_patterns.fabryka_abstrakcyjna.AttackSection;
using Project_patterns.fabryka_abstrakcyjna.DefenseSection;
using Project_patterns.fabryka_abstrakcyjna.Factory;
using Project_patterns.fabryka_abstrakcyjna.WeaponSection;
using System;

namespace Project_patterns.fabryka_abstrakcyjna
{
    public class HeroCreator
    {
        private Attack _attack;
        private Defense _defense;
        private Weapon _weapon;

        public HeroCreator(HeroFactory factory)
        {
            _attack = factory.CreateAttack();
            _defense = factory.CreateDefense();
            _weapon = factory.CreateWeapon();
        }

        public void CheckAttackLevel()
        {
            Console.WriteLine(_attack.Level);
        }
    }
}
