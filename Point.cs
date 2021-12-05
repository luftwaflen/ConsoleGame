namespace Roguelike
{
    internal class Point
    {
        public virtual bool isCreature => false;
        public virtual bool isBarrier => true;
        public virtual char Symbol => ' ';
    }
}