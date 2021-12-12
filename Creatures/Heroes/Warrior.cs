namespace Roguelike.Creatures.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(string name, int posX, int posY)
        {
            Name = name;
            Hp = 10;
            Armor = 1;
            Level = 1;
            Exp = 0;
            heroPosX = posX;
            heroPosY = posY;
        }
        public override char Symbol => 'w';
        public override string ToString() => "Воин";
    }
}