namespace Roguelike.MovementSystem
{
    internal interface IHeroMove
    {
        public void Move(int directionKey, TestField currentField);
        static public bool Step(ref Allfather traveler, ref Allfather destination)
        {
            if (!destination.isBarrier && !destination.isCreature)
            {
                Allfather tmp = traveler;
                traveler = destination;
                destination = tmp;
                return true;
            }
            return false;
        }
    }
}