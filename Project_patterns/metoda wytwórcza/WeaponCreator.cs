using Project_patterns.metoda_wytwórcza.Weapons;

namespace Project_patterns.metoda_wytwórcza
{
    public class WeaponCreator
    {
        public Weapon CreateWeapon(WeaponType type)
        {
            Weapon weapon = null;

            switch (type)
            {
                case WeaponType.CROSSBOW: weapon = new Crossbow();
                    break;
                case WeaponType.REVOLVER: weapon = new Revolver();
                    break;
            }

            return weapon;
        }
    }
}
