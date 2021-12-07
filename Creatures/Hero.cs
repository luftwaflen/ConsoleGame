namespace Roguelike.Creatures
{
    internal abstract class Hero : Creature, BattleSystem.IHeroAttack, MovementSystem.IHeroMove
    {
        public int heroPosX { get; set; }
        public int heroPosY { get; set; }
        public virtual int Level { get; set; }
        public virtual int Exp { get; set; }
        public virtual void LvlUp()
        {
            int expLimit = Level * 100;
            if (Exp == expLimit)
            {
                Level++;
                Exp = 0;
            }
        }

        public void Move(int directionKey, TestField currentField)
        {
            Actions.GameActions action = Actions.GameActions.Stand;
            if (System.Enum.IsDefined(typeof(Actions.GameActions), directionKey))
                action = (Actions.GameActions)directionKey;
            switch (action)
            {
                case Actions.GameActions.Up:
                    {
                        if (MovementSystem.IHeroMove.Step(
                            ref currentField.gameField[heroPosY, heroPosX],
                            ref currentField.gameField[heroPosY - 1, heroPosX])
                            )
                        {
                            heroPosY -= 1;
                            ConsoleRealization.ShowInConsole.ReWriteFieldAfterStep(
                                currentField,
                                (heroPosX, heroPosY + 1),
                                (heroPosX, heroPosY)
                                );
                        }
                    }
                    break;

                case Actions.GameActions.Down:
                    {
                        if (MovementSystem.IHeroMove.Step(ref currentField.gameField[heroPosY, heroPosX],
                            ref currentField.gameField[heroPosY + 1, heroPosX]))
                        {
                            heroPosY += 1;
                            ConsoleRealization.ShowInConsole.ReWriteFieldAfterStep(
                                currentField,
                                (heroPosX, heroPosY - 1),
                                (heroPosX, heroPosY)
                                );
                        }
                    }
                    break;

                case Actions.GameActions.Left:
                    {
                        if (MovementSystem.IHeroMove.Step(ref currentField.gameField[heroPosY, heroPosX],
                            ref currentField.gameField[heroPosY, heroPosX - 1]))
                        {
                            heroPosX -= 1;
                            ConsoleRealization.ShowInConsole.ReWriteFieldAfterStep(
                                currentField,
                                (heroPosX + 1, heroPosY),
                                (heroPosX, heroPosY)
                                );
                        }
                    }
                    break;

                case Actions.GameActions.Right:
                    {
                        if (MovementSystem.IHeroMove.Step(ref currentField.gameField[heroPosY, heroPosX],
                            ref currentField.gameField[heroPosY, heroPosX + 1]))
                        {
                            heroPosX += 1;
                            ConsoleRealization.ShowInConsole.ReWriteFieldAfterStep(
                                currentField,
                                (heroPosX - 1, heroPosY),
                                (heroPosX, heroPosY)
                                );
                        }
                    }
                    break;
            }
        }
    }
}