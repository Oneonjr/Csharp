namespace poo.src.Entities
{
    public class Ninja : Hero
    {
    public Ninja(string Name, int Level, string HeroType, int Life, int Mana)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.Life = Life;
        this.Mana = Mana;
    }
    public override string Attack()
        {
            return this.Name + " Atacou com a sua Kunai.";
        }
    }
}