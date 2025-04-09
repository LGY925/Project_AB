using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Screens;
using GAME2;
using GAME2.GameObjects;
using GAME2.GameObjects.MosterObjects;
using GAME2.Items;

namespace GAME2.Screens
{
    internal class BettleSceen : Screen
    {
        private MosterObject Monster;
        ReadingKey key;
        public override void Render()
        {
            Monster = Game.mosterQueue.Peek();
            Monster.Print();
            Console.WriteLine();
            Game.Player.PrintStat();
            Console.WriteLine();
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 포션 : 갯수 {0}", Game.Inventory.Itemcount[0]);
            Console.WriteLine("3. 도망");

        }
        public override void Update()
        {
            switch (key)
            {
                case ReadingKey.One:
                    Monster.Damage();
                    break;
                case ReadingKey.Two:
                    Game.Inventory.UseAt(0);
                    break;
                case ReadingKey.Three:
                    Console.WriteLine("도망갑니다.");
                    Game.ChangeScene(Game.stack.Pop());
                    break;
            }
        }

        public override void Result(in ReadingKey key)
        {
            this.key = key;
            Update();
        }

        public override void Wait()
        {
            Monster.Attack();
            Console.WriteLine("진행하려면 아무키나 눌러주세요.");
            Console.ReadKey(true);
        }
        public override void Next()
        {
            if(Game.mosterQueue.Peek() == null)
            {
                Game.ChangeScene(Game.stack.Pop());
            }
            
        }
    }
}
