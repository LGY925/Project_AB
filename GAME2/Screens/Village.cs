using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Screens.Maps;
using GAME2;

namespace GAME2.Screens
{
    public class Village : Screen
    {
        private ReadingKey key;
        public Village()
        {
            name = ScreenLocal.Village;
        }

        public override void Render()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************");
            Console.WriteLine("*       Village       *");
            Console.WriteLine("***********************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Go To SpringField");
            Console.WriteLine("2. Go To Shop");
            Console.WriteLine("3. Talking NPC");
            Console.WriteLine("4. 메인화면으로");

        }

        public override void Result(in ReadingKey key)
        {
            this.key = key;
        }

        public override void Wait()
        {
            Utility.Loding();
        }
        public override void Enter()
        {
            Game.screenDic.Remove(ScreenLocal.SpringField);
            Game.screenDic.Remove(ScreenLocal.DragonMountain);
            Game.screenDic.Remove(ScreenLocal.Battle);
            Game.mosterQueue.Clear();
            Game.stack.Clear();
        }
        public override void Exit()
        {
            Game.screenDic.Add(ScreenLocal.SpringField, new SpringField());
            Game.screenDic.Add(ScreenLocal.DragonMountain, new DragonMountain());
            Game.screenDic.Add(ScreenLocal.Battle, new BettleSceen());
            Game.mosterQueue.Clear();
            Game.stack.Clear();
        }
        public override void Next()
        {
            switch (key)
            {
                case ReadingKey.One:
                    
                    Game.ChangeScene(ScreenLocal.SpringField);
                    break;
                case ReadingKey.Two:
                    break;
                case ReadingKey.Three:
                    break;
                case ReadingKey.Foer:
                    Game.ChangeScene(ScreenLocal.Main);
                    break;
                
            }
        }
    }
}
