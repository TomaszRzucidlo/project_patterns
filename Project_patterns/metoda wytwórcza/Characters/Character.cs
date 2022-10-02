using System;
using System.Collections.Generic;
using System.Text;

namespace Project_patterns.metoda_wytwórcza.Characters
{
    public abstract class Character
    {
        public int Power { get; set; }
        public int Defense { get; set; }
        public abstract Character CreateCharacter();
    }
}
