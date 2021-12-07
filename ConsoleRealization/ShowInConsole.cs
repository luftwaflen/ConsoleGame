namespace Roguelike.ConsoleRealization
{
    internal static class ShowInConsole
    {
        public static void ShowField(TestField field)
        {
            for (int y = 0; y < field.ySize; y++)
            {
                for (int x = 0; x < field.xSize; x++)
                {
                    System.Console.Write(field.gameField[y, x].Symbol);
                }
                System.Console.WriteLine();
            }
        }
        public static void ReWriteFieldAfterStep(TestField field, (int y, int x) prevCoords, (int y, int x) currentCoords)
        {
            System.Console.SetCursorPosition(prevCoords.y, prevCoords.x);
            System.Console.Write(field[prevCoords.y, prevCoords.x].Symbol);

            System.Console.SetCursorPosition(currentCoords.y, currentCoords.x);
            System.Console.Write(field[currentCoords.y, currentCoords.x].Symbol);
        }
    }
}