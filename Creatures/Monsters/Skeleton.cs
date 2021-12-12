namespace Roguelike.Creatures.Monsters
{
    internal class Skeleton : Monster
    {
        public Skeleton(int x, int y)
        {
            Hp = 1;
            Armor = 1;
            monsterPosX = x;
            monsterPosY = y;
        }
        public override char Symbol => 's';
        public override bool isCreature => true;
    }
}