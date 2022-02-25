

namespace jogoRPG
{
    public abstract class Hero
    {

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;



        public override string ToString()
        {
            return "Nome: " +Name + " Level: " + Level + " Hero type: " + HeroType;
        }
        
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}
