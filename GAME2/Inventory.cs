using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;

namespace GAME2
{
    internal class Inventory
    {
        private int[] items;
        private Stack<ScreenLocal> stack;
        private int selectIndex;
        Item[] Item;
        public Inventory()
        {
            items = new int[4];
            stack = new Stack<ScreenLocal>();
            for (int i = 0; i < items.Length; i++) { items[i] = 0; }
            Item = new Item[4];

        }
        public void Add(Item item)
        {
            items[item.No] += 1;
        }
        public void UseAt(ReadingKey readingKey)
        {
            switch (readingKey)
            {
                case ReadingKey.One:
                    if (items[0] > 0)
                        /// <summary>
                        /// 1번에 맞는 아이템 use
                        /// </summary>
                        items[0] -= 1; break;
                case ReadingKey.Two:
                    if (items[1] > 0)
                        /// <summary>
                        /// 2번에 맞는 아이템 use
                        /// </summary>
                        items[1] -= 1; break;
                case ReadingKey.Three:
                    if (items[2] > 0)
                        /// <summary>
                        /// 3번에 맞는 아이템 use
                        /// </summary>
                        items[2] -= 1; break;
            }
        }
        public void PrintALL()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0} : {1} 개",Item[i].name,items[i]);
            }
        }
    }
}
