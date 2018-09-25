namespace Task1
{
    public class GameEngine
    {
        Map gameMap = new Map();

        public void start()
        {
            gameMap.generate();
            
        }

        public string playGame()
        {
            gameMap.moveUnit();
            gameMap.close();
            return gameMap.Redraw();
        }

        public string UnitsString(int i)
        {
            return gameMap.UnitsCombo(i);
        }
        public int numUnit()
        {
            return gameMap.numUnit();
        }
    }
}
