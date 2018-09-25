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
            //gameMap.closetUnit();
            return gameMap.Redraw();
        }
    }
}
