namespace Roguelike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestField testField = new TestField();
            testField.ShowField();
            while (true)
            {
                testField.Move();
                System.Console.Clear();
                testField.ShowField();
            }
        }
    }
}