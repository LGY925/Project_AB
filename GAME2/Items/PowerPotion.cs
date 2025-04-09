using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Items
{
    public class PowerPotion : Item
    {
        public PowerPotion()
        {
            No = 2;
            name = "파워 포션";
            effect = 5;
            use = true;
        }
        public override void Add()
        {
            Console.Write("{0}이", name);
        }
        public override void Interact(Player player)
        {
            player.ApUp(effect);
            Console.WriteLine("{0} {1}만큼 올라갑니다","공격력이", effect);
        }
    }
}
