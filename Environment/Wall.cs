namespace Roguelike.Environment
{
    internal class Wall : Point
    {
        public Wall()
        {

        }
        public override bool isBarrier => true;
        public override bool isCreature => false;
        public override char Symbol => '#';
    }
}