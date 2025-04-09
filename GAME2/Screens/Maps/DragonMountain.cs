using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.GameObjects;

namespace GAME2.Screens.Maps
{
    public class DragonMountain :BaseMap
    {
        public DragonMountain()
        {
            name = ScreenLocal.DragonMountain;
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
            gameObjects.Add(new PotalObject(ScreenLocal.SpringField, 'S', new Vector(5, 2)));
            gameObjects.Add(new BoxObject('B', new Vector(5, 6)));
        }
        public override void Enter()
        {
            if (Game.screen == ScreenLocal.SpringField)
            {
                Game.Player.position = new Vector(5, 2);
            }
            Game.Player.map = map;
        }
    }
}
