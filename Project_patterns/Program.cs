using Project_patterns.budowniczy;
using Project_patterns.fabryka_abstrakcyjna.Factory;
using Project_patterns.metoda_wytwórcza;
using Project_patterns.Singleton;
using System;

namespace Project_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //metoda wytwórcza
            //Metoda wytwórcza zajmuje się tworzeniem tylko jednego obiektu. Klasa metody wytwórczej ma tylko jedna metodę, która zwraca jeden konkretny obiekt. 
            //W metodzie wytwórczej klasa Creator (powiedzmy taki odpowiednik ConcreteFactory) nie dziedziczy po żadnym interfejsie czy klasie.
            var creator = new HeroCreator();
            creator.CreateCharacter(CharacterType.ONE);
            creator.CreateWeapon(WeaponType.CROSSBOW);
            var hero = creator.CreateHero();

            //fabryka abstrakcyjna
            //Fabryka abstrakcyjna ma kilka metod które tworzą różne instancje obiektów.
            //W fabryce abstrakcyjnej ConcreteFactory1, ConcreteFactory2 (klasy, które tworzą obiekty) dziedziczą po klasie AbstactFactory. 
            HeroFactory factory = new HeroOneFactory();
            fabryka_abstrakcyjna.HeroCreator heroCreator = new fabryka_abstrakcyjna.HeroCreator(factory);
            heroCreator.CheckAttackLevel();

            //singleton
            //Singleton wymusza dzięki składni języka możliwość stworzenia tylko jednej instancji obiektu danej klasy.
            //Singleton:
            //Kontroluje dostęp do współdzielonego w programie zasobu (np. plik)
            //Dostęp do zasobu jest potrzebny w różnych miejscach w systemie (potrzebny jest w hali z częściami, oraz w miejscu gdzie składane są hulajnogi)
            //Może istnieć tylko jedne obiekt
            var raport = Raport.GetInstance();
            raport.DodajDoRaportu("Wywołano klasę główną");

            //budowniczy
            //Wzorzec projektowy Budowniczy proponuje ekstrakcję kodu konstrukcyjnego obiektu z jego klasy i umieszczenie go w osobnych obiektach zwanych budowniczymi.
            DirectorBud directorBud = new DirectorBud();
            IHeroBuilder standardHeroBuilder = new StandardHeroBuilder();
            IHeroBuilder epicHeroBuilder = new EpicHeroBuilder();

            directorBud.BuildYourHero(standardHeroBuilder);
            directorBud.BuildYourHero(epicHeroBuilder);

            HeroBud standardHero = standardHeroBuilder.GiveBackHero();
            HeroBud epicHero = epicHeroBuilder.GiveBackHero();

            //Prototyp
            //to kreacyjny wzorzec projektowy, który umożliwia kopiowanie już istniejących obiektów bez tworzenia zależności pomiędzy twoim kodem, a klasami obiektów.
        }
    }
}
