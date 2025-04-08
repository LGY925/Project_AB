using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.GameObjects
{
    public class PotalObject : GameObject
    {
        private ScreenLocal screen;
        public PotalObject(ScreenLocal screen, char symbol, Vector position)
            : base(ConsoleColor.Blue, symbol, position, false)
        {
            this.screen = screen;
        }
        public override void Interact(Player player)
        {
            Game.ChangeScene(screen);
        }
    }
}
