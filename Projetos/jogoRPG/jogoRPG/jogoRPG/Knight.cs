using System;


namespace jogoRPG
{
    internal class Knight : Hero
    {

        public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Knight()
        {

        }
    }
}
