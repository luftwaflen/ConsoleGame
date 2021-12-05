namespace Roguelike.Environment
{
    internal class Land : Point
    {
        public Land()
        {

        }
        public override bool isBarrier => false;
        public override bool isCreature => false;
        public override char Symbol => '.';
    }
}