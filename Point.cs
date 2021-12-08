namespace Roguelike
{
    internal class Point : MovementSystem.IConsolePrint
    {
        public virtual bool isCreature => false;
        public virtual bool isBarrier => true;
        public virtual char Symbol => ' ';

        public void Print(int y, int x)
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.Write(Symbol);
        }
    }
}