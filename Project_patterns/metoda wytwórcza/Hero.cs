using Project_patterns.metoda_wytwórcza.Characters;
using Project_patterns.metoda_wytwórcza.Weapons;

namespace Project_patterns.metoda_wytwórcza
{
    public class Hero
    {
        private Character _character;
        private Weapon _weapon;

        public Hero(Character character, Weapon weapon)
        {
            _character = character;
            _weapon = weapon;
        }
    }
}
