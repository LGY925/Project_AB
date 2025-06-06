﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GAME2
{
    public abstract class GameObject : IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector position;
        public bool isOnce;

        public GameObject(ConsoleColor color, char symbol, Vector position, bool isOnce)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.isOnce = isOnce;
        }
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
        
    }
}
