namespace Roguelike.MovementSystem
{
    internal interface IHeroMove
    {
        public void Move(int directionKey, TestField currentField);
        static public bool Step(ref Point traveler, ref Point destination)
        {
            if (!destination.isBarrier)
            {
                Point tmp = traveler;
                traveler = destination;
                destination = tmp;
                return true;
            }
            return false;
        }
    }
}