using System;
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
        protected bool use;
        public abstract void Interact(Player player);
        public abstract void Use();
    }
}
