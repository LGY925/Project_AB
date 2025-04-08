﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Screens
{
    public class SpringField : BaseMap
    {
        public SpringField()
        {
            name = ScreenLocal.SpringField;
            mapData = new string[]
            {
             "###########",
             "#         #",
             "#         #",
             "#         #",
             "#         #",
             "#         #",
             "#         #",
             "#         #",
             "#         #",
             "###########",
            };
            map = new bool[10, 10];
            for (int y = 0; y < mapData.GetLength(0); y++)
            {
                for (int x = 0; x < mapData.GetLength(1); x++)
                {
                    map[y, x] = mapData[x][y] == '#' ? false : true;
                }

            }

        }
    }
}
