namespace Task1
{
    public class MeleeUnit : Unit
    {
        public MeleeUnit(int xPos, int yPos, int HP, int maxHP, int speed, int attack, int atkRange, string team, string symbol) : base(xPos, yPos, HP, maxHP, speed, attack, atkRange, team, symbol)
        {

        }

        public override int Attack(int atk)
        {
            throw new System.NotImplementedException();
        }

        public override int closestUnit(int enemyX, int enemyY)
        {
            throw new System.NotImplementedException();
        }

        public override bool inRange(int enemyX, int enemyY)
        {
            throw new System.NotImplementedException();
        }

        public override bool isDead(int hp)
        {
            throw new System.NotImplementedException();
        }

        public override int Move(string direction)
        {
            throw new System.NotImplementedException();
        }

        public override string toString()
        {
            return symbol + " " + team + " " + xPos + " " + yPos;
        }
    }
}
