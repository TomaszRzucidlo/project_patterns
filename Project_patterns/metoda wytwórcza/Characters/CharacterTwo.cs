using System;
using System.Collections.Generic;
using System.Text;

namespace Project_patterns.metoda_wytwórcza.Characters
{
    public class CharacterTwo : Character
    {
        public override Character CreateCharacter()
        {
            return new CharacterTwo();
        }
    }
}
