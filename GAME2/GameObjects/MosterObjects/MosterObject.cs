using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;

namespace GAME2.GameObjects.MosterObjects
{
    public class MosterObject : GameObject
    {
        private ScreenLocal screen;
        public ScreenLocal beseScreen;
        public ProductBuilder ProductBuilder;
        private string name;
        public int hp;
        public int ap;
        public MosterObject(string name,int hp, int ap ,char symbol, Vector position)
            : base(ConsoleColor.Red, symbol, position, true)
        {
            
        }
        public override void Interact(Player player)
        {
            //beseScreen = Game.screen;
            //
            //Game.ChangeScene(screen);
        }

    }
}
