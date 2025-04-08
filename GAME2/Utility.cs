﻿using System;
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


            }

        }
    }


}
