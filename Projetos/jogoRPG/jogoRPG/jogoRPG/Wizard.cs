using System;


namespace jogoRPG
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Wizard()
        {

        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
            
        }

    }
}
