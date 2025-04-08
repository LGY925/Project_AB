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

        

        public override void Render()
        {
            PrintMap();

            Game.Player.printPlayer();

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

    }
}
