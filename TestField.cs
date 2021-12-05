namespace Roguelike
{
    internal class TestField : MovementSystem.IHeroMove
    {
        public TestField()
        {
            xSize = 25;
            ySize = 8;
            heroPosX = 2;
            heroPosY = 2;
            gameField = new Point[ySize, xSize];
            FieldGenerator();
        }
        Point[,] gameField;
        private int xSize;
        private int ySize;
        public int heroPosX { get; set; }
        public int heroPosY { get; set; }
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
            gameField[heroPosY, heroPosX] = new Creatures.Heroes.Warrior();
        }
        public void ShowField()
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int x = 0; x < xSize; x++)
                {
                    System.Console.Write(gameField[y, x].Symbol);
                }
                System.Console.WriteLine();
            }
        }
        public void Move()
        {
            Actions.GameActions action = Actions.GameActions.Stand;
            int key = System.Console.ReadKey().KeyChar;
            if (System.Enum.IsDefined(typeof(Actions.GameActions), key))
                action = (Actions.GameActions)key;

            switch (action)
            {
                case Actions.GameActions.Up:
                    {
                        if (MovementSystem.IHeroMove.Step(ref gameField[heroPosY, heroPosX],
                            ref gameField[heroPosY - 1, heroPosX]))
                            heroPosY -= 1;
                    }
                    break;

                case Actions.GameActions.Down:
                    {
                        if (MovementSystem.IHeroMove.Step(ref gameField[heroPosY, heroPosX],
                            ref gameField[heroPosY + 1, heroPosX]))
                            heroPosY += 1;
                    }
                    break;

                case Actions.GameActions.Left:
                    {
                        if (MovementSystem.IHeroMove.Step(ref gameField[heroPosY, heroPosX],
                            ref gameField[heroPosY, heroPosX - 1]))
                            heroPosX -= 1;
                    }
                    break;

                case Actions.GameActions.Right:
                    {
                        if (MovementSystem.IHeroMove.Step(ref gameField[heroPosY, heroPosX],
                            ref gameField[heroPosY, heroPosX + 1]))
                            heroPosX += 1;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}