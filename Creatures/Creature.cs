namespace Roguelike.Creatures
{
    internal abstract class Creature : Allfather, BattleSystem.IDamaged
    {
        public override bool isCreature => true;
        public override bool isBarrier => false;
        public virtual int Hp { get; set; }
        public virtual int Armor { get; set; }
        public void HasBeenDamaged(int damage)
        {
            Hp -= damage;
        }
    }
}