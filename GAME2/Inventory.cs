using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;

namespace GAME2
{
    public class Inventory
    {
        private int size;
        private int[] items;
        private Item[] Item;
        public Item[] ITems {  get{ return Item; }}
        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }
        public Inventory()
        {
            size = 4;
            gold = 0;
            items = new int[size];
            for (int i = 0; i < items.Length; i++) 
            {
                items[i] = 0; 
            }
            Item = new Item[size];
            Item[0] = new RedPotion();
            Item[1] = new DefencePotion();
            Item[2] = new PowerPotion();
            Item[3] = new Key();
            
        }
        public void Add(int item,int rd)
        {
            items[item] += rd;
            ITems[item].Add();
            Console.WriteLine("{1}개수만큼 증가합니다",rd);
        }
        public void UseAt(int index)
        {
            
            if (Item[index].use == true)
            {
                if (items[index] > 0)
                {
                    Item[index].Interact(Game.Player);
                    Console.WriteLine("{0} 사용합니다", Item[index].name);
                    items[index] -= 1;
                }
                else
                {
                    Console.WriteLine("수량이 부족합니다");
                }
            }
 
        }
        public void GetGold(int gold)
        {
            this.gold += gold;
            Console.WriteLine("골드를 {0}G 획득했습니다",gold);
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
