namespace Roguelike.Creatures
{
    internal abstract class Monster : Creature, BattleSystem.IMonsterAttack, MovementSystem.IMonsterMove
    {
    }
}