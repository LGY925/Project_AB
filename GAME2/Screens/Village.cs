using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("1. Go To Map");
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
        public override void Next()
        {
            switch (key)
            {
                case ReadingKey.One:
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
