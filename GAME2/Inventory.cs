using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;

namespace GAME2
{
    internal class Inventory
    {
        private int[] items;
        private Item[] Item;
        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }
        public Inventory()
        {
            gold = 0;
            items = new int[4];
            for (int i = 0; i < items.Length; i++) { items[i] = 0; }
            Item = new Item[4];
            Item[0] = new RedPotion();
            Item[1] = new PowerPotion();
            Item[2] = new PowerPotion();
            Item[3] = new DefencePotion();
        }
        public void Add(Item item)
        {
            items[item.No] += 1;
        }
        public void UseAt(int index)
        {
            
            if (Item[index].use == true)
            {
                if (items[index] > 0)
                {
                    Item[index].Interact(Game.Player);
                    Console.WriteLine("{0} 포션을 사용합니다", Item[index].name);
                    items[index] -= 1;
                }
                else
                {
                    Console.WriteLine("수량이 부족합니다");
                }
            }
            else
            {
                Console.WriteLine("다른걸 선택해주세요");
            }
        }
        public void GetGold(int gold)
        {
            this.gold += gold;
        }
        public void PrintALL()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0} : {1} 개",Item[i].name,items[i]);
            }
            Console.WriteLine("Gold : {0}G",gold);
        }
    }
}
