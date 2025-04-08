using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2
{
    public abstract class Screen
    {
        public ScreenLocal name;
        public abstract void Render();
        public abstract void Result(in ReadingKey key);
        public abstract void Wait();
        public abstract void Next();
        public virtual void Enter() { }
        public virtual void Exit() { }
    }
}
