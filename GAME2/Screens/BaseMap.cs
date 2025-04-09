using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Screens
{
    public abstract class BaseMap : Screen
    {
        private ReadingKey key;

        protected string[] mapData;
        protected bool[,] map;
        protected List<GameObject> gameObjects;

        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go?.Print();
            }
            Game.Player.PrintPlayer();

        }

        public override void Result(in ReadingKey key)
        {
            this.key = key;
        }
        public override void Update()
        {
            
            Game.Player.Action(key);
        }

        public override void Wait()
        {
            
        }
        public override void Next()
        {
            
            foreach (GameObject go in gameObjects)
            {
                if (go.position.x == Game.Player.position.x &&
                     go.position.y == Game.Player.position.y)
                {
                    go.Interact(Game.Player);
                    if (go.isOnce == true)
                    {
                        gameObjects.Remove(go);
                    }
                    break;
                }
            }
        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y,x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write('#');
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }
        protected void Mapping()
        {
            map = new bool[10, 10];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
        }

    }
}
