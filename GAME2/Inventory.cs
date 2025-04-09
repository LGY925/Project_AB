using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;
using GAME2.Items.Products;

namespace GAME2
{
    public class Inventory
    {
        private int size;
        private int[] itemsCount;
        public int[] Itemcount {  get { return itemsCount; } }
        private Item[] item;
        public Item[] Items {  get{ return item; }}
        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }
        public List<Product> products;
        public Inventory()
        {
            size = 4;
            gold = 0;
            itemsCount = new int[size];
            for (int i = 0; i < itemsCount.Length; i++) 
            {
                itemsCount[i] = 0; 
            }
            item = new Item[size];
            item[0] = new RedPotion();
            item[1] = new DefencePotion();
            item[2] = new PowerPotion();
            item[3] = new Key();
            products = new List<Product>();
            
        }
        public void Add(int item,int rd)
        {
            itemsCount[item] += rd;
            Items[item].Add();
            Console.WriteLine("{1}개수만큼 증가합니다",rd);
        }
        public void UseAt(int index)
        {
            
            if (item[index].use == true)
            {
                if (itemsCount[index] > 0)
                {
                    item[index].Interact(Game.Player);
                    Console.WriteLine("{0} 사용합니다", item[index].name);
                    itemsCount[index] -= 1;
                }
                else
                {
                    Console.WriteLine("수량이 부족합니다");
                }
            }
        }
        public void GetProduct(Product product)
        {
            Console.WriteLine("{0}를/을 획득합니다", product.name);
            this.products.Add(product);
        }
        public void GetGold(int gold)
        {
            this.gold += gold;
            Console.WriteLine("골드를 {0}G 획득했습니다",gold);
        }
        public void PrintALL()
        {
            for (int i = 0; i < itemsCount.Length; i++)
            {
                Console.WriteLine("{0} : {1} 개",item[i].name,itemsCount[i]);
            }
            Console.WriteLine("Gold : {0}G",gold);
        }
        public void PrintProduct()
        {
            if (products != null)
            {
                for (int index = 0; index < products.Count; index++)
                {
                    Console.WriteLine("{0}. {1} ", index, products[index].name);
                }
            }
            else 
            {
                Console.WriteLine("비어있음"); 
            }
        }
    }
}
