using System;
namespace Task1
{
    public partial class Map
    {
        Random rand = new Random();
        int numUnits = 4; //number of units to be placed
        string[,] mapArr = new string[20, 20]; //map array

        public Unit[] units; 
       
        public void generate()
        {
            for (int i = 0; i < 20; i++) //populates the map array
            {
                for (int j = 0; j < 20; j++)
                {
                    mapArr[j, i] = ".";
                    //Console.Write(mapArr[j, i]);
                }
                //Console.WriteLine();
            }

            units = new Unit[numUnits];
            for (int i = 0; i < numUnits; i++)
            {
                int x = rand.Next(0, 20);
                int y = rand.Next(0, 20);

                int teamRand = rand.Next(0, 2);

                if (teamRand == 0)
                {
                    units[i] = new MeleeUnit(x, y, 100, 100, 1, 5, 2, Teams(), "F");
                }
                if (teamRand == 1)
                {
                    units[i] = new RangedUnit(x, y, 100, 100, 1, 10, 10, Teams(), "W");
                }
                mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
            }

            //units[0] = new MeleeUnit(0, 0, 100, 100, 1, 5, 2, Team(), "E");
            //units[1] = new MeleeUnit(0, 19, 100, 100, 1, 5, 2, Team(), "F");
            //units[2] = new MeleeUnit(19, 0, 100, 100, 1, 5, 2, Team(), "E");
            //units[3] = new MeleeUnit(19, 19, 100, 100, 1, 5, 2, Team(), "F");
            //for (int i = 0; i < numUnits; i++)
            //{
            //    mapArr[units[i].XPos, units[i].YPos] = units[i].Symbol;
            //}
        }

        public void moveUnit()
        {
            for (int i = 0; i < numUnits; i++)
            {
                Unit temp = units[i].closestUnit(units);



                //if (units[i].XPos == 0)
                //{
                //    units[i].updatePos("d");
                //    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //    mapArr[units[i].XPos - 1, units[i].YPos] = ".";
                //}
                //if(units[i].XPos == 19)
                //{
                //    units[i].updatePos("a");
                //    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //    mapArr[units[i].XPos + 1, units[i].YPos] = ".";
                //}
                //if(units[i].YPos == 0)
                //{
                //    units[i].updatePos("s");
                //    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //    mapArr[units[i].XPos, units[i].YPos - 1] = ".";
                //}
                //if(units[i].YPos == 19)
                //{
                //    units[i].updatePos("w");
                //    mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //    mapArr[units[i].XPos, units[i].YPos + 1] = ".";
                //}

                //else
                //{
                //    int a = rand.Next(0, 4);
                //    switch (a)
                //    {
                //        case 0:
                //            {
                //                units[i].updatePos("d");
                //                mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                mapArr[units[i].XPos - 1, units[i].YPos] = ".";
                //            }
                //            break;
                //        case 1:
                //            {
                //                units[i].updatePos("a");
                //                mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                mapArr[units[i].XPos + 1, units[i].YPos] = ".";
                //            }
                //            break;
                //        case 2:
                //            {
                //                units[i].updatePos("w");
                //                mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                mapArr[units[i].XPos, units[i].YPos + 1] = ".";
                //            }
                //            break;
                //        case 3:
                //            {
                //                units[i].updatePos("s");
                //                mapArr[units[i].XPos, units[i].YPos] = units[i].Team;
                //                mapArr[units[i].XPos, units[i].YPos - 1] = ".";
                //            }
                //            break;
                //    }
                //}
                
            }
            
        }
        public void close()
        {
            for (int k = 0; k < 4; k++)
            {
                units[k].closestUnit(units);
            }

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
    }
}
