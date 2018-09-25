﻿using System;
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
            //for (int i = 0; i < numUnits; i++)
            //{
            //    int x = rand.Next(0, 20);
            //    int y = rand.Next(0, 20);

            //    int teamRand = rand.Next(0, 2);

            //    if (teamRand == 0)
            //    {
            //        units[i] = new MeleeUnit(x, y, 100, 100, 1, 5, 2, Team(), "F");
            //    }
            //    if (teamRand == 1)
            //    {
            //        units[i] = new RangedUnit(x, y, 100, 100, 1, 10, 10, Team(), "W");
            //    }
            //    mapArr[units[i].XPos, units[i].YPos] = units[i].Symbol;
            //}
            units[0] = new MeleeUnit(0, 0, 100, 100, 1, 5, 2, Team(), "F");
            units[1] = new MeleeUnit(0, 19, 100, 100, 1, 5, 2, Team(), "F");
            units[2] = new MeleeUnit(19, 0, 100, 100, 1, 5, 2, Team(), "F");
            units[3] = new MeleeUnit(19, 19, 100, 100, 1, 5, 2, Team(), "F");
            for (int i = 0; i < numUnits; i++)
            {
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
            units[0].updatePos("d");
           // int temp = units[0].XPos;
            mapArr[units[0].XPos, units[0].YPos] = units[0].Symbol;
            mapArr[units[0].XPos-1, units[0].YPos] = ".";

            
        }

        public void closetUnit()
        {
            int x = units[0].XPos;
            int y = units[0].YPos;

            int x1 = units[2].XPos;
            int y1 = units[2].YPos;

            int abs = (Math.Abs(x - x1)) + (Math.Abs(y - y1));

            if(x < x1)
            {
                units[0].updatePos("d");
                mapArr[units[0].XPos, units[0].YPos] = units[0].Symbol;
                mapArr[units[0].XPos - 1, units[0].YPos] = ".";
            }
            Console.WriteLine(abs);
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
