using System;
using System.Collections.Generic;
using System.Text;

namespace Project_patterns.budowniczy
{
    public interface IHeroBuilder
    {
        void PrepareAttack();
        void PrepareDefense();
        void AddWeapon();
        HeroBud GiveBackHero();
    }
}
