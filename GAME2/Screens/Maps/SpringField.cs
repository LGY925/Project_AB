using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Screens.Maps
{
    public class SpringField : BaseMap
    {
        public SpringField()
        {
            name = ScreenLocal.SpringField;
            mapData = new string[]
            {
             "##########",
             "#        #",
             "#        #",
             "#        #",
             "#        #",
             "#        #",
             "#        #",
             "#        #",
             "#        #",
             "##########",
            };
            map = new bool[10, 10];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
        }

        public override void Enter()
        {
            Game.Player.position = new Vector(1, 1);
            Game.Player.map = map;
        }
    }
}

