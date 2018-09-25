using System;
namespace Task1
{
    public partial class Map
    {
        Random rand = new Random();
        int numUnits = 5; //number of units to be placed
        string[,] mapArr = new string[20, 20]; //map array

        public Unit[] units; 
       
        public void generate()
        {
            for (int i = 0; i < 20; i++) //populates the map array
            {
                for (int j = 0; j < 20; j++)
                {
                    mapArr[j, i] = ".";
                }
            }

            units = new Unit[numUnits];

            for (int i = 0; i < numUnits; i++) //creates and places the units in the map
            {
                int x = rand.Next(0, 20);
                int y = rand.Next(0, 20);

                int teamRand = rand.Next(0, 2);

                if (teamRand == 0)
                {
                    units[i] = new MeleeUnit(x, y, 100, 100, 1, 10, 5, Teams().ToLower(), "F");
                }
                if (teamRand == 1)
                {
                    units[i] = new RangedUnit(x, y, 100, 100, 1, 10, 10, Teams(), "W");
                }
                mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
            }

        }

        public void moveUnit()
        {
            int numArr = units.Length;

            for (int i = 0; i < numUnits; i++)
            {
                Unit temp = units[i].closestUnit(units);
                if(units[i].inRange(temp.XPos, temp.YPos) == false)
                {
                    if (units[i].XPos < temp.XPos)
                    {
                        units[i].updatePos("d");
                        mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                        mapArr[units[i].XPos - 1, units[i].YPos] = ".";
                    }

                    if (units[i].XPos > temp.XPos)
                    {
                        units[i].updatePos("a");
                        mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                        mapArr[units[i].XPos + 1, units[i].YPos] = ".";
                    }

                    if (units[i].YPos < temp.YPos)
                    {
                        units[i].updatePos("s");
                        mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                        mapArr[units[i].XPos, units[i].YPos - 1] = ".";
                    }

                    if (units[i].YPos > temp.YPos)
                    {
                        units[i].updatePos("w");
                        mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                        mapArr[units[i].XPos, units[i].YPos + 1] = ".";
                    }
                }
                
                if(units[i].inRange(temp.XPos, temp.YPos) == true)
                {
                    if(units[i].isDead() == false)
                    {
                        units[i].Attack();
                    }
                    
                }

                //if(units[i].HP <= 25 && units[i].isDead() == false) //units running away below 25%
                //{
                //    int choice = rand.Next(0, 4);

                //    if (units[i].XPos != 19 && units[i].YPos != 19 && units[i].XPos != 0 && units[i].YPos != 0)
                //    {
                //        switch (choice)
                //        {
                //            case 0:
                //                {
                //                    units[i].updatePos("d");
                //                    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                    mapArr[units[i].XPos - 1, units[i].YPos] = ".";

                //                }
                //                break;
                //            case 1:
                //                {
                //                    units[i].updatePos("a");
                //                    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                    mapArr[units[i].XPos + 1, units[i].YPos] = ".";

                //                }
                //                break;
                //            case 2:
                //                {
                //                    units[i].updatePos("s");
                //                    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                    mapArr[units[i].XPos, units[i].YPos - 1] = ".";
                //                }
                //                break;
                //            case 3:
                //                {
                //                    units[i].updatePos("w");
                //                    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                    mapArr[units[i].XPos, units[i].YPos + 1] = ".";
                //                }
                //                break;
                //        }

                //    }
                //}
                if(units[i].isDead() == true)
                {
                    mapArr[units[i].XPos, units[i].YPos] = ".";
                }
            }
            
        }
        public void close()
        {
            for (int k = 0; k < numUnits; k++)
            {
                units[k].closestUnit(units);
            }

        }

        public int numUnit()
        {
            return units.Length;
        }
        
        public string Teams()
        {
            int i = rand.Next(0, 2);
            string sym = "";

            if (i == 0)
            {
                sym = "S";
            }
            if (i == 1)
            {
                sym = "M";
            }
            return sym;
        }

        public string Redraw()
        {
            string value = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    value += mapArr[j, i];
                }
                value += "\n";
            }
            return value;
        }

        public string UnitsCombo(int i)
        {
            return units[i].ToString();
        }
    }
}
