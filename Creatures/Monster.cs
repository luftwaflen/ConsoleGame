namespace Roguelike.Creatures
{
    internal abstract class Monster : Creature, BattleSystem.IMonsterAttack, MovementSystem.IMonsterMove
    {
        public int monsterPosX { get; set; }
        public int monsterPosY { get; set; }
    }
}