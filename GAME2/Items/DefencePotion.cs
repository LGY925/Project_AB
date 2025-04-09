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

        public override void Add()
        {
            Console.Write("{0}이",name);
        }

        public override void Interact(Player player)
        {
            Console.WriteLine("{0} {1}만큼 올라갑니다", "방어력이", effect);
            player.DpUp(effect);
            
        }
    }
}
