namespace poo.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Life, int Mana){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Mana = Mana;
        }
        public Hero()
        {

        }
        public string Name; 
        public int Level;
        public string HeroType;

        public int Life;

        public int Mana;



        public override string ToString()
        {
            return this.Name + " " + this.Level  + " " + this.HeroType;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua Espada";
        }
    }
}