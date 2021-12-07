namespace Roguelike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestField testField = new TestField();
            Creatures.Hero warrior = new Creatures.Heroes.Warrior();
            testField[2, 2] = warrior;
            ConsoleRealization.ShowInConsole.ShowField(testField);
            while (true)
            {
                int directionKey = System.Console.ReadKey(true).KeyChar;
                warrior.Move(directionKey, testField);
            }
        }
    }
}