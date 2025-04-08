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

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("키 설명");
            Console.WriteLine("* 방향키 : 이동");
            Console.WriteLine("* 숫자키 : 선택지 선택");
            Console.WriteLine("* 인벤토리 : I");
            Console.ResetColor();
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

            }
        }



    }
}
