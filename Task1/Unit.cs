namespace Task1
{
    public abstract class Unit
    {
        protected int xPos;
        protected int yPos;
        protected int HP;
        protected int maxHP;
        protected int speed;
        protected int attack;
        protected int atkRange;
        protected string team;
        protected string symbol;

        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        public Unit(int xPos, int yPos, int maxHP, int HP, int speed, int attack, int atkRange, string team, string symbol)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            this.maxHP = maxHP;
            this.HP = HP;
            this.speed = speed;
            this.attack = attack;
            this.atkRange = atkRange;
            this.team = team;
            this.Symbol = symbol;
        }

        public abstract int Move(string direction);
        public abstract int Attack(int atk);
        public abstract bool inRange(int enemyX, int enemyY);
        public abstract int closestUnit(int enemyX, int enemyY);
        public abstract bool isDead(int hp);
        public abstract string toString();
    }
}
