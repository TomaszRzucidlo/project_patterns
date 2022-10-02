using Project_patterns.metoda_wytwórcza.Characters;

namespace Project_patterns.metoda_wytwórcza
{
    public class CharacterCreator
    {
        public Character CreateCharacter(CharacterType type)
        {
            Character character = null;

            switch (type)
            {
                case CharacterType.ONE: character = new CharacterOne();
                    break;
                case CharacterType.TWO: character = new CharacterTwo();
                    break;
            }

            return character;
        }
    }
}
