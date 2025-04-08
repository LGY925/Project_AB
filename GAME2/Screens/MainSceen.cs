using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Screens
{
    public class MainSceen : Screen
    {
        private ReadingKey key;

        public MainSceen()
        {
            name = ScreenLocal.Main;
        }

        public override void Render()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=    R     P     G    =");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("1. 시작하기");
            Console.WriteLine("2. 세이브(미구현)");
            Console.WriteLine("3. 끝내기");
        }
        public override void Result(in ReadingKey key)
        {
            this.key = key;
        }
        public override void Wait()
        {

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
                    Game.EndSwich();
                    break;
                default:
                    Console.WriteLine("다시입력해주세요");
                    break;

            }
        }



    }
}
