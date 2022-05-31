namespace poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int Life, int Mana)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.Life = Life;
        this.Mana = Mana;
    }
    }
}