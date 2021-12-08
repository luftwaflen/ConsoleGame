namespace Roguelike.Environment
{
    internal class Wall : Allfather
    {
        public Wall()
        {

        }
        public override bool isBarrier => true;
        public override bool isCreature => false;
        public override char Symbol => '#';
    }
}