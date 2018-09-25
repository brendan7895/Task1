using System;

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
        public string Team { get => team; set => team = value; }

        public Unit(int xPos, int yPos, int maxHP, int HP, int speed, int attack, int atkRange, string team, string symbol)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            this.maxHP = maxHP;
            this.HP = HP;
            this.speed = speed;
            this.attack = attack;
            this.atkRange = atkRange;
            this.Team = team;
            this.Symbol = symbol;
        }

        public abstract int Move(string direction);
        public abstract int Attack(int atk);
        public abstract bool inRange(int enemyX, int enemyY);
        //public abstract int closestUnit(int enemyX, int enemyY);
        public abstract bool isDead(int hp);
        public abstract string toString();

        public void updatePos(string direction) //changes the x or y value based on movement
        {
            switch (direction)
            {
                case "w":
                    {
                        yPos = yPos - 1;
                    }
                    break;
                case "a":
                    {
                        xPos = xPos - 1;                        
                    }
                    break;
                case "s":
                    {
                        yPos = yPos + 1;                       
                    }
                    break;
                case "d":
                    {
                        xPos = xPos + 1;                       
                    }
                    break;
            }
        }

        public int closestUnit(Unit[] unit, int k)
        {
            int closest = 0;
            int x = xPos;
            int y = yPos;
            for(int i = 0; i < 4; i++)
            {
                if (unit[k].team != team && k != i)
                {
                    x = Math.Abs(unit[i].XPos - unit[i].YPos);
                    y = Math.Abs(unit[i].XPos - unit[i].YPos);
                }
                closest = x + y;
                if (closest > (x + y))
                {
                    closest = x + y;
                    //Console.WriteLine(closest);
                }
                
            }

            Console.WriteLine(closest);
            return closest;
        }
    }
}
