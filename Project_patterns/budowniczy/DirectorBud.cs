using System;
using System.Collections.Generic;
using System.Text;

namespace Project_patterns.budowniczy
{
    public class DirectorBud
    {
        public void BuildYourHero(IHeroBuilder heroBuilder)
        {
            heroBuilder.PrepareAttack();
            heroBuilder.PrepareDefense();
            heroBuilder.AddWeapon();
        }
    }
}
