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
        }

        public override void Result(in ReadingKey key)
        {
            
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
            for (int y = 0; y < mapData.GetLength(0); y++)
            {
                for (int x = 0; x < mapData.GetLength(1); x++)
                {
                    if (map[y,x] = false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("#");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                }
            }
        }

    }
}
