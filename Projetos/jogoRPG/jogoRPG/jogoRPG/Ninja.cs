

namespace jogoRPG
{
    internal class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;    
        }

        public Ninja()
        {

        }

        public override string Attack()
        {
            return Name + "Atacou com um golpe de ninja";
        }
        public string Attack(int Bonus)
        {
            return Name + "Atacou com um golpe de ninja com bonus de "+ Bonus;
        }


    }
}
