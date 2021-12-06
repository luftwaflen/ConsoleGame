namespace Roguelike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestField testField = new TestField();
            Creatures.Hero warrior = new Creatures.Heroes.Warrior();
            testField[2, 2] = warrior;
            testField.ShowField();


            
            //warrior.Move();
        }
    }
}