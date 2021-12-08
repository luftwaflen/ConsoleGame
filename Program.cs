namespace Roguelike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.CursorVisible = false;
            TestField testField = new TestField();
            Creatures.Hero warrior = new Creatures.Heroes.Warrior();
            testField[2, 2] = warrior;
            testField.PrintField();
            while (true)
            {
                int directionKey = System.Console.ReadKey(true).KeyChar;
                warrior.Move(directionKey, testField);
            }
        }
    }
}