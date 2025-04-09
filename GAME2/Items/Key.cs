using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Items
{
    public class Key : Item
    {
        public Key()
        {
            No = 4;
            name = "Key";
            effect = -1;
            use = true;

        }
        public override void Add()
        {
            Console.Write("{0}가", name);
        }
        public override void Interact(Player player)
        {
            if (player.KeyUsing == false) 
            { 
                Game.Player.BoxReady(use);
                Console.WriteLine("키를 사용합니다.");
                Console.WriteLine("상자를 열수있습니다.");
            }
            else
            {
                Console.WriteLine("상자를 열수있는 상태입니다");
            }
        }
    }
}
