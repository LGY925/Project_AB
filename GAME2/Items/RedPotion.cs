using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Items
{
    public class RedPotion : Item
    {
        public RedPotion() 
        {
            No = 1;
            name = "빨간 포션";
            effect = 10;
            use = true;
        }
        public override void Add()
        {
            Console.Write("{0}이", name);
        }
        public override void Interact(Player player)
        {
            Console.WriteLine ("{0}만큼 체력이 회복됩니다",effect);
            player.Heal(effect);
        }
    }
}
