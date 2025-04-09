using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.GameObjects
{
    public class BoxObject : GameObject
    {
        
        public  BoxObject( char symbol, Vector position)
           : base(ConsoleColor.Cyan, symbol, position, false)
        {
            
        }
        public override void Interact(Player player)
        {
            if( player.KeyUsing == true)
            {
                Random random = new Random();
                int rd = random.Next(0, 2);
                Game.Inventory.Add(rd,rd);
               
                rd = random.Next(0, 100);
                Game.Inventory.GetGold(rd);
                this.isOnce = true;
            }
            
        }
    }
}
