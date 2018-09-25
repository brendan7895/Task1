using System;

namespace Task1
{
    public class RangedUnit : Unit
    {
        public RangedUnit(int xPos, int yPos, int HP, int maxHP, int speed, int attack, int atkRange, string team, string symbol) : base(xPos, yPos, HP, maxHP, speed, attack, atkRange, team, symbol)
        {

        }

        public override int Attack(int atk)
        {
            throw new System.NotImplementedException();
        }

        public override bool inRange(int enemyX, int enemyY)
        {
            bool value = false;
            int x = Math.Abs(xPos - enemyX);
            int y = Math.Abs(yPos - enemyY);

            if ((x + y) <= atkRange)
            {
                value = true;
            }
            return value;
        }

        public override bool isDead()
        {
            bool value = false;
            if (HP <= 0)
            {
                value = true;
            }
            return value;
        }

        public override string toString()
        {
            return Symbol + " " + Team + " " + XPos + " " + YPos;
        }
    }
}
