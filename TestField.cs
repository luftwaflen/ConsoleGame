namespace Roguelike
{
    internal class TestField
    {
        public TestField()
        {
            xSize = 25;
            ySize = 8;
            gameField = new Point[ySize, xSize];
            FieldGenerator();
        }
        public Point[,] gameField;
        public int xSize { get; set; }
        public int ySize { get; set; }
        public Point this[int y, int x]
        {
            get => gameField[y, x];
            set { gameField[y, x] = value; }
        }
        private void FieldGenerator()
        {
            for (int y = 0; y < ySize; y++)
            {
                gameField[y, 0] = new Environment.Wall();
                gameField[y, xSize - 1] = new Environment.Wall();
            }
            for (int x = 0; x < xSize; x++)
            {
                gameField[0, x] = new Environment.Wall();
                gameField[ySize - 1, x] = new Environment.Wall();
            }
            for (int y = 1; y < ySize - 1; y++)
            {
                for (int x = 1; x < xSize - 1; x++)
                {
                    gameField[y, x] = new Environment.Land();
                }
            }
        }        
    }
}