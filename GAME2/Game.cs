using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Screens;
using GAME2.Screens.Maps;

namespace GAME2
{
    public static class Game
    {
        
        private static bool gameEnd;
        private static Dictionary<ScreenLocal, Screen> screenDic;
        private static Screen curSceen;
        public static ScreenLocal screen;
        private static Player player;
        public static Player Player { get { return player; } }
        public static void Start()
        {
            Console.CursorVisible = false; // 커서 지우기 성공
            gameEnd = false;
            player = new Player();

            screenDic = new Dictionary<ScreenLocal, Screen>();
            screenDic.Add(ScreenLocal.Main,new MainSceen());
            screenDic.Add(ScreenLocal.Village, new Village());
            screenDic.Add(ScreenLocal.SpringField, new SpringField());
            screenDic.Add(ScreenLocal.DragonMountain, new DragonMountain());

            curSceen = screenDic[ScreenLocal.Main];
        }
        public static void Run()
        {
            while (gameEnd == false)
            {
                Console.Clear();
                curSceen.Render();
                Utility.ReadKey(out ReadingKey key);
                curSceen.Result(key);
                curSceen.Wait();
                curSceen.Next();
            }
        }
        public static void ChangeScene(ScreenLocal changeScreen)
        {
            screen = curSceen.name;
            
            curSceen.Exit();
            curSceen = screenDic[changeScreen];
            curSceen.Enter();

        }
  
        public static void EndSwich()
        {
            gameEnd = true;
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("*          You Died...           *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine(reason);
            Console.WriteLine();
            Console.WriteLine("처음으로 돌아갑니다.");
            Console.WriteLine("아무키나 눌러주세요");
            Console.ReadKey(true);
            ChangeScene(ScreenLocal.Main);

        }
        public static void End()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("다시 오시길 기원합니다");
            Console.WriteLine("수고하셨습니다");
            Console.ResetColor();
        }

    }


}
