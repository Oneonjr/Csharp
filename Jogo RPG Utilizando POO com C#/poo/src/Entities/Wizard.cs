namespace poo.src.Entities
{
    public class Wizard : Hero 
{
    public Wizard(string Name, int Level, string HeroType, int Life, int Mana)
    {
        this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Mana = Mana;
    }
      public override string Attack()
    {
        return this.Name + " Lançou Magia";
    }
      public string Attack(int Bonus)
    {
        if (Bonus >6)
        {
            return this.Name + " Lançou Magia Super efetiva com bonus de " + Bonus;
        }
        else
        {
            return this.Name + " Lançou sua magia com força fraca com bonus de " + Bonus;
        }
    }
        
}
}


