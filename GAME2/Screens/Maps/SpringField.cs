﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.GameObjects;

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
            Mapping();
            gameObjects = new List<GameObject>();
            gameObjects.Add(new PotalObject(ScreenLocal.Village, 'V', new Vector(2, 1)));
            gameObjects.Add(new PotalObject(ScreenLocal.DragonMountain, 'D', new Vector(8, 8)));
        }

        public override void Enter()
        {
            if (Game.screen == ScreenLocal.Village)
            {
                Game.Player.position = new Vector(2, 1);
            }
            else if (Game.screen == ScreenLocal.DragonMountain)
            {
                Game.Player.position = new Vector(8, 8);
            }
            Game.Player.map = map;
        }
    }
}

