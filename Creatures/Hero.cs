namespace Roguelike.Creatures
{
    internal abstract class Hero : Creature, BattleSystem.IHeroAttack//, MovementSystem.IHeroMove
    {
        public virtual int Level { get; set; }
        public virtual int Exp { get; set; }
        public virtual void LvlUp()
        {
            int expLimit = Level * 100;
            if (Exp == expLimit)
            {
                Level++;
                Exp = 0;
            }
        }
    }
}