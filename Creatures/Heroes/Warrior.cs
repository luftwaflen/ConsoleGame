namespace Roguelike.Creatures.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior()
        {
            Hp = 10;
            Armor = 1;
            Level = 1;
            Exp = 0;
        }
        public override char Symbol => 'w';
        public override int Hp { get; set; }
        public override int Armor { get; set; }
    }
}