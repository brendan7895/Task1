using System;
namespace Task1
{
    public partial class Map
    {
        Random rand = new Random();
        int numUnits = 5; //number of units to be placed
        string[,] mapArr = new string[20, 20]; //map array

        Unit[] units; 
       
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
            for(int i = 0; i < numUnits; i++)
            {
                int x = rand.Next(0, 20);
                int y = rand.Next(0, 20);

                int teamRand = rand.Next(0, 2);

                if (teamRand == 0)
                {
                    units[i] = new MeleeUnit(x, y, 100, 100, 1, 5, 2, Team(), "F");
                }
                if (teamRand == 1)
                {
                    units[i] = new RangedUnit(x, y, 100, 100, 1, 10, 10, Team(), "W");
                }
                mapArr[units[i].XPos, units[i].YPos] = units[i].Symbol;
            }

            for (int i = 0; i < 20; i++) 
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(mapArr[j, i]);
                }
                Console.WriteLine();
            }
        }

        public void moveUnit()
        {
        }

        public string Team()
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
    }
}
