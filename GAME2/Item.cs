﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2
{
    public abstract class Item : IInteractable
    {
        public int No;
        public string name;
        protected int effect;
        public bool use;
        public abstract void Add();
        public abstract void Interact(Player player);
        
    }
}
