namespace Roguelike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.CursorVisible = false;
            TestField testField = new TestField();

            Creatures.Hero warrior = new Creatures.Heroes.Warrior("Олег", 2, 2);
            testField[2, 2] = warrior;
            Creatures.Monsters.Skeleton firstSkeleton = new Creatures.Monsters.Skeleton(5, 17);
            testField[5, 17] = firstSkeleton;

            testField.PrintField();
            warrior.PrintStats();
            while (true)
            {
                int directionKey = System.Console.ReadKey(true).KeyChar;
                warrior.Move(directionKey, testField);
            }
        }
    }
}