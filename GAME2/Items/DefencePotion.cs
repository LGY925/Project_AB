using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Items
{
    public class DefencePotion : Item
    {
        public DefencePotion()
        {
            No = 3;
            name = "방어 포션";
            effect = 10;
            use = true;
        }
        public override void Interact(Player player)
        {
            player.DpUp(effect);
        }
    }
}
