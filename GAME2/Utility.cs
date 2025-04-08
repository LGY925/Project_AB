using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2
{
    public static class Utility
    {
        public static void ReadKey(out ReadingKey key)
        {
            ConsoleKey input;
            key = ReadingKey.None;

            input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.I:
                    key = ReadingKey.Inben; 
                    break;
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    key = ReadingKey.One;
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    key = ReadingKey.Two;
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    key = ReadingKey.Three;
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    key = ReadingKey.Foer;
                    break;
                case ConsoleKey.LeftArrow:
                    key = ReadingKey.Left;
                    break;
                case ConsoleKey.RightArrow:
                    key = ReadingKey.Right;
                    break;
                case ConsoleKey.UpArrow:
                    key = ReadingKey.Up;
                    break;
                case ConsoleKey.DownArrow:
                    key = ReadingKey.Down;
                    break;
                case ConsoleKey.Escape:
                    Game.EndSwich();
                    break;


            }

        }

        public static void Loding()
        {
            Console.WriteLine("잠시만요 로딩중입니다");
            Console.WriteLine("아무거나 눌러주세요");
            Console.ReadKey(true);
        }
    }


}
