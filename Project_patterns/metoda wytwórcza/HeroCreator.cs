using Project_patterns.metoda_wytwórcza.Characters;
using Project_patterns.metoda_wytwórcza.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_patterns.metoda_wytwórcza
{
    public class HeroCreator
    {
        private Character _character;
        private Weapon _weapon;

        public void CreateCharacter(CharacterType type)
        {
            CharacterCreator characterCreator = new CharacterCreator();
            _character = characterCreator.CreateCharacter(type);
        }

        public void CreateWeapon(WeaponType type)
        {
            WeaponCreator weaponCreator = new WeaponCreator();
            _weapon = weaponCreator.CreateWeapon(type);
        }

        public Hero CreateHero()
        {
            return new Hero(_character, _weapon);
        }
    }
}
