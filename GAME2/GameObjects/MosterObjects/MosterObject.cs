using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items.Products;

namespace GAME2.GameObjects.MosterObjects
{
    public class MosterObject : GameObject
    {
        private ScreenLocal screen;
        
        public ProductBuilder ProductBuilder;
        public string name;
        public int hp;
        public int ap;
        public int gold;
        public Product product;
        public MosterObject mosterObject;
        
        
        
        public MosterObject(string name, int hp, int ap,
            Product product,int gold,char symbol, Vector position )
            : base(ConsoleColor.Red, symbol, position, true)
        {
            this.name = name;
            this.hp = hp;
            this.ap = ap;
            this.product = product;
            this.gold = gold;
            screen = ScreenLocal.Battle;
            this.product = product;
            
        }

        public override void Interact(Player player)
        {
            Game.mosterQueue.Enqueue(this);
            Game.ChangeScene(screen);
        }
        public void MonsterInfor()
        {
            Console.WriteLine();
            Console.WriteLine("  이름 :  {0}",name);
            Console.WriteLine("   HP  :  {0}",hp);
            Console.WriteLine("       {0}    ",symbol);
            Console.WriteLine("     {0} {1} {2}", symbol, symbol, symbol);
            Console.WriteLine("       {0}    ", symbol);
        }

        public void Damage()
        {
            int attackDamage = Game.Player.Attack();
            hp -= attackDamage;
            if(hp>0)
                Console.WriteLine("{0} 의 체력은 : {1}",name,hp);
            else 
                Console.WriteLine("{0} 의 체력은 : {1}", name, 0);
        }

        public void Attack()
        {
            Random random = new();
            int attackDamage = random.Next(ap / 2, ap * 2);
            Console.WriteLine("{0}의 공격", name);
            Console.WriteLine("플레이어를 공격합니다", attackDamage);
            Console.WriteLine("{0} 데미지", attackDamage);
            Game.Player.Damage(attackDamage);
            
        }

        public void inforPrint()
        {
            Console.WriteLine("{0}", name);
            Console.WriteLine("HP : {0}", hp);
        }

    }
}
