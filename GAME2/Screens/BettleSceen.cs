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
        private MosterObject monster;
        ReadingKey key;
        public override void Render()
        {
            monster = Game.mosterQueue.Peek();
            monster.MonsterInfor();
            Console.WriteLine();
            Console.WriteLine();
            Game.Player.PrintStat();
            Console.WriteLine();
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 포션 : 갯수 {0}", Game.Inventory.Itemcount[0]);
            Console.WriteLine("3. 도망");

        }

        public override void Result(in ReadingKey key)
        {
            this.key = key;
        }
        public override void Update()
        {
            Game.Player.Bettle(key,monster);
        }
        public override void Wait()
        {
            Utility.Loding();

        }
        public override void Next()
        {
            if (monster.hp <= 0 ||
                key == ReadingKey.Three)
            {
                Game.mosterQueue.Dequeue();
                Game.ChangeScene(Game.stack.Pop());
            }
            
            
        }
    }
}
