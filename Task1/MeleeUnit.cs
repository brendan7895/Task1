using System;

namespace Task1
{
    public class MeleeUnit : Unit
    {
        public MeleeUnit(int xPos, int yPos, int HP, int maxHP, int speed, int attack, int atkRange, string team, string symbol) : base(xPos, yPos, HP, maxHP, speed, attack, atkRange, team, symbol)
        {

        }

        public override void Attack()
        {
            HP -= attack;
        }

        public override bool inRange(int enemyX, int enemyY)
        {
            bool value = false;
            int x = Math.Abs(xPos - enemyX);
            int y = Math.Abs(yPos - enemyY);

            if ((x+y) <= atkRange)
            {
                value = true;
            }
            return value;
        }

        public override bool isDead()
        {
            bool value = false;
            if(HP <= 0)
            {
                value = true;
            }
            return value;
        }

        public override string ToString()
        {
            if (HP <= 0)
            {
                Symbol = "Dead";
            }
            return Symbol + ", " + Team + ", " + XPos + ", " + YPos + ", "  + HP;
        }
    }
}
